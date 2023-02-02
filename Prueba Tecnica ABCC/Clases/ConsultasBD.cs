using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prueba_Tecnica_ABCC.Clases;

namespace Prueba_Tecnica_ABCC.Clases
{
    public class ConsultasBD
    {
        //obtiene la cadena de conexion
        SqlConnection Conexion;
        public string GetStringConnection()
        {

            string IpConexion = ConfigurationManager.AppSettings.Get("IpConexion");
            string BaseDatos = ConfigurationManager.AppSettings.Get("BaseDatos");

            string conexionString = "server= " + IpConexion + "; database = " + BaseDatos + "; Trusted_Connection=True";

            return conexionString;
        }

        //inicia la conexion a sql server
        public SqlConnection Conectar()
        {
            Conexion = new SqlConnection(GetStringConnection());
            return Conexion;
        }
        
        //obtiene el objeto Producto por medio del SKU
        public Producto getProducto(string sku)
        {
            try
            {
                Conectar().Open();
                SqlCommand cmd = new SqlCommand("exec SP_ConsultaProducto " + sku, Conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                Producto productoObtenido = new Producto();

                foreach (DataRow renglon in tabla.Rows)
                {
                    bool descontinuado;
                    if (Convert.ToInt32(renglon[9].ToString()) == 0)
                    {
                        descontinuado = false;
                    }
                    else
                    {
                        descontinuado = true;
                    }
                    Producto p = new Producto()
                    {
                        Sku = Convert.ToInt32(renglon[0].ToString()),
                        Articulo = renglon[1].ToString(),
                        Marca = renglon[2].ToString(),
                        Modelo = renglon[3].ToString(),
                        Departamento = renglon[4].ToString(),
                        Clase = renglon[5].ToString(),
                        Familia = renglon[6].ToString(),
                        Stock = Convert.ToInt32(renglon[7].ToString()),
                        Cantidad = Convert.ToInt32(renglon[8].ToString()),
                        Descontinuado = descontinuado,
                        FechaAlta = Convert.ToDateTime(renglon[10].ToString()),
                        FechaBaja = Convert.ToDateTime(renglon[11].ToString()),
                    };

                    productoObtenido = p;
                }
                
                if(productoObtenido != null)
                {
                    return productoObtenido;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            
        }


        //obtiene una lista de objetos tipo Departamento
        public List<Departamento> getDepartamentos()
        {
            try
            {
                Conectar().Open();
                SqlCommand cmd = new SqlCommand("exec SP_ConsultaDepartamentos", Conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                List<Departamento> departamentos = new List<Departamento>();

                foreach (DataRow renglon in tabla.Rows)
                {
                    Departamento d = new Departamento()
                    {
                        IdDepartamento = Convert.ToInt32(renglon[0].ToString()),
                        Nombre = renglon[1].ToString(),
                    };

                    departamentos.Add(d);
                }

                if (departamentos.Count > 0)
                {
                    return departamentos;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //obtiene una lista de objetos tipo Clase
        public List<Clase> getClases(string DepartamentoSeleccionado)
        {
            try
            {
                Conectar().Open();
                SqlCommand cmd = new SqlCommand("exec SP_ConsultaClase '"+ DepartamentoSeleccionado+"'", Conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                List<Clase> clases = new List<Clase>();

                foreach (DataRow renglon in tabla.Rows)
                {
                    Clase c = new Clase()
                    {
                        IdClase = Convert.ToInt32(renglon[0].ToString()),
                        IdDepartamento = Convert.ToInt32(renglon[1].ToString()),
                        Nombre = renglon[2].ToString(),
                    };

                    clases.Add(c);
                }

                if (clases.Count > 0)
                {
                    return clases;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //obtiene una lista de objetos tipo Familia
        public List<Familia> getFamilias(string DepartamentoSeleccionado, string ClaseSeleccionada)
        {
            try
            {
                Conectar().Open();
                SqlCommand cmd = new SqlCommand("exec SP_ConsultaFamilia '" + DepartamentoSeleccionado + "', '"+ClaseSeleccionada+"'", Conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                List<Familia> familias = new List<Familia>();

                foreach (DataRow renglon in tabla.Rows)
                {
                    Familia f = new Familia()
                    {
                        IdFamilia = Convert.ToInt32(renglon[0].ToString()),
                        IdDepartamento = Convert.ToInt32(renglon[1].ToString()),
                        IdClase = Convert.ToInt32(renglon[2].ToString()),
                        Nombre = renglon[3].ToString(),
                    };

                    familias.Add(f);
                }

                if (familias.Count > 0)
                {
                    return familias;
                }
                else
                {
                    return null;
                }
            }
            catch 
            {
                return null;
            }
        }

        //se realiza el insert a la base de datos del producto
        public bool AltaProducto(Producto producto)
        {
            try
            {
                Conectar().Open();

                string query = "exec SP_AltaProducto @SKU, @Articulo, @Marca, " +
                               "@Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad";

                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@SKU", producto.Sku);
                comando.Parameters.AddWithValue("@Articulo", producto.Articulo);
                comando.Parameters.AddWithValue("@Marca", producto.Marca);
                comando.Parameters.AddWithValue("@Modelo", producto.Modelo);
                comando.Parameters.AddWithValue("@Departamento", producto.Departamento);
                comando.Parameters.AddWithValue("@Clase", producto.Clase);
                comando.Parameters.AddWithValue("@Familia", producto.Familia);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar el Alta del producto.\n\nError: " + ex.Message);
                return false;
            }
        }

        //se realiza la actualizacion de un producto en especifico
        public bool ActualizarProducto(Producto producto)
        {
            try
            {
                int Descontinuado;
                if (producto.Descontinuado)
                {
                    Descontinuado = 1;
                }
                else
                {
                    Descontinuado = 0;
                }
                Conectar().Open();

                string query = "exec SP_ActualizarProducto @SKU, @Articulo, @Marca, " +
                               "@Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad, @Descontinuado";

                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@SKU", producto.Sku);
                comando.Parameters.AddWithValue("@Articulo", producto.Articulo);
                comando.Parameters.AddWithValue("@Marca", producto.Marca);
                comando.Parameters.AddWithValue("@Modelo", producto.Modelo);
                comando.Parameters.AddWithValue("@Departamento", producto.Departamento);
                comando.Parameters.AddWithValue("@Clase", producto.Clase);
                comando.Parameters.AddWithValue("@Familia", producto.Familia);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                comando.Parameters.AddWithValue("@Descontinuado", Descontinuado);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar el Actualización del producto.\n\nError: " + ex.Message);
                return false;
            }
        }

        //se realiza el delete de un producto especifico
        public bool BajaProducto(int sku)
        {
            try
            {
                Conectar().Open();

                string query = "exec SP_ELIMINARPRODUCTO @SKU";

                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@SKU", sku);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar el Baja del producto.\n\nError: " + ex.Message);
                return false;
            }
        }

        public DataTable ObtenerListaProductos()
        {
            try
            {
                Conectar().Open();
                SqlCommand cmd = new SqlCommand("exec SP_ConsultaListaProductos", Conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                return tabla;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: \n\n"+ exc.Message);
                return null;
            }
        }
    }
}

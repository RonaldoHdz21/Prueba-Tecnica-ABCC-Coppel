using Prueba_Tecnica_ABCC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba_Tecnica_ABCC
{
    public partial class Form1 : Form
    {
        ConsultasBD consultasBD;
        bool ExisteSKU;
        public Form1()
        {
            consultasBD = new ConsultasBD();
            InitializeComponent();
        }
        private void tbSku_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//valida si lo tecleado es un numero
                {
                    e.Handled = true;
                }
                if (tbSku.Text.Length > 0)//valida si no está vacio
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))//valida si se presiona Enter
                    {
                        if(int.TryParse(tbSku.Text, out int SkuInt))//valida si la cadena completa es un número
                        {
                            tbSku.Enabled = false;
                            string skuIngresado = tbSku.Text;

                            Producto producto = consultasBD.getProducto(skuIngresado);

                            if (producto.Sku == 0)
                            {
                                ExisteSKU = false;
                                cargarDepartamentos();
                                habilitarControles();
                                btnOk.Text = "Alta";
                                chbDescontinuado.Enabled = false;
                            }
                            else
                            {
                                ExisteSKU = true;
                                habilitarControles();
                                cbClase.Enabled = true;
                                cbFamilia.Enabled = true;


                                cargarDepartamentos();
                                cargarClases(producto.Departamento);
                                cargarFamilias(producto.Departamento, producto.Clase);

                                lbFechaAlta.Visible = true;
                                lbFechaBaja.Visible = true;
                                dtpFechaBaja.Visible = true;
                                dtpFechaAlta.Visible = true;

                                mostrarInformacionProducto(producto);
                                btnOk.Text = "Actualizar";
                                btnEliminar.Visible = true;
                                btnEliminar.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un SKU numérico.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n"+ex.Message);
            }
            
        }

        //Carga el combobox de clases al seleccionar un departamento
        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClase.Items.Clear();
            cbClase.Enabled = true;

            cbFamilia.Items.Clear();

            cbClase.Text = "";
            cbFamilia.Text = "";
            cargarClases(cbDepartamento.Text);
        }

        //Carga el combobox de Familias al seleccionar una clase
        private void cbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFamilia.Items.Clear();
            cbFamilia.Text = "";
            cbFamilia.Enabled = true;
            cargarFamilias(cbDepartamento.Text, cbClase.Text);
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Baja de producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Confirmacion de baja
                DialogResult BtnPres = MessageBox.Show("¿Seguro que deseas de dar baja este producto?", "Coppel", MessageBoxButtons.OKCancel);
                if (BtnPres == DialogResult.OK)
                {
                    int sku = Convert.ToInt32(tbSku.Text);

                    if (consultasBD.BajaProducto(sku))
                    {
                        MessageBox.Show("Baja realizada con éxito.");
                        reiniciarControles();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n"+ex.Message);
            }
        }

        //Alta o Actualización de producto
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = crearProducto();

                if (producto.Sku > 0 && producto.Sku != null)
                {
                    if (ExisteSKU)
                    {
                        if (consultasBD.ActualizarProducto(producto))
                        {
                            MessageBox.Show("Actualización realizada con éxito.");
                            reiniciarControles();
                        }
                    }
                    else
                    {
                        if (consultasBD.AltaProducto(producto))
                        {
                            MessageBox.Show("Alta realizada con éxito.");
                            reiniciarControles();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex.Message);
            }
            
        }

        

        void mostrarInformacionProducto(Producto producto)
        {
            //Rellena los campos con la información obtenida
            chbDescontinuado.Checked = producto.Descontinuado;
            tbArticulo.Text = producto.Articulo;
            tbMarca.Text = producto.Marca;
            tbModelo.Text = producto.Modelo;
            cbDepartamento.SelectedItem = producto.Departamento;
            cbClase.SelectedItem = producto.Clase;
            cbFamilia.SelectedItem = producto.Familia;
            tbStock.Text = producto.Stock.ToString();
            tbCantidad.Text = producto.Cantidad.ToString();
            dtpFechaAlta.Value = producto.FechaAlta;
            dtpFechaBaja.Value = producto.FechaBaja;
            chbDescontinuado.Checked = producto.Descontinuado;
        }

        void habilitarControles()
        {
            //Habilita los controles
            chbDescontinuado.Enabled = true;
            tbArticulo.Enabled = true;
            tbMarca.Enabled = true;
            tbModelo.Enabled = true;
            cbDepartamento.Enabled = true;
            tbStock.Enabled = true;
            tbCantidad.Enabled = true;
            btnOk.Enabled = true;
        }

        void cargarDepartamentos()
        {
            cbDepartamento.Items.Clear();
            List<Departamento> departamentos = consultasBD.getDepartamentos();

            foreach(Departamento d in departamentos)
            {
                cbDepartamento.Items.Add(d.Nombre);
            }
        }

        void cargarClases(string Departamento)
        {
            List<Clase> clases = consultasBD.getClases(Departamento);

            foreach(Clase clase in clases)
            {
                cbClase.Items.Add(clase.Nombre);
            }
        }

        void cargarFamilias(string Departamento, string Clase)
        {
            List<Familia> familias = consultasBD.getFamilias(Departamento, Clase);

            foreach (Familia familia in familias)
            {
                cbFamilia.Items.Add(familia.Nombre);
            }
        }

        void reiniciarControles()
        {
            ExisteSKU = false;

            tbSku.Text = "";
            tbSku.Enabled = true;

            tbArticulo.Text = "";
            tbArticulo.Enabled = false;

            tbMarca.Text = "";
            tbMarca.Enabled = false;

            tbModelo.Text = "";
            tbModelo.Enabled = false;

            cbDepartamento.Text = "";
            cbDepartamento.Enabled = false;
            cbDepartamento.Items.Clear();

            cbClase.Text = "";
            cbClase.Enabled = false;
            cbClase.Items.Clear();

            cbFamilia.Text = "";
            cbFamilia.Enabled = false;
            cbFamilia.Items.Clear();

            tbStock.Text = "";
            tbStock.Enabled = false;

            tbCantidad.Text = "";
            tbCantidad.Enabled = false;

            dtpFechaAlta.Value = DateTime.Now;
            dtpFechaAlta.Enabled = false;

            dtpFechaAlta.Value = DateTime.Now;
            dtpFechaBaja.Enabled = false;

            lbFechaAlta.Visible = false;
            lbFechaBaja.Visible = false;
            dtpFechaBaja.Visible = false;
            dtpFechaAlta.Visible = false;

            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;

            btnOk.Enabled = false;

            chbDescontinuado.Checked = false;
            chbDescontinuado.Enabled = false;
        }

        Producto crearProducto()
        {
            Producto producto = new Producto();
            if (int.TryParse(tbSku.Text, out int SkuInt) == false)
            {
                MessageBox.Show("Ingresa un valor numerico en el campo SKU.");
            }
            else if (int.TryParse(tbStock.Text, out int StockInt) == false)
            {
                MessageBox.Show("Ingresa un valor numerico en el campo Stock.");
            }
            else if (int.TryParse(tbCantidad.Text, out int CantidadInt) == false)
            {
                MessageBox.Show("Ingresa un valor numerico en el campo Cantidad.");
            }
            else if (Convert.ToInt32(tbStock.Text) < Convert.ToInt32(tbCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede ser mayor al Stock.");
            }
            else
            {
                producto.Sku = Convert.ToInt32(tbSku.Text);
                producto.Articulo = tbArticulo.Text;
                producto.Marca = tbMarca.Text;
                producto.Modelo = tbModelo.Text;
                producto.Departamento = cbDepartamento.Text;
                producto.Clase = cbClase.Text;
                producto.Familia = cbFamilia.Text;
                producto.Stock = Convert.ToInt32(tbStock.Text);
                producto.Cantidad = Convert.ToInt32(tbCantidad.Text);
                producto.Descontinuado = chbDescontinuado.Checked;
            }

            return producto;
        }
    }
}

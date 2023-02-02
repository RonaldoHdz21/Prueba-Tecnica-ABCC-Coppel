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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
            cargarProductos();
        }

        void cargarProductos()
        {
            ConsultasBD consultasBD = new ConsultasBD();

            DataTable tabla = consultasBD.ObtenerListaProductos();
            lvProductos.View = View.Details;
            lvProductos.FullRowSelect = true;

            foreach (DataRow renglon in tabla.Rows)
            {
                string[] arr = new string[12];
                ListViewItem itm = new ListViewItem();

                for (int ncolumna = 0; ncolumna < 12; ncolumna++)
                {
                    arr[ncolumna] = renglon[ncolumna].ToString();
                    itm = new ListViewItem(arr);
                }
                lvProductos.Items.Add(itm);
            }
        }

    }
}

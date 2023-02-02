
namespace Prueba_Tecnica_ABCC
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvProductos = new System.Windows.Forms.ListView();
            this.SKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Articulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Familia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descontinuado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaAlta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaBaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SKU,
            this.Articulo,
            this.Marca,
            this.Modelo,
            this.Departamento,
            this.Clase,
            this.Familia,
            this.Stock,
            this.Cantidad,
            this.Descontinuado,
            this.FechaAlta,
            this.FechaBaja});
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(12, 12);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(776, 426);
            this.lvProductos.TabIndex = 0;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // SKU
            // 
            this.SKU.Text = "SKU";
            // 
            // Articulo
            // 
            this.Articulo.Text = "Articulo";
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            // 
            // Departamento
            // 
            this.Departamento.Text = "Departamento";
            // 
            // Clase
            // 
            this.Clase.Text = "Clase";
            // 
            // Familia
            // 
            this.Familia.Text = "Familia";
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // Descontinuado
            // 
            this.Descontinuado.Text = "Descontinuado";
            // 
            // FechaAlta
            // 
            this.FechaAlta.Text = "FechaAlta";
            // 
            // FechaBaja
            // 
            this.FechaBaja.Text = "FechaBaja";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProductos);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader SKU;
        private System.Windows.Forms.ColumnHeader Articulo;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader Departamento;
        private System.Windows.Forms.ColumnHeader Clase;
        private System.Windows.Forms.ColumnHeader Familia;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Descontinuado;
        private System.Windows.Forms.ColumnHeader FechaAlta;
        private System.Windows.Forms.ColumnHeader FechaBaja;
    }
}
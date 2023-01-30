
namespace Prueba_Tecnica_ABCC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lbFechaBaja = new System.Windows.Forms.Label();
            this.lbFechaAlta = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.lbFamilia = new System.Windows.Forms.Label();
            this.cbClase = new System.Windows.Forms.ComboBox();
            this.lbClase = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.tbArticulo = new System.Windows.Forms.TextBox();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.chbDescontinuado = new System.Windows.Forms.CheckBox();
            this.tbSku = new System.Windows.Forms.TextBox();
            this.lbSku = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(263, 297);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaBaja.TabIndex = 47;
            this.dtpFechaBaja.Value = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            this.dtpFechaBaja.Visible = false;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(91, 297);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaAlta.TabIndex = 46;
            this.dtpFechaAlta.Value = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            this.dtpFechaAlta.Visible = false;
            // 
            // lbFechaBaja
            // 
            this.lbFechaBaja.AutoSize = true;
            this.lbFechaBaja.Enabled = false;
            this.lbFechaBaja.Location = new System.Drawing.Point(199, 303);
            this.lbFechaBaja.Name = "lbFechaBaja";
            this.lbFechaBaja.Size = new System.Drawing.Size(64, 13);
            this.lbFechaBaja.TabIndex = 45;
            this.lbFechaBaja.Text = "Fecha Baja:";
            this.lbFechaBaja.Visible = false;
            // 
            // lbFechaAlta
            // 
            this.lbFechaAlta.AutoSize = true;
            this.lbFechaAlta.Enabled = false;
            this.lbFechaAlta.Location = new System.Drawing.Point(9, 303);
            this.lbFechaAlta.Name = "lbFechaAlta";
            this.lbFechaAlta.Size = new System.Drawing.Size(61, 13);
            this.lbFechaAlta.TabIndex = 44;
            this.lbFechaAlta.Text = "Fecha Alta:";
            this.lbFechaAlta.Visible = false;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(199, 268);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 43;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Enabled = false;
            this.tbCantidad.Location = new System.Drawing.Point(263, 265);
            this.tbCantidad.MaxLength = 9;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(106, 20);
            this.tbCantidad.TabIndex = 42;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // tbStock
            // 
            this.tbStock.Enabled = false;
            this.tbStock.Location = new System.Drawing.Point(91, 265);
            this.tbStock.MaxLength = 9;
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(106, 20);
            this.tbStock.TabIndex = 41;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(9, 268);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(38, 13);
            this.lbStock.TabIndex = 40;
            this.lbStock.Text = "Stock:";
            // 
            // cbFamilia
            // 
            this.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamilia.Enabled = false;
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(91, 228);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(278, 21);
            this.cbFamilia.TabIndex = 39;
            // 
            // lbFamilia
            // 
            this.lbFamilia.AutoSize = true;
            this.lbFamilia.Location = new System.Drawing.Point(9, 231);
            this.lbFamilia.Name = "lbFamilia";
            this.lbFamilia.Size = new System.Drawing.Size(42, 13);
            this.lbFamilia.TabIndex = 38;
            this.lbFamilia.Text = "Familia:";
            // 
            // cbClase
            // 
            this.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClase.Enabled = false;
            this.cbClase.FormattingEnabled = true;
            this.cbClase.Location = new System.Drawing.Point(91, 192);
            this.cbClase.Name = "cbClase";
            this.cbClase.Size = new System.Drawing.Size(278, 21);
            this.cbClase.TabIndex = 37;
            this.cbClase.SelectedIndexChanged += new System.EventHandler(this.cbClase_SelectedIndexChanged);
            // 
            // lbClase
            // 
            this.lbClase.AutoSize = true;
            this.lbClase.Location = new System.Drawing.Point(9, 195);
            this.lbClase.Name = "lbClase";
            this.lbClase.Size = new System.Drawing.Size(36, 13);
            this.lbClase.TabIndex = 36;
            this.lbClase.Text = "Clase:";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Enabled = false;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(91, 156);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(278, 21);
            this.cbDepartamento.TabIndex = 35;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.lbDepartamento.Location = new System.Drawing.Point(9, 159);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lbDepartamento.TabIndex = 34;
            this.lbDepartamento.Text = "Departamento:";
            // 
            // tbModelo
            // 
            this.tbModelo.Enabled = false;
            this.tbModelo.Location = new System.Drawing.Point(91, 120);
            this.tbModelo.MaxLength = 20;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(278, 20);
            this.tbModelo.TabIndex = 33;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(9, 123);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(45, 13);
            this.lbModelo.TabIndex = 32;
            this.lbModelo.Text = "Modelo:";
            // 
            // tbMarca
            // 
            this.tbMarca.Enabled = false;
            this.tbMarca.Location = new System.Drawing.Point(91, 85);
            this.tbMarca.MaxLength = 15;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(278, 20);
            this.tbMarca.TabIndex = 31;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(9, 88);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 30;
            this.lbMarca.Text = "Marca:";
            // 
            // tbArticulo
            // 
            this.tbArticulo.Enabled = false;
            this.tbArticulo.Location = new System.Drawing.Point(91, 50);
            this.tbArticulo.MaxLength = 15;
            this.tbArticulo.Name = "tbArticulo";
            this.tbArticulo.Size = new System.Drawing.Size(278, 20);
            this.tbArticulo.TabIndex = 29;
            // 
            // lbArticulo
            // 
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Location = new System.Drawing.Point(9, 53);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(45, 13);
            this.lbArticulo.TabIndex = 28;
            this.lbArticulo.Text = "Articulo:";
            // 
            // chbDescontinuado
            // 
            this.chbDescontinuado.AutoSize = true;
            this.chbDescontinuado.Enabled = false;
            this.chbDescontinuado.Location = new System.Drawing.Point(271, 14);
            this.chbDescontinuado.Name = "chbDescontinuado";
            this.chbDescontinuado.Size = new System.Drawing.Size(98, 17);
            this.chbDescontinuado.TabIndex = 27;
            this.chbDescontinuado.Text = "Descontinuado";
            this.chbDescontinuado.UseVisualStyleBackColor = true;
            // 
            // tbSku
            // 
            this.tbSku.Location = new System.Drawing.Point(91, 12);
            this.tbSku.MaxLength = 6;
            this.tbSku.Name = "tbSku";
            this.tbSku.Size = new System.Drawing.Size(141, 20);
            this.tbSku.TabIndex = 26;
            this.tbSku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSku_KeyPress);
            // 
            // lbSku
            // 
            this.lbSku.AutoSize = true;
            this.lbSku.Location = new System.Drawing.Point(9, 15);
            this.lbSku.Name = "lbSku";
            this.lbSku.Size = new System.Drawing.Size(32, 13);
            this.lbSku.TabIndex = 25;
            this.lbSku.Text = "SKU:";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(294, 339);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 48;
            this.btnOk.Text = "<Boton>";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(213, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 374);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lbFechaBaja);
            this.Controls.Add(this.lbFechaAlta);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.cbFamilia);
            this.Controls.Add(this.lbFamilia);
            this.Controls.Add(this.cbClase);
            this.Controls.Add(this.lbClase);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.tbArticulo);
            this.Controls.Add(this.lbArticulo);
            this.Controls.Add(this.chbDescontinuado);
            this.Controls.Add(this.tbSku);
            this.Controls.Add(this.lbSku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lbFechaBaja;
        private System.Windows.Forms.Label lbFechaAlta;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.Label lbFamilia;
        private System.Windows.Forms.ComboBox cbClase;
        private System.Windows.Forms.Label lbClase;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox tbArticulo;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.CheckBox chbDescontinuado;
        private System.Windows.Forms.TextBox tbSku;
        private System.Windows.Forms.Label lbSku;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEliminar;
    }
}


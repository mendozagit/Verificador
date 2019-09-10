namespace Verificador
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
            this.TxtProductoId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TxtArticulo = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtProductoId
            // 
            this.TxtProductoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProductoId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProductoId.Location = new System.Drawing.Point(12, 12);
            this.TxtProductoId.Name = "TxtProductoId";
            this.TxtProductoId.Size = new System.Drawing.Size(261, 29);
            this.TxtProductoId.TabIndex = 0;
            this.TxtProductoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductoId_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 199);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDescripcion.Location = new System.Drawing.Point(279, 12);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(558, 127);
            this.TxtDescripcion.TabIndex = 2;
            this.TxtDescripcion.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.ForeColor = System.Drawing.Color.DimGray;
            this.textBox4.Location = new System.Drawing.Point(279, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 29);
            this.textBox4.TabIndex = 4;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "PRECIO";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.ForeColor = System.Drawing.Color.DimGray;
            this.textBox5.Location = new System.Drawing.Point(279, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 29);
            this.textBox5.TabIndex = 5;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "STOCK";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.ForeColor = System.Drawing.Color.DimGray;
            this.textBox6.Location = new System.Drawing.Point(279, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 29);
            this.textBox6.TabIndex = 6;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "ARTÍCULO";
            // 
            // TxtArticulo
            // 
            this.TxtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtArticulo.Enabled = false;
            this.TxtArticulo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtArticulo.Location = new System.Drawing.Point(452, 145);
            this.TxtArticulo.Name = "TxtArticulo";
            this.TxtArticulo.Size = new System.Drawing.Size(385, 29);
            this.TxtArticulo.TabIndex = 7;
            this.TxtArticulo.TabStop = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPrecio.Location = new System.Drawing.Point(452, 180);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(385, 29);
            this.TxtPrecio.TabIndex = 8;
            this.TxtPrecio.TabStop = false;
            // 
            // TxtStock
            // 
            this.TxtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStock.Enabled = false;
            this.TxtStock.ForeColor = System.Drawing.Color.DimGray;
            this.TxtStock.Location = new System.Drawing.Point(452, 215);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(385, 29);
            this.TxtStock.TabIndex = 9;
            this.TxtStock.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 258);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtArticulo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtProductoId);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERIFICADOR DE PRECIOS DYM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtProductoId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox TxtArticulo;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtStock;
    }
}


namespace Corralon_Loma_Blanca
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNproducto = new System.Windows.Forms.Button();
            this.LBLxP = new System.Windows.Forms.Label();
            this.DGVproducto = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // BTNproducto
            // 
            this.BTNproducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNproducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNproducto.FlatAppearance.BorderSize = 0;
            this.BTNproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNproducto.ForeColor = System.Drawing.Color.White;
            this.BTNproducto.Image = ((System.Drawing.Image)(resources.GetObject("BTNproducto.Image")));
            this.BTNproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNproducto.Location = new System.Drawing.Point(12, 399);
            this.BTNproducto.Name = "BTNproducto";
            this.BTNproducto.Size = new System.Drawing.Size(184, 39);
            this.BTNproducto.TabIndex = 2;
            this.BTNproducto.Text = "        Guardar";
            this.BTNproducto.UseVisualStyleBackColor = false;
            // 
            // LBLxP
            // 
            this.LBLxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLxP.AutoSize = true;
            this.LBLxP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLxP.ForeColor = System.Drawing.Color.Gray;
            this.LBLxP.Location = new System.Drawing.Point(770, 9);
            this.LBLxP.Name = "LBLxP";
            this.LBLxP.Size = new System.Drawing.Size(18, 18);
            this.LBLxP.TabIndex = 4;
            this.LBLxP.Text = "X";
            // 
            // DGVproducto
            // 
            this.DGVproducto.AllowUserToOrderColumns = true;
            this.DGVproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.Descripcion,
            this.Precio,
            this.Stock});
            this.DGVproducto.Location = new System.Drawing.Point(16, 73);
            this.DGVproducto.Name = "DGVproducto";
            this.DGVproducto.Size = new System.Drawing.Size(441, 150);
            this.DGVproducto.TabIndex = 5;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(62, 245);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(75, 23);
            this.BTNagregar.TabIndex = 6;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.DGVproducto);
            this.Controls.Add(this.LBLxP);
            this.Controls.Add(this.BTNproducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNproducto;
        private System.Windows.Forms.Label LBLxP;
        private System.Windows.Forms.DataGridView DGVproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button BTNagregar;
    }
}
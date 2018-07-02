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
            this.label1 = new System.Windows.Forms.Label();
            this.LBLxP = new System.Windows.Forms.Label();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.BTNActualizarProducto = new System.Windows.Forms.Button();
            this.BTNeliminarProducto = new System.Windows.Forms.Button();
            this.grillaDeProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDESC = new System.Windows.Forms.TextBox();
            this.TXTprecio = new System.Windows.Forms.TextBox();
            this.TXTstock = new System.Windows.Forms.TextBox();
            this.TXTid_prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeProductos)).BeginInit();
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
            // LBLxP
            // 
            this.LBLxP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLxP.AutoSize = true;
            this.LBLxP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLxP.ForeColor = System.Drawing.Color.Gray;
            this.LBLxP.Location = new System.Drawing.Point(500, 9);
            this.LBLxP.Name = "LBLxP";
            this.LBLxP.Size = new System.Drawing.Size(18, 18);
            this.LBLxP.TabIndex = 4;
            this.LBLxP.Text = "X";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(16, 113);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(113, 23);
            this.BTNagregar.TabIndex = 6;
            this.BTNagregar.Text = "Agregar Producto";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // BTNActualizarProducto
            // 
            this.BTNActualizarProducto.Location = new System.Drawing.Point(254, 113);
            this.BTNActualizarProducto.Name = "BTNActualizarProducto";
            this.BTNActualizarProducto.Size = new System.Drawing.Size(113, 23);
            this.BTNActualizarProducto.TabIndex = 21;
            this.BTNActualizarProducto.Text = "Actualizar Producto";
            this.BTNActualizarProducto.Click += new System.EventHandler(this.BTNActualizarProducto_Click);
            // 
            // BTNeliminarProducto
            // 
            this.BTNeliminarProducto.Location = new System.Drawing.Point(135, 113);
            this.BTNeliminarProducto.Name = "BTNeliminarProducto";
            this.BTNeliminarProducto.Size = new System.Drawing.Size(113, 23);
            this.BTNeliminarProducto.TabIndex = 20;
            this.BTNeliminarProducto.Text = "Eliminar Producto";
            this.BTNeliminarProducto.Click += new System.EventHandler(this.BTNeliminarProducto_Click);
            // 
            // grillaDeProductos
            // 
            this.grillaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeProductos.Location = new System.Drawing.Point(12, 188);
            this.grillaDeProductos.Name = "grillaDeProductos";
            this.grillaDeProductos.Size = new System.Drawing.Size(506, 150);
            this.grillaDeProductos.TabIndex = 9;
            this.grillaDeProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDeProductos_CellClick);
            this.grillaDeProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDeProductos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "STOCK";
            // 
            // txtDESC
            // 
            this.txtDESC.Location = new System.Drawing.Point(329, 41);
            this.txtDESC.Name = "txtDESC";
            this.txtDESC.Size = new System.Drawing.Size(125, 20);
            this.txtDESC.TabIndex = 16;
            // 
            // TXTprecio
            // 
            this.TXTprecio.Location = new System.Drawing.Point(102, 77);
            this.TXTprecio.Name = "TXTprecio";
            this.TXTprecio.Size = new System.Drawing.Size(125, 20);
            this.TXTprecio.TabIndex = 15;
            // 
            // TXTstock
            // 
            this.TXTstock.Location = new System.Drawing.Point(329, 74);
            this.TXTstock.Name = "TXTstock";
            this.TXTstock.Size = new System.Drawing.Size(125, 20);
            this.TXTstock.TabIndex = 14;
            // 
            // TXTid_prod
            // 
            this.TXTid_prod.Location = new System.Drawing.Point(102, 44);
            this.TXTid_prod.Name = "TXTid_prod";
            this.TXTid_prod.Size = new System.Drawing.Size(125, 20);
            this.TXTid_prod.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DESCRIPCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buscar (Descripcion)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDESC);
            this.Controls.Add(this.TXTprecio);
            this.Controls.Add(this.TXTstock);
            this.Controls.Add(this.TXTid_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grillaDeProductos);
            this.Controls.Add(this.BTNeliminarProducto);
            this.Controls.Add(this.BTNActualizarProducto);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.LBLxP);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Modificar Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLxP;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.Button BTNActualizarProducto;
        private System.Windows.Forms.Button BTNeliminarProducto;
        private System.Windows.Forms.DataGridView grillaDeProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDESC;
        private System.Windows.Forms.TextBox TXTprecio;
        private System.Windows.Forms.TextBox TXTstock;
        private System.Windows.Forms.TextBox TXTid_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
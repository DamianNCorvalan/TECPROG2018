namespace Corralon_Loma_Blanca
{
    partial class ABM_PRODUCTO
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTid_prod = new System.Windows.Forms.TextBox();
            this.TXTstock = new System.Windows.Forms.TextBox();
            this.TXTprecio = new System.Windows.Forms.TextBox();
            this.txtDESC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNguardarProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRECIO";
            // 
            // TXTid_prod
            // 
            this.TXTid_prod.Location = new System.Drawing.Point(102, 13);
            this.TXTid_prod.Name = "TXTid_prod";
            this.TXTid_prod.Size = new System.Drawing.Size(100, 20);
            this.TXTid_prod.TabIndex = 3;
            // 
            // TXTstock
            // 
            this.TXTstock.Location = new System.Drawing.Point(102, 103);
            this.TXTstock.Name = "TXTstock";
            this.TXTstock.Size = new System.Drawing.Size(100, 20);
            this.TXTstock.TabIndex = 4;
            // 
            // TXTprecio
            // 
            this.TXTprecio.Location = new System.Drawing.Point(102, 77);
            this.TXTprecio.Name = "TXTprecio";
            this.TXTprecio.Size = new System.Drawing.Size(100, 20);
            this.TXTprecio.TabIndex = 5;
            // 
            // txtDESC
            // 
            this.txtDESC.Location = new System.Drawing.Point(102, 46);
            this.txtDESC.Name = "txtDESC";
            this.txtDESC.Size = new System.Drawing.Size(100, 20);
            this.txtDESC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOCK";
            // 
            // BTNguardarProd
            // 
            this.BTNguardarProd.Location = new System.Drawing.Point(281, 99);
            this.BTNguardarProd.Name = "BTNguardarProd";
            this.BTNguardarProd.Size = new System.Drawing.Size(75, 23);
            this.BTNguardarProd.TabIndex = 8;
            this.BTNguardarProd.Text = "GUARDAR";
            this.BTNguardarProd.UseVisualStyleBackColor = true;
            //this.BTNguardarProd.Click += new System.EventHandler(this.BTNguardarProd_Click);
            // 
            // ABM_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNguardarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDESC);
            this.Controls.Add(this.TXTprecio);
            this.Controls.Add(this.TXTstock);
            this.Controls.Add(this.TXTid_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABM_PRODUCTO";
            this.Text = "ABM_PRODUCTO";
            this.Load += new System.EventHandler(this.ABM_PRODUCTO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTid_prod;
        private System.Windows.Forms.TextBox TXTstock;
        private System.Windows.Forms.TextBox TXTprecio;
        private System.Windows.Forms.TextBox txtDESC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNguardarProd;
    }
}
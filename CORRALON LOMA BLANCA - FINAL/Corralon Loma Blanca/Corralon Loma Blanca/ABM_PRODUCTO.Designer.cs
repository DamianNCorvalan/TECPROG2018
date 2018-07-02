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
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.TXTcontra = new System.Windows.Forms.TextBox();
            this.BTNacceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // TXTusuario
            // 
            this.TXTusuario.Location = new System.Drawing.Point(77, 31);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(189, 20);
            this.TXTusuario.TabIndex = 3;
            this.TXTusuario.TextChanged += new System.EventHandler(this.TXTusuario_TextChanged);
            // 
            // TXTcontra
            // 
            this.TXTcontra.Location = new System.Drawing.Point(77, 59);
            this.TXTcontra.Name = "TXTcontra";
            this.TXTcontra.PasswordChar = '*';
            this.TXTcontra.Size = new System.Drawing.Size(189, 20);
            this.TXTcontra.TabIndex = 6;
            // 
            // BTNacceder
            // 
            this.BTNacceder.Location = new System.Drawing.Point(191, 111);
            this.BTNacceder.Name = "BTNacceder";
            this.BTNacceder.Size = new System.Drawing.Size(75, 23);
            this.BTNacceder.TabIndex = 8;
            this.BTNacceder.Text = "Acceder";
            this.BTNacceder.UseVisualStyleBackColor = true;
            this.BTNacceder.Click += new System.EventHandler(this.BTNacceder_Click);
            // 
            // ABM_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(278, 147);
            this.Controls.Add(this.BTNacceder);
            this.Controls.Add(this.TXTcontra);
            this.Controls.Add(this.TXTusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABM_PRODUCTO";
            this.Text = "LOGIN USUARIO";
            this.Load += new System.EventHandler(this.ABM_PRODUCTO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTcontra;
        public System.Windows.Forms.TextBox TXTusuario;
        public System.Windows.Forms.Button BTNacceder;
    }
}
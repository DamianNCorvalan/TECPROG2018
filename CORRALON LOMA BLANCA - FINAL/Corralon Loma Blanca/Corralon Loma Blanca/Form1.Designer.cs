namespace Corralon_Loma_Blanca
{
    partial class FRMprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMprincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BTNempleados = new System.Windows.Forms.Button();
            this.BTNproveedores = new System.Windows.Forms.Button();
            this.BTNcientes = new System.Windows.Forms.Button();
            this.BTNventas = new System.Windows.Forms.Button();
            this.BTNproducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.BTNrestaurar = new System.Windows.Forms.PictureBox();
            this.BTNminimizar = new System.Windows.Forms.PictureBox();
            this.BTNmaximizar = new System.Windows.Forms.PictureBox();
            this.BTNcerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PanelHijos = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuVertical.Controls.Add(this.BTNempleados);
            this.MenuVertical.Controls.Add(this.BTNproveedores);
            this.MenuVertical.Controls.Add(this.BTNcientes);
            this.MenuVertical.Controls.Add(this.BTNventas);
            this.MenuVertical.Controls.Add(this.BTNproducto);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(181, 450);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // BTNempleados
            // 
            this.BTNempleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNempleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNempleados.FlatAppearance.BorderSize = 0;
            this.BTNempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNempleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNempleados.ForeColor = System.Drawing.Color.White;
            this.BTNempleados.Image = ((System.Drawing.Image)(resources.GetObject("BTNempleados.Image")));
            this.BTNempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNempleados.Location = new System.Drawing.Point(0, 248);
            this.BTNempleados.Name = "BTNempleados";
            this.BTNempleados.Size = new System.Drawing.Size(184, 39);
            this.BTNempleados.TabIndex = 2;
            this.BTNempleados.Text = "        Empleados";
            this.BTNempleados.UseVisualStyleBackColor = false;
            this.BTNempleados.Click += new System.EventHandler(this.BTNempleados_Click);
            // 
            // BTNproveedores
            // 
            this.BTNproveedores.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNproveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNproveedores.FlatAppearance.BorderSize = 0;
            this.BTNproveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNproveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNproveedores.ForeColor = System.Drawing.Color.White;
            this.BTNproveedores.Image = ((System.Drawing.Image)(resources.GetObject("BTNproveedores.Image")));
            this.BTNproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNproveedores.Location = new System.Drawing.Point(0, 203);
            this.BTNproveedores.Name = "BTNproveedores";
            this.BTNproveedores.Size = new System.Drawing.Size(184, 39);
            this.BTNproveedores.TabIndex = 4;
            this.BTNproveedores.Text = "        Proveedores";
            this.BTNproveedores.UseVisualStyleBackColor = false;
            this.BTNproveedores.Click += new System.EventHandler(this.BTNproveedores_Click);
            // 
            // BTNcientes
            // 
            this.BTNcientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNcientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNcientes.FlatAppearance.BorderSize = 0;
            this.BTNcientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNcientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcientes.ForeColor = System.Drawing.Color.White;
            this.BTNcientes.Image = ((System.Drawing.Image)(resources.GetObject("BTNcientes.Image")));
            this.BTNcientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcientes.Location = new System.Drawing.Point(0, 158);
            this.BTNcientes.Name = "BTNcientes";
            this.BTNcientes.Size = new System.Drawing.Size(184, 39);
            this.BTNcientes.TabIndex = 3;
            this.BTNcientes.Text = "        Clientes";
            this.BTNcientes.UseVisualStyleBackColor = false;
            this.BTNcientes.Click += new System.EventHandler(this.BTNclientes_Click);
            // 
            // BTNventas
            // 
            this.BTNventas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNventas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNventas.FlatAppearance.BorderSize = 0;
            this.BTNventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNventas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNventas.ForeColor = System.Drawing.Color.White;
            this.BTNventas.Image = ((System.Drawing.Image)(resources.GetObject("BTNventas.Image")));
            this.BTNventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNventas.Location = new System.Drawing.Point(0, 113);
            this.BTNventas.Name = "BTNventas";
            this.BTNventas.Size = new System.Drawing.Size(184, 39);
            this.BTNventas.TabIndex = 2;
            this.BTNventas.Text = "        Ventas";
            this.BTNventas.UseVisualStyleBackColor = false;
            this.BTNventas.Click += new System.EventHandler(this.BTNventas_Click);
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
            this.BTNproducto.Location = new System.Drawing.Point(0, 68);
            this.BTNproducto.Name = "BTNproducto";
            this.BTNproducto.Size = new System.Drawing.Size(184, 39);
            this.BTNproducto.TabIndex = 1;
            this.BTNproducto.Text = "        Producto";
            this.BTNproducto.UseVisualStyleBackColor = false;
            this.BTNproducto.Click += new System.EventHandler(this.BTNproducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BarraSuperior.Controls.Add(this.BTNrestaurar);
            this.BarraSuperior.Controls.Add(this.BTNminimizar);
            this.BarraSuperior.Controls.Add(this.BTNmaximizar);
            this.BarraSuperior.Controls.Add(this.BTNcerrar);
            this.BarraSuperior.Controls.Add(this.btnMenu);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(181, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(619, 50);
            this.BarraSuperior.TabIndex = 1;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // BTNrestaurar
            // 
            this.BTNrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BTNrestaurar.Image")));
            this.BTNrestaurar.Location = new System.Drawing.Point(561, 3);
            this.BTNrestaurar.Name = "BTNrestaurar";
            this.BTNrestaurar.Size = new System.Drawing.Size(20, 20);
            this.BTNrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNrestaurar.TabIndex = 4;
            this.BTNrestaurar.TabStop = false;
            this.BTNrestaurar.Visible = false;
            this.BTNrestaurar.Click += new System.EventHandler(this.BTNrestaurar_Click);
            // 
            // BTNminimizar
            // 
            this.BTNminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNminimizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNminimizar.Image")));
            this.BTNminimizar.Location = new System.Drawing.Point(535, 3);
            this.BTNminimizar.Name = "BTNminimizar";
            this.BTNminimizar.Size = new System.Drawing.Size(20, 20);
            this.BTNminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNminimizar.TabIndex = 3;
            this.BTNminimizar.TabStop = false;
            this.BTNminimizar.Click += new System.EventHandler(this.BTNminimizar_Click);
            // 
            // BTNmaximizar
            // 
            this.BTNmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNmaximizar.Image")));
            this.BTNmaximizar.Location = new System.Drawing.Point(561, 3);
            this.BTNmaximizar.Name = "BTNmaximizar";
            this.BTNmaximizar.Size = new System.Drawing.Size(20, 20);
            this.BTNmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNmaximizar.TabIndex = 2;
            this.BTNmaximizar.TabStop = false;
            this.BTNmaximizar.Click += new System.EventHandler(this.BTNmaximizar_Click);
            // 
            // BTNcerrar
            // 
            this.BTNcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTNcerrar.Image")));
            this.BTNcerrar.Location = new System.Drawing.Point(587, 3);
            this.BTNcerrar.Name = "BTNcerrar";
            this.BTNcerrar.Size = new System.Drawing.Size(20, 20);
            this.BTNcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNcerrar.TabIndex = 1;
            this.BTNcerrar.TabStop = false;
            this.BTNcerrar.Click += new System.EventHandler(this.BTNcerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(6, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PanelHijos
            // 
            this.PanelHijos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHijos.Location = new System.Drawing.Point(181, 50);
            this.PanelHijos.Name = "PanelHijos";
            this.PanelHijos.Size = new System.Drawing.Size(619, 400);
            this.PanelHijos.TabIndex = 2;
            // 
            // FRMprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelHijos);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMprincipal";
            this.Text = "Sistema Loma Blanca";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);



        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel PanelHijos;
        private System.Windows.Forms.PictureBox BTNrestaurar;
        private System.Windows.Forms.PictureBox BTNminimizar;
        private System.Windows.Forms.PictureBox BTNmaximizar;
        private System.Windows.Forms.PictureBox BTNcerrar;
        private System.Windows.Forms.Button BTNproducto;
        private System.Windows.Forms.Button BTNempleados;
        private System.Windows.Forms.Button BTNproveedores;
        private System.Windows.Forms.Button BTNcientes;
        private System.Windows.Forms.Button BTNventas;
    }
}


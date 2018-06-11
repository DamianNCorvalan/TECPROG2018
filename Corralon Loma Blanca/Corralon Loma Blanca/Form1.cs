using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Corralon_Loma_Blanca
{
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);




        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 181)
            { MenuVertical.Width = 50; }
            else { MenuVertical.Width = 181; }
            // Despliegue de menu
            
            
        }

        private void BTNcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNrestaurar.Visible = true;
            BTNmaximizar.Visible = false ;
        }

        private void BTNrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNrestaurar.Visible = false ;
            BTNmaximizar.Visible = true ;

        }

        private void BTNminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
            //Mueve la ventana a travez del panel de menu
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.PanelHijos.Controls.Count > 0)
                this.PanelHijos.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelHijos.Controls.Add(fh);
            this.PanelHijos.Tag = fh;
            fh.Show();

            //FUNCION PARA ABRIR UN FORMULARIO EN EL PANEL
        }

        private void BTNproducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Ventas());
        }

        private void BTNclientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }

        private void BTNproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Proveedores());
        }

        private void BTNempleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Empleados());
        }
    }
}

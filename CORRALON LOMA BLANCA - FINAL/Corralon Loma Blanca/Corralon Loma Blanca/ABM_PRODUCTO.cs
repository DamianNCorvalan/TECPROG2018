using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corralon_Loma_Blanca
{
    public partial class ABM_PRODUCTO : Form
    {
        Conexion c = new Conexion();
        public ABM_PRODUCTO()
        {
            InitializeComponent();
            
        }

        private void ABM_PRODUCTO_Load(object sender, EventArgs e)
        {

        }


        

        private void BTNacceder_Click(object sender, EventArgs e)
        {
            if (TXTusuario.Text == "Empleado1" && TXTcontra.Text == "emple1")
            {
                Form ABM = new ABM_PRODUCTO();
                ABM.Visible = false;
                Visible = false;

                Form Prod = new Productos();
                Prod.Enabled = true;
                Enabled = true;

                MessageBox.Show("Bienvenido Juan Manuel Garcia");
                Form formulario = new FRMprincipal();
                formulario.Show();

                
                

            }
            
            else
                if (TXTusuario.Text == "Gerente1" && TXTcontra.Text == "geren1")
                {
                    Form ABM = new Empleados();
                    ABM.Enabled = true;
                    Enabled = true;

                    Form PRINC = new FRMprincipal();
                    PRINC.Enabled = true;
                    Enabled = true;
                    MessageBox.Show("Bienvenido Santiago Gonzalez");

                    Form formulario = new FRMprincipal();
                    formulario.Show();

                    
            }
                else
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                    TXTusuario.Text = "";
                    TXTcontra.Text = "";



        }

        private void TXTusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

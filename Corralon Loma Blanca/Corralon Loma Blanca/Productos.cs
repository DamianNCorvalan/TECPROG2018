using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Incorporo el espacio de nombre System.Data.SqlClient
using System.Data.SqlClient;


namespace Corralon_Loma_Blanca
{
    
    public partial class Productos : Form
    {
       
    public Productos()
        {
            InitializeComponent();
        }

        private void LBLxV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LBLxP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargaprod(DGVproducto);
        }

        private void BTNagregar_Click(object sender, EventArgs e)
        {
            ABM_PRODUCTO i = new ABM_PRODUCTO();
            i.Show();
        }
    }
}

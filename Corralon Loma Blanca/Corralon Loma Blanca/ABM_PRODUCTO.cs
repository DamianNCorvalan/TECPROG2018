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

        //private void BTNguardarProd_Click(object sender, EventArgs e)
       // {
        //    if (c.productoAgregado(Convert.ToInt32(TXTid_prod.Text))==0)
        //    {                
        //        MessageBox.Show(c.Insertar(Convert.ToInt32(TXTid_prod.Text), txtDESC.Text, Convert.ToInt32(TXTprecio.Text), Convert.ToInt32(TXTstock.Text)));
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se ah podido registrar el Producto, Debido que el mismo ya existe");
          //  }
        //}
    }
}

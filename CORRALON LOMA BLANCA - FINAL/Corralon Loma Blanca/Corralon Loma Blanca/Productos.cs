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
            Form Prod = new Productos();
            Prod.Enabled = true;
            Enabled = true;
            // InitializeComponent();
            Conexion c = new Conexion();
           
            c.cargaprod(this.grillaDeProductos);
        }

        private void grillaDeProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grillaDeProductos.Rows[e.RowIndex];
            TXTid_prod.Text = Convert.ToString(fila.Cells[0].Value);
            txtDESC.Text = Convert.ToString(fila.Cells[1].Value);
            TXTprecio.Text = Convert.ToString(fila.Cells[2].Value);
            TXTstock.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void BTNagregar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            TXTid_prod.Text = grillaDeProductos.Rows.Count.ToString();
            if (c.Insertar(TXTid_prod.Text, txtDESC.Text, TXTprecio.Text, TXTstock.Text).ToLower()== "se agregaron los datos correctamente")
            {
                MessageBox.Show("Datos Guardados Correctamente");
                grillaDeProductos.DataSource = c.cargarProducto();
            }
            else MessageBox.Show("No se han podido insertar los datos");
        }

        private void grillaDeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grillaDeProductos.Rows[e.RowIndex];
            TXTid_prod.Text = Convert.ToString(fila.Cells[0].Value);
            txtDESC.Text = Convert.ToString(fila.Cells[1].Value);
            TXTprecio.Text = Convert.ToString(fila.Cells[2].Value);
            TXTstock.Text = Convert.ToString(fila.Cells[3].Value);
        }

        
        private void BTNeliminarProducto_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            TXTid_prod.Text = grillaDeProductos.Rows.Count.ToString();
            if (c.Eliminar(TXTid_prod.Text).ToLower() == "eliminado")
            {
                MessageBox.Show("Datos Eliminados con Exito");
                grillaDeProductos.DataSource = c.cargarProducto();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void BTNActualizarProducto_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            TXTid_prod.Text = grillaDeProductos.Rows.Count.ToString();
            if (c.ActualizarProducto(TXTid_prod.Text, txtDESC.Text, TXTprecio.Text, TXTstock.Text).ToLower() == "sss")
            {
                MessageBox.Show("Datos actualizados");
                grillaDeProductos.DataSource = c.cargarProducto();
            }
            else MessageBox.Show("No se ha podido actualizar");
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            TXTid_prod.Text = grillaDeProductos.Rows.Count.ToString();
            if (c.BuscarPRODUCTO(textBox1.Text).ToLower() == "encontrado")
            { 
                grillaDeProductos.DataSource = c.BuscarPRODUCTO(textBox1.Text);
            }


            else grillaDeProductos.DataSource = c.cargarProducto();
        }
    }
}

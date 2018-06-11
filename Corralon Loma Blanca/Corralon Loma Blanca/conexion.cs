using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Corralon_Loma_Blanca
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da; // SIRVE PARA LLENAR EL DATAGRID
        DataTable dt;      // SIRVE PARA LLENAR EL DATAGRID


        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=DAMIAN-LEGACY\SQLEXPRESS;Initial Catalog=LOMAAAAAAAAAAAA;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de Datos: " + ex.ToString());
            }
        }
        public string Insertar(int ID_PRODUCTO, string DESCRIPCION, int PRECIO, int STOCK)
        {
            string salida = "Se agregaron los Datos Correctamente";
            try
            {
                cmd = new SqlCommand("Inser into PROVEDORES(ID_PRODUCTO,DESCRIPCION,PRECIO,STOCK)values()" + ID_PRODUCTO + ",'" + DESCRIPCION + "'," + PRECIO + "," + STOCK + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo conecta a la Base de Datos; " + ex.ToString();

            }
            return salida;
        }
        /////////////////////////////////////////////////////
        // VALIDACION PARA VER SI HAY ID REPETIDO

        public int productoAgregado(int ID_PRODUCTO)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from PRODUCTOS where ID_PRODUCTO=" + ID_PRODUCTO + ")", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Consulta: " + ex.ToString());

            }
            return contador;

        }

        public void cargaprod(DataGridView DGV)
        {
            try
            {
                da = new SqlDataAdapter("Select * form PRODUCTOS", cn);
                dt = new DataTable();
                da.Fill(dt);
                DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }
    }
}

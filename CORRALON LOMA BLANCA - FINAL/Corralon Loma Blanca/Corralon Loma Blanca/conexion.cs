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
                cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Loma Blanca Final;Data Source=.\\SQLEXPRESS"); //DAMIAN-LEGACY\\SQLEXPRESS
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de Datos: " + ex.ToString());
            }
        }
        public string Insertar(string ID_PRODUCTO, string NOMBRE_PRODUCTO, string PRECIO, string STOCK)
        {
            string salida = "Se agregaron los Datos Correctamente";
            try
            {
                cmd = new SqlCommand("INSERT INTO PRODUCTOS values('" + ID_PRODUCTO + "','" + NOMBRE_PRODUCTO + "','" + PRECIO + "','" + STOCK + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo conectar a la Base de Datos; " + ex.ToString();

            }
            //cn.Close();
            return salida;
        }


        public string Eliminar (string ID)
        {
            string salida = "eliminado";
            try
            {
                cmd = new SqlCommand("DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = '" + ID + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo ELIMINAR EL REGISTRO; " + ex.ToString();

            }
            return salida;
        }


        public string ActualizarProducto(string ID_PRODUCTO, string NOMBRE_PRODUCTO, string PRECIO, string STOCK)
        {
            string salida = "sss";
            try
            {
                cmd = new SqlCommand("USE [Loma Blanca Final] update PRODUCTOS set ID_PRODUCTO='" + ID_PRODUCTO + "',NOMBRE_PRODUCTO='" + NOMBRE_PRODUCTO + "',PRECIO='" + PRECIO + "',STOCK='" + STOCK + "' where ID_PRODUCTO='" + ID_PRODUCTO + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar los datos; " + ex.ToString();

            }
            //cn.Close();
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

        public DataTable cargarProducto()
        {
            da = new SqlDataAdapter("Select * from PRODUCTOS;", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void cargaprod(DataGridView DGV)
        {
            try
            {
                da = new SqlDataAdapter("Select * from PRODUCTOS;", cn);
                dt = new DataTable();
                da.Fill(dt);
                DGV.DataSource = dt;
                //DGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        

        
        
        }

        public string BuscarPRODUCTO(string PRODUCTO)
        {
            string salida = "encontrado";
            try
            {
                cmd = new SqlCommand("select * from PRODUCTOS where '" + PRODUCTO + "%' LIKE '%'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se encontro producto; " + ex.ToString();

            }
            return salida;
            //conexion.Open();
            //SqlCommand cmd = new SqlCommand(string.Format("select * from Negocio where Nombre like '%{0}%'", nombre), conexion);
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //ds = new DataSet();
            //ad.Fill(ds, "tabla");
            //conexion.Close();
            //return ds.Tables["tabla"];
        }


        private static string acceso;

        public static string Ac
        {
            get { return acceso; }
            set { acceso = value; }
        }
    }
}

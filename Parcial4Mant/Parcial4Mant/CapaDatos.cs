using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Parcial4Mant
{
    class CapaDatos
    {
        SqlCommand cmd;
        SqlConnection conexion;
        SqlDataReader dr;

        public  CapaDatos()
        {
            try {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("Conexion establecida");

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("La coenxion no se realizo"+ex.ToString());
            }
        }

    }
}

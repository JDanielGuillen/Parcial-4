using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;   


namespace CapaDatos
{
    public class Conexion
    {
        
        
        SqlCommand cmd;
        SqlConnection conexion;
        SqlDataReader dr;

        public  Conexion()
        {
            try {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
                conexion.Open();
               

            
            }
            catch (Exception ex)
            {
            
            }
        
        }

    }
}

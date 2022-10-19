using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.de.personal
{
    class Conexion
    {

        public  SqlConnection Conectar()
        {
           SqlConnection cn = new SqlConnection("SERVER=DESKTOP-79AUKF6;DATABASE=facturas;Integrated security=true");
                   
            
            
                return cn;
          
        } 


    }
}

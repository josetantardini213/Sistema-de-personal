using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.de.personal
{
    class Usuario
    {
        private int id;
        private String user;
        private String password;

        public String getUser()
        {
            return this.user;
        }

        public void setUser(String usuario)
        {
            this.user = usuario;
        }

        public String getPass()
        {
            return this.password;
        }

        public void setPass(String password)
        {
            this.password = password;
        }


     

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Sistema.de.personal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Usuario users = new Usuario();
        IService serv = new Service();
        
        private void button1_Click(object sender, EventArgs e)
        {
            String user;
            String pass;
            Boolean login;
    
            
            user = txtuser.Text;
            pass = txtpass.Text;

            if (user.Length > 0 && pass.Length > 0) {
                
                users.setUser(user);
                users.setPass(pass);

               login = serv.Verificar(users);

                if(login == true)
                {
                    this.Hide();

                    Form2 frm = new Form2();

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña erronos");
                }
                
            }
            else
            {
                MessageBox.Show("Faltan campos a completar");
            }





            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

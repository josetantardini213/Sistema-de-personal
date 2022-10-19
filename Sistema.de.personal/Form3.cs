using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.de.personal
{
    public partial class Form3 : Form
    {

        IService serv = new Service();
        public Form3()
        {
            InitializeComponent();


            dataGridView1.DataSource = serv.leerFamiliares();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtLegajoEmpleadoUpOrDel.Text.Length > 0)
            {
                int id_familiar = int.Parse(txtLegajoEmpleadoUpOrDel.Text);
                Boolean result = serv.BorrarFamiliar(id_familiar);

                if (result == true)
                {
                    MessageBox.Show("Familiar borrado correctamente");
                    dataGridView1.DataSource = serv.leerFamiliares();
                }
                else
                {
                    MessageBox.Show("Error al borrar Familiar");
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado el id_familiar");
            }
        }
    }
}

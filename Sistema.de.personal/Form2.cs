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
    public partial class Form2 : Form
    {
        IService serv = new Service();

        public Form2()
        {
            InitializeComponent();
            cmbCategoria.DataSource = Enum.GetValues(typeof(Categorias));
            cmbProfesion.DataSource = Enum.GetValues(typeof(Profesiones));

            cmbParentesco.DataSource = Enum.GetValues(typeof(Parentescos));


            dataGridView1.DataSource = serv.leerEmpleados();
            



        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
           
            
            
            frm.Show();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Empleado empleado = new Empleado();

            String nombre, apellido,categoria, area, profesion,supervisor;
            int sueldo, dni, edad;

            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtDni.Text.Length > 0 && txtEdad.Text.Length > 0 && txtSueldo.Text.Length > 0)
            {
  
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            dni = Convert.ToInt32(txtDni.Text);
            edad = Convert.ToInt32(txtEdad.Text);
            sueldo = Convert.ToInt32(txtSueldo.Text);
            categoria = cmbCategoria.SelectedValue.ToString();
            area = cmbArea.SelectedItem.ToString();
            profesion = cmbProfesion.SelectedValue.ToString();
                supervisor = txtSupervisor.Text;
            
                empleado.setNombre(nombre);
                empleado.setApellido(apellido);
                empleado.setDni(dni);
                empleado.setEdad(edad);
                empleado.setSupervisor(supervisor);
                empleado.setSueldo(sueldo);
                empleado.setCategoria(categoria);
                empleado.setArea(area);
                empleado.setProfesion(profesion);
                empleado.setTarea();
                
                
               Boolean result = serv.AgregarEmpleado(empleado);
                
                if(result == true)
                {
                    MessageBox.Show("Empleado agregado correctamente");

                    txtDni.Clear();
                    txtApellido.Clear();
                    txtEdad.Clear();
                    txtNombre.Clear();
                    txtSueldo.Clear();
                    txtSupervisor.Clear();

                    dataGridView1.DataSource = serv.leerEmpleados();


                }
                else
                {
                    MessageBox.Show("Error al agregar empleado");
                }
                
            }
            else
            {
                MessageBox.Show("Faltan Campos a completar");
            }


           



        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
      
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
           
            
            
            
            Familiar familiar = new Familiar();

            if (txtApellidoFamiliar.Text.Length > 0 && txtDniFamiliar.Text.Length > 0 && txtEdadFamiliar.Text.Length > 0 && txtNombreFamiliar.Text.Length > 0 && txtLegajoEmpleado.Text.Length > 0 && cmbParentesco.SelectedValue.ToString().Length > 0)
            {
                String parentesco = cmbParentesco.SelectedValue.ToString();
                String nombre = txtNombreFamiliar.Text;
                String apellido = txtApellidoFamiliar.Text;
                int edad = int.Parse(txtEdadFamiliar.Text);
                int dni = int.Parse(txtDniFamiliar.Text);
                int legajo = int.Parse(txtLegajoEmpleado.Text);





                familiar.setParentesco(parentesco);
                familiar.setDni(dni);
                familiar.setNombre(nombre);
                familiar.setApellido(apellido);
                familiar.setEdad(edad);
                familiar.setLegajo(legajo);

               Boolean valor = serv.AgregarFamiliar(familiar);

                if (valor == true)
                {
                    MessageBox.Show("Familiar agregado correctamente");

                    txtDniFamiliar.Clear();
                    txtApellidoFamiliar.Clear();
                    txtEdadFamiliar.Clear();
                    txtNombreFamiliar.Clear();
                    txtLegajoEmpleado.Clear();
                                        
                }
                else
                {
                    MessageBox.Show("Error al agregar familiar");
                }

            }
            else
            {
                MessageBox.Show("Faltan campos del familiar por completar");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbProfesion.SelectedValue.ToString() == "Administrador")
            {
                cmbArea.Items.Clear();

                int cont = 0;
                foreach (String i in Enum.GetNames(typeof(Areas)))
                {


                    if (cont > 3 && cont < 7 || cont == 0)
                    {
                        cmbArea.Items.Add(i);
                     
                    }
                    else
                    {
                        cmbArea.Items.Remove(i);
                    }
                    cont += 1;

                }
            }

            if (cmbProfesion.SelectedValue.ToString() == "Programador")
            {
                cmbArea.Items.Clear();

                int cont = 0;
                foreach (String i in Enum.GetNames(typeof(Areas)))
                {


                    if (cont < 4)
                    {
                        cmbArea.Items.Add(i);
                    
                    }
                    else
                    {
                        cmbArea.Items.Remove(i);
                    }
                    cont += 1;

                }
            }


            if (cmbProfesion.SelectedValue.ToString() == "Contador")
            {
                cmbArea.Items.Clear();

                int cont = 0;
                foreach (String i in Enum.GetNames(typeof(Areas)))
                {


                    if (cont > 7 || cont == 5)
                    {
                        cmbArea.Items.Add(i);
                   
                    }
                    else
                    {
                        cmbArea.Items.Remove(i);
                    }
                    cont += 1;

                }
            }

            if (cmbProfesion.SelectedValue.ToString() == "Reclutador")
            {
                cmbArea.Items.Clear();
                int cont = 0;
                foreach (String i in Enum.GetNames(typeof(Areas)))
                {


                    if (cont > 5 && cont < 8 || cont == 4)
                    {
                        cmbArea.Items.Add(i);
                       
                    }
                    else
                    {
                        cmbArea.Items.Remove(i);
                    }
                    cont += 1;

                }
            }



        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtLegajoEmpleadoUpOrDel.Text.Length > 0)
            {
                int legajo = int.Parse(txtLegajoEmpleadoUpOrDel.Text);
                Boolean result = serv.BorrarEmpleado(legajo);

                if (result == true)
                {
                    MessageBox.Show("Empleado borrado correctamente");
                    dataGridView1.DataSource = serv.leerEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al borrar empleado");
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado el legajo");
            }
            
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}

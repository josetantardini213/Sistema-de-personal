using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Sistema.de.personal

{
    class Service : IService
    {

        public Boolean Verificar(Usuario usuario)
        {

            try
            {

                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                DataTable dt = new DataTable();

                string consulta = "SELECT * FROM usuarios WHERE usuario='" + usuario.getUser() + "'";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                int valor = da.Fill(dt);

                if (valor <= 0) {
                    conn.Close();
                    return false;
                }
                else
                {

                    DataRow row = dt.Rows[0];
                    //guardo datos en variables
                    String passwordbd = Convert.ToString(row["pass"]);
                    String passwordclass = usuario.getPass();


                    int verify = string.Compare(ObterD5Hash(passwordclass), passwordbd, true);

                    if (verify == 0) {
                        conn.Close();

                        return true;
                    }
                    else
                    {
                        conn.Close();

                        return false;
                    }

                }
            }
            catch (Exception error)
            {
                Console.Write(error);

                return false;
            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();


            }



        }




        

        public Boolean AgregarEmpleado(Empleado empleado){

            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                string consulta = "INSERT INTO empleados (nombre, apellido,edad, dni, sueldo, antiguedad, categoria, area, profesion, supervisor, tarea) VALUES ('" + empleado.getNombre() + "','" + empleado.getApellido() + "','" + empleado.getEdad() + "','" + empleado.getDni() + "','" + empleado.getSueldo() + "','" + empleado.getAntiguedad() + "','"+empleado.getCategoria()+ "','"+empleado.getArea()+ "','" + empleado.getProfesion() + "','" + empleado.getSupervisor() + "','" + empleado.getTarea() +"')";

                Console.WriteLine(consulta);
                
                SqlCommand cmd = new SqlCommand(consulta, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;

            }
            catch (Exception error)
            {

                Console.Write(error);

                return false;

            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();

            }



                return true;
        }




        public Boolean AgregarFamiliar(Familiar familiar)
        {
            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                string consulta = "INSERT INTO familiares (nombre, apellido,edad, dni, parentesco, id_empleado) VALUES ('" + familiar.getNombre() + "','" + familiar.getApellido() + "','" + familiar.getEdad() + "','" + familiar.getDni() + "','" + familiar.getParentesco() + "','" + familiar.getLegajo() + "')";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                cmd.ExecuteNonQuery();

                conn.Close();


                return true;
            }
            catch (Exception error)
            {

                Console.Write(error);

                return false;
            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();

            }
        }



        public DataTable leerEmpleados()
        {
            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                DataTable dt = new DataTable();

                string consulta = "SELECT * FROM empleados";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                 da.Fill(dt);
                
                 return dt;
            }
            catch (Exception error)
            {
                Console.Write(error);
                return null;

            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();
            }
        }



        public DataTable leerFamiliares()
        {

            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                DataTable dt = new DataTable();

                string consulta = "select empleados.id_empleado, empleados.nombre,empleados.apellido,empleados.dni, id_familiar,familiares.parentesco, familiares.nombre,familiares.apellido,familiares.dni,familiares.edad from empleados inner join familiares on empleados.id_empleado=familiares.id_empleado";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                
                return dt;

            }
            catch (Exception error)
            {
                Console.Write(error);
                return null;
            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();
            }



        }


        public Boolean BorrarEmpleado(int legajo)
        {
            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                string consulta = "DELETE FROM empleados WHERE id_empleado='" + legajo + "'";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                cmd.ExecuteNonQuery();

                string consulta2 = "DELETE FROM familiares WHERE id_empleado='" + legajo + "'";

                SqlCommand cmd2 = new SqlCommand(consulta2, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception error)
            {

                Console.Write(error);

                return false;
            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();
            }
        }



        public Boolean BorrarFamiliar(int id_familiar)
        {
            try
            {
                Conexion db = new Conexion();

                SqlConnection conn = db.Conectar();

                conn.Open();

                string consulta = "DELETE FROM familiares WHERE id_familiar='" + id_familiar + "'";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception error)
            {

                Console.Write(error);

                return false;
            }
            finally
            {
                Conexion db = new Conexion();
                SqlConnection conn = db.Conectar();

                conn.Close();
            }
        }

            public string ObterD5Hash(string secreto)

        {

            MD5 Assimmd5Hasher = MD5.Create();

            byte[] data = Assimmd5Hasher.ComputeHash(Encoding.UTF8.GetBytes(secreto));

            StringBuilder Comecar_Criar = new StringBuilder();

            for (int i = 0; i < data.Length; i++)

                Comecar_Criar.Append(data[i].ToString("x2"));

            return Comecar_Criar.ToString();

        }

    }
}

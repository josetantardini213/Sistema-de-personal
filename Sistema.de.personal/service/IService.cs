using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema.de.personal
{
    internal interface IService
    {
        bool Verificar(Usuario users);

        string ObterD5Hash(string secreto);

        Boolean AgregarEmpleado(Empleado empleado);

        Boolean AgregarFamiliar(Familiar familiar);

        DataTable leerEmpleados();

        DataTable leerFamiliares();

        Boolean BorrarEmpleado(int legajo);

        Boolean BorrarFamiliar(int id_familiar);



    }
}

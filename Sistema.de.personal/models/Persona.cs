using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.de.personal
{
    internal class Persona
    {
        private String nombre;
        private String apellido;
        private int edad;
        private int dni;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public String getApellido()
        {
            return apellido;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return dni;
        }

    }
}

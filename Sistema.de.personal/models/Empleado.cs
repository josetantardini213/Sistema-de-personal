using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.de.personal
{
    internal class Empleado : Persona
    {

        private int sueldo;
        private int antiguedad;
        private Categorias categoria;
        private Areas area;
        private Profesiones profesion;
        private String supervisor;
        private Tareas tarea;


        public Empleado()
        {
            antiguedad = 0;
        }


        public void setSueldo(int sueldo)
        {
            this.sueldo = sueldo;
        }

        public int getSueldo()
        {
            return sueldo;
        }

        public void setAntiguedad(int antiguedad)
        {
            this.antiguedad = antiguedad;
        }

        public int getAntiguedad()
        {
            return antiguedad;
        }

        public void setCategoria(String categoria)
        {
            this.categoria = (Categorias)Enum.Parse(typeof(Categorias), categoria);
        }

        public String getCategoria()
        {
            return categoria.ToString();
        }

        public void setArea(String area)
        {
            this.area = (Areas)Enum.Parse(typeof(Areas), area);
        }


        public String getArea()
        {
            return area.ToString();
        }
        public void setProfesion(String profesion)
        {
            this.profesion = (Profesiones)Enum.Parse(typeof(Profesiones), profesion);
        }

        public String getProfesion()
        {
            return profesion.ToString();
        }

        public void setSupervisor(String supervisor)
        {
            this.supervisor = supervisor;
        }

        public String getSupervisor()
        {
            return supervisor;
        }

        public String getTarea()
        {

            return tarea.ToString();
        }







        //En base a la profesion seleccionada, a el area y su categoria le va a corresponder una tarea determinada

        public void setTarea()
        {

            switch (this.profesion) //PROFESION
            {
                case Profesiones.Programador://PROFESION

                    switch (this.area)//AREA
                    {
                        case Areas.Sistemas://AREA

                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Tester;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.Documentacion;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.SoporteDeAplicaciones;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.DesarrolloDeAplicaciones;

                                    break;
                            
                            }//TAREA


                            break;
                        case Areas.DesarrolloWeb://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Tester;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.Documentacion;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.SoporteDeAplicaciones;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.DesarrolloDeAplicaciones;

                                    break;
                            }//TAREA

                            break;
                        case Areas.AplicacionesMobiles://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Tester;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.Documentacion;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.SoporteDeAplicaciones;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.DesarrolloDeAplicaciones;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Videojuegos://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Tester;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.Documentacion;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.SoporteDeAplicaciones;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.DesarrolloDeAplicaciones;

                                    break;
                            }//TAREA

                            break;
                    }
                    

                    break;

                case Profesiones.Reclutador://PROFESION
                    switch (this.area) //AREA
                    {
                        case Areas.Administracion://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Recepcionista;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.RRHH: //AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.SeleccionarPersonal;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.ReclutarPersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.Entrevistar;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.EvaluarCandidatos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.ProcesosDeReclutamiento://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.ReclutarPersonal;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.SeleccionarPersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.EvaluarCandidatos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.Contratar;

                                    break;
                            }//TAREA

                            break;
                      
                    }
                    break;

                case Profesiones.Contador://PROFESION
                    switch (this.area)
                    {
                        case Areas.Fiscal://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Facturaciones;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Finanzas://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Facturaciones;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.ContabilidadGeneral;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.ContabilidadExterna;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Ventas://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.ContabilidadInterna;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.ContabilidadPorCuenta;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.ContabilidadPorProveedor;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.ContabilidadGeneral;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Facturacion://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Facturaciones;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.ContabilidadPorProveedor;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.ContabilidadPorCliente;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.ContabilidadGeneral;

                                    break;
                            }//TAREA

                            break;
                    }
                    break;

                case Profesiones.Administrador://PROFESION
                    switch (this.area)
                    {
                        case Areas.Sistemas://AREA


                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Recepcionista;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Administracion://AREA

                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Recepcionista;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.Ventas://AREA

                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Recepcionista;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                        case Areas.RRHH://AREA

                            switch (this.categoria) //TAREA
                            {
                                case Categorias.Trainee://TAREA

                                    tarea = Tareas.Recepcionista;

                                    break;
                                case Categorias.Junior://TAREA

                                    tarea = Tareas.AdministracionDePersonal;

                                    break;
                                case Categorias.SemiSenior://TAREA

                                    tarea = Tareas.AdministracionDeProyectos;

                                    break;
                                case Categorias.Senior://TAREA

                                    tarea = Tareas.AdministracionDeRecursos;

                                    break;
                            }//TAREA

                            break;
                    }
                    break;


            }

         



        }





    }
}

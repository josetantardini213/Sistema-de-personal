using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.de.personal
{
    internal enum Tareas
    {
        //para Programador
        SoporteDeAplicaciones,
        DesarrolloDeAplicaciones,
        Documentacion,
        Tester,
        
       
        //para Administrador
        Recepcionista,
        AdministracionDePersonal,
        AdministracionDeProyectos,
        AdministracionDeRecursos,
        


        //Reclutador
        ReclutarPersonal,
         Entrevistar,
        SeleccionarPersonal,
        Contratar,
        EvaluarCandidatos,
        


        //para Contador
        Facturaciones,
        ContabilidadGeneral,
        ContabilidadPorCuenta,
        ContabilidadPorCliente,
        ContabilidadPorProveedor,
        ContabilidadPorProducto,
        ContabilidadInterna,
        ContabilidadExterna,
        
        //TAREA NO DEFINIDA CORRECTAMENTE PORQUE NO COINCIDE LA PROFESION CON EL AREA
        ErrorProfesionNoCoincideConArea

    }
}

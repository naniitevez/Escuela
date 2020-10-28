using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeEscuela.Servicios
{
    public class ProfesorServicio
    {
        public ProfesorServicio()
        {
            materiaServicio = new MateriaServicio();
        }

        private MateriaServicio materiaServicio;


        public List<Profesor> ObtenerTodos()
        {
            List<Profesor> profesores = new List<Profesor>();

            Profesor profesor = new Profesor();
            profesor.Nombre = "Ricardo D.";
            profesor.Dni = 40640704;
            profesor.Disponible = true;
            profesor.Materia = materiaServicio.ObtenerPorNombre("Lengua");

            profesores.Add(profesor);


            Profesor profesor1 = new Profesor();
            profesor1.Nombre = "Magdalena";
            profesor1.Dni = 24941944;
            profesor1.Disponible = false;
            profesor1.Materia = materiaServicio.ObtenerPorNombre("Matemática");

            profesores.Add(profesor1);


            Profesor profesor2 = new Profesor();
            profesor2.Nombre = "Robertina";
            profesor2.Dni = 24361944;
            profesor2.Disponible = true;
            profesor2.Materia = materiaServicio.ObtenerPorNombre("Matemática");

            profesores.Add(profesor2);


            Profesor profesor3 = new Profesor();
            profesor3.Nombre = "Romina";
            profesor3.Dni = 29941023;
            profesor3.Disponible = true;
            profesor3.Materia = materiaServicio.ObtenerPorNombre("Ed. Física");

            profesores.Add(profesor3);


            Profesor profesor4 = new Profesor();
            profesor4.Nombre = "Magdalena";
            profesor4.Dni = 30141112;
            profesor4.Disponible = false;
            profesor4.Materia = materiaServicio.ObtenerPorNombre("Lengua");

            profesores.Add(profesor4);


            Profesor profesor5 = new Profesor();
            profesor5.Nombre = "Romualdo";
            profesor5.Dni = 17456774;
            profesor5.Disponible = true;
            profesor5.Materia = materiaServicio.ObtenerPorNombre("Historia");

            profesores.Add(profesor5);


            Profesor profesor6 = new Profesor();
            profesor6.Nombre = "Justina";
            profesor6.Dni = 34941006;
            profesor6.Disponible = true;
            profesor6.Materia = materiaServicio.ObtenerPorNombre("Ed. Física");

            profesores.Add(profesor6);


            Profesor profesor7 = new Profesor();
            profesor7.Nombre = "Héctor";
            profesor7.Dni = 19999001;
            profesor7.Disponible = true;
            profesor7.Materia = materiaServicio.ObtenerPorNombre("Matemática");

            profesores.Add(profesor7);


            Profesor profesor8 = new Profesor();
            profesor8.Nombre = "José B.";
            profesor8.Dni = 24941944;
            profesor8.Disponible = false;
            profesor8.Materia = materiaServicio.ObtenerPorNombre("Geografía");

            profesores.Add(profesor8);


            Profesor profesor9 = new Profesor();
            profesor9.Nombre = "Beatriz";
            profesor9.Dni = 41065789;
            profesor9.Disponible = true;
            profesor9.Materia = materiaServicio.ObtenerPorNombre("Geografía");

            profesores.Add(profesor9);


            Profesor profesor10 = new Profesor();
            profesor10.Nombre = "Xaviera";
            profesor10.Dni = 27983094;
            profesor10.Disponible = false;
            profesor10.Materia = materiaServicio.ObtenerPorNombre("Geografía");

            profesores.Add(profesor10);


            Profesor profesor11 = new Profesor();
            profesor11.Nombre = "Rodolfo";
            profesor11.Dni = 12356454;
            profesor11.Disponible = false;
            profesor11.Materia = materiaServicio.ObtenerPorNombre("Ciencias Sociales");

            profesores.Add(profesor11);


            Profesor profesor12 = new Profesor();
            profesor12.Nombre = "Javier";
            profesor12.Dni = 38350429;
            profesor12.Disponible = false;
            profesor12.Materia = materiaServicio.ObtenerPorNombre("Ciencias Naturales");

            profesores.Add(profesor12);



            Profesor profesor13 = new Profesor();
            profesor13.Nombre = "Javier";
            profesor13.Dni = 28760400;
            profesor13.Disponible = true;
            profesor13.Materia = materiaServicio.ObtenerPorNombre("Ciencias Naturales");

            profesores.Add(profesor13);


            Profesor profesor14 = new Profesor();
            profesor14.Nombre = "Ludmila";
            profesor14.Dni = 38987783;
            profesor14.Disponible = false;
            profesor14.Materia = materiaServicio.ObtenerPorNombre("Historia");

            profesores.Add(profesor14);


            Profesor profesor15 = new Profesor();
            profesor15.Nombre = "Javier";
            profesor15.Dni = 37178429;
            profesor15.Disponible = false;
            profesor15.Materia = materiaServicio.ObtenerPorNombre("Ed. Física");

            profesores.Add(profesor15);




            return profesores;
        }





        }
}

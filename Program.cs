using System;

namespace ProyectoDeEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            AlumnoServicio alumnoServicio = new AlumnoServicio();
            
            EscuelaServicio escuelaServicio = new EscuelaServicio();

            Escuela escuela = escuelaServicio.CrearEscuela();


            Console.WriteLine("Alumnos:");


            foreach (var item in escuela.Alumnos)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.WriteLine();
            Console.WriteLine("Buscar alumno por nombre:");

            Alumno alumno = alumnoServicio.ObtenerPorNombre("Guillermo");

            Console.WriteLine("El alumno es: " + alumno.Nombre);


            Console.WriteLine();

            Console.WriteLine("Buscar alumno por DNI: ");

            Alumno alumno1 = alumnoServicio.ObtenerPorDNI(18324098);

            Console.WriteLine("El alumno es: " + alumno.Dnib);

            Console.WriteLine();
            Console.WriteLine("Materias:");



            foreach (var item in escuela.Materias)
            {
                Console.WriteLine(item.Nombre);
            }



            Console.WriteLine("Hello World!");
        }
    }
}

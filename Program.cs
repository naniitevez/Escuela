using System;

namespace ProyectoDeEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EscuelaServicio escuelaServicio = new EscuelaServicio();

            Escuela escuela = escuelaServicio.CrearEscuela();


            Console.WriteLine("Alumnos:");


            foreach (var item in escuela.Alumnos)
            {
                Console.WriteLine(item.Nombre);
            }

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

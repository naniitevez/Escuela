using System.Collections.Generic;
namespace ProyectoDeEscuela
{
    public class Grado
    {
        public Grado()
        {
            Alumnos = new List<Alumno>();
        }

        public int Numero { get; set; }
        public string Letra { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}
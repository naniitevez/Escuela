using System.Collections.Generic;
namespace ProyectoDeEscuela
{
    public class Escuela
    {
        public Escuela()
        {
            Alumnos = new List<Alumno>();
            Materias = new List<Materia>();
            Grados = new List<Grado>();
            Profesores = new List<Profesor>();
            Lecciones = new List<Lección>();
        }

        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Grado> Grados { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Lección> Lecciones { get; set; }
    }
}
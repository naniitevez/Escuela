using System;
namespace ProyectoDeEscuela
{
    public class Lección
    {
        public Materia Materia { get; set; }

        public Grado Grado { get; set; }

        public DateTime HoraDeComienzo { get; set; }

        public DateTime HoraDeFinalización { get; set; }
    }
}
namespace ProyectoDeEscuela
{
    public class EscuelaServicio
    {
        public EscuelaServicio()
        {
            alumnoServicio = new AlumnoServicio();
            materiaServicio = new MateriaServicio();
        }
        private AlumnoServicio alumnoServicio;
        private MateriaServicio materiaServicio;

        public Escuela CrearEscuela()
        {
            Escuela escuela = new Escuela();
            escuela.Alumnos = alumnoServicio.ObtenerTodos();
            escuela.Materias = materiaServicio.ObtenerTodas();
            return escuela;
        }
    }
}
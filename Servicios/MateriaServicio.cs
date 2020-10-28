using System.Collections.Generic;

namespace ProyectoDeEscuela
{
    public class MateriaServicio
    {
        public List<Materia> ObtenerTodas()
        {
            List<Materia> materias = new List<Materia>();

            Materia materia1 = new Materia();
            materia1.Nombre = "Lengua";
            materia1.Nivel = NivelMateria.Fácil;

            materias.Add(materia1);

            Materia materia2 = new Materia();
            materia2.Nombre = "Ed. Física";
            materia2.Nivel = NivelMateria.Difícil;

            materias.Add(materia2);

            Materia materia3 = new Materia();
            materia3.Nombre = "Matemática";
            materia3.Nivel = NivelMateria.Medio;

            materias.Add(materia3);

            Materia materia4 = new Materia();
            materia4.Nombre = "Geografía";
            materia4.Nivel = NivelMateria.Difícil;

            materias.Add(materia4);

            Materia materia5 = new Materia();
            materia5.Nombre = "Ciencias Naturales";
            materia5.Nivel = NivelMateria.Fácil;

            materias.Add(materia5);

            Materia materia6 = new Materia();
            materia6.Nombre = "Ciencias Sociales";
            materia6.Nivel = NivelMateria.Difícil;

            materias.Add(materia6);

            Materia materia7 = new Materia();
            materia7.Nombre = "Historia";
            materia7.Nivel = NivelMateria.Medio;

            materias.Add(materia7);

            return materias;
        }
        Materia ObtenerPorNombre(string nombre)
        {
            List<Materia> listaDeMaterias = ObtenerTodas();
            Materia materia = null; 
            foreach(Materia item in listaDeMaterias)
            {
                if (item.Nombre == nombre){
                    materia = item;
                    break;
                }
            }
            return materia; 
        }

}
}


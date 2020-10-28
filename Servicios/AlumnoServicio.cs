using System.Collections.Generic;

namespace ProyectoDeEscuela
{
    public class AlumnoServicio
    {
        public List<Alumno> ObtenerTodos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Aurora";
            alumno1.Dni = 18324098;
            alumno1.Sexo = Sexo.Mujer;

            alumnos.Add(alumno1);


            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Josefina";
            alumno2.Dni = 18543867;
            alumno2.Sexo = Sexo.Mujer;

            alumnos.Add(alumno2);


            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Román";
            alumno3.Dni = 18424392;
            alumno3.Sexo = Sexo.Hombre;

            alumnos.Add(alumno3);


            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Miranda";
            alumno4.Dni = 18394068;
            alumno4.Sexo = Sexo.Mujer;

            alumnos.Add(alumno4);


            Alumno alumno5 = new Alumno();
            alumno5.Nombre = "Julián";
            alumno5.Dni = 18098098;
            alumno5.Sexo = Sexo.Hombre;

            alumnos.Add(alumno5);


            Alumno alumno6 = new Alumno();
            alumno6.Nombre = "Camilo";
            alumno6.Dni = 17200983;
            alumno6.Sexo = Sexo.Hombre;

            alumnos.Add(alumno6);


            Alumno alumno7 = new Alumno();
            alumno7.Nombre = "Camila";
            alumno7.Dni = 17409205;
            alumno7.Sexo = Sexo.Mujer;

            alumnos.Add(alumno7);


            Alumno alumno8 = new Alumno();
            alumno8.Nombre = "Manuel";
            alumno8.Dni = 17200205;
            alumno8.Sexo = Sexo.Hombre;

            alumnos.Add(alumno8);


            Alumno alumno9 = new Alumno();
            alumno9.Nombre = "Jimena";
            alumno9.Dni = 17407605;
            alumno9.Sexo = Sexo.Mujer;

            alumnos.Add(alumno9);


            Alumno alumno10 = new Alumno();
            alumno10.Nombre = "Andrés";
            alumno10.Dni = 18123405;
            alumno10.Sexo = Sexo.Hombre;

            alumnos.Add(alumno10);


            Alumno alumno11 = new Alumno();
            alumno11.Nombre = "Carmen";
            alumno11.Dni = 17423295;
            alumno11.Sexo = Sexo.Mujer;

            alumnos.Add(alumno11);


            Alumno alumno12 = new Alumno();
            alumno12.Nombre = "Ian";
            alumno12.Dni = 17403450;
            alumno12.Sexo = Sexo.Hombre;

            alumnos.Add(alumno12);


            Alumno alumno13 = new Alumno();
            alumno13.Nombre = "Sebastián";
            alumno13.Dni = 18401380;
            alumno13.Sexo = Sexo.Hombre;

            alumnos.Add(alumno13);


            Alumno alumno14 = new Alumno();
            alumno14.Nombre = "Florencia";
            alumno14.Dni = 18690987;
            alumno14.Sexo = Sexo.Mujer;

            alumnos.Add(alumno14);


            Alumno alumno15 = new Alumno();
            alumno15.Nombre = "Ethan";
            alumno15.Dni = 17089768;
            alumno15.Sexo = Sexo.Hombre;

            alumnos.Add(alumno15);


            Alumno alumno16 = new Alumno();
            alumno16.Nombre = "Erica";
            alumno16.Dni = 17029748;
            alumno16.Sexo = Sexo.Mujer;

            alumnos.Add(alumno16);


            Alumno alumno17 = new Alumno();
            alumno17.Nombre = "Florencia";
            alumno17.Dni = 17082348;
            alumno17.Sexo = Sexo.Mujer;

            alumnos.Add(alumno17);


            Alumno alumno18 = new Alumno();
            alumno18.Nombre = "Verónica";
            alumno18.Dni = 17119718;
            alumno18.Sexo = Sexo.Mujer;

            alumnos.Add(alumno18);


            Alumno alumno19 = new Alumno();
            alumno19.Nombre = "Pablo";
            alumno19.Dni = 17065768;
            alumno19.Sexo = Sexo.Hombre;

            alumnos.Add(alumno19);


            Alumno alumno20 = new Alumno();
            alumno20.Nombre = "Guillermo";
            alumno20.Dni = 18222006;
            alumno20.Sexo = Sexo.Hombre;

            alumnos.Add(alumno20);

            return alumnos;

        }

        public Alumno ObtenerPorNombre(string nombre)
        {
            List<Alumno> listaDeAlumnos = ObtenerTodos();

            Alumno alumno = null;

            foreach (Alumno item in listaDeAlumnos)
            {
                if (item.Nombre == nombre)
                {
                    alumno = item;
                    break;
                }
            }
            return alumno;
        }

        public Alumno ObtenerPorDNI(int dni)
        {
            List<Alumno> listaDeAlumnos = ObtenerTodos();

            Alumno alumno = null;

            foreach (Alumno item in listaDeAlumnos)
            {
                if (item.Dni == dni)
                {
                    alumno = item;
                    break;
                }
            }
            return alumno;
        }

    }
}
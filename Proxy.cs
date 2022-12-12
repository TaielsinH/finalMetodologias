using System;
namespace MetodologíasDeProgramaciónI
{
    public class ProxyAlumno : IAlumno, Comparable
    {
        IAlumno alumnoReal = null;
        string nombre;
        public static int cualAlumno;
        public ProxyAlumno(string nombre)
        {
            this.nombre = nombre;
        }
        public int ResponderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(cualAlumno);
                alumnoReal.setNombre(nombre);
                alumnoReal = new AlumnoDecoratorLegajo((Alumno)alumnoReal);
                alumnoReal = new AlumnoDecoratorLetras(alumnoReal);
                alumnoReal = new AlumnoDecoratorCasos(alumnoReal);
                alumnoReal = new AlumnoDecoratorRecuadro(alumnoReal);
                Console.WriteLine("Se ha creado alumno real");
            }
            return alumnoReal.ResponderPregunta(pregunta);
        }
 
        public int getLegajo()
        {
            return alumnoReal.getLegajo();
        }

        public int getCalificacion()
        {
           return alumnoReal.getCalificacion();
        }
        public string mostrarCalificacion()
        {
            return alumnoReal.mostrarCalificacion();
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string name)
        {
            alumnoReal.setNombre(name);
        }
        public bool sosIgual(Comparable c)
        {
            return alumnoReal.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return alumnoReal.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            return alumnoReal.sosMayor(c);
        }
        public void setCalificacion(int valor)
        {

        }

    }
}

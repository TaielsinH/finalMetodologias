
using System;

namespace MetodologíasDeProgramaciónI
{


    public class Alumno : Persona, IAlumno
    {
        private int legajo;
        private float promedio;
        private  Strategy estrategia;
        private int calificacion;
        public Alumno(string n, int d, int legajo, float promedio) : base(n, d)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            SetEstrategia(0);
        }
        public Strategy SetEstrategia(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    estrategia = new porDNI();
                    break;
                case 1:
                    estrategia = new porNombre();
                    break;
                case 2:
                    estrategia = new porLegajo();
                    break;
                case 3:
                    estrategia = new porPromedio();
                    break;  
            }
            return estrategia;  
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            Random random = new Random();
            int num = random.Next(1, 3);
            return num;

        }
        public void setNombre(string name)
        {
            nombre = name;
        }
        public string mostrarCalificacion()
        {
            return nombre + "      " + calificacion.ToString();
        }
        public int getLegajo()
        {
            return legajo;
        }
        public void setCalificacion(int valor)
        {
            calificacion = valor;
        }
        public int getCalificacion()
        {
            return calificacion;
        }
        public float getPromedio { get { return promedio; } }

        public override bool sosIgual(Comparable c)
        {
            return estrategia.esIgual(this, c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.esMenor(this, c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.esMayor(this, c);
        }
        public override string ToString()
        {
            return nombre + " dni: " + dni.ToString() + "  legajo: " + legajo.ToString() + "  promedio: " + promedio.ToString();
        }

    }
}


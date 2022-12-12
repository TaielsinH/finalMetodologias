
using System;
using System.Collections.Generic;

namespace MetodologíasDeProgramaciónI
{

    public interface Comparable
    {
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool sosMayor(Comparable c);

    }
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene(Comparable c);
    }
    public interface IAlumno
    {
        int ResponderPregunta(int pregunta);
        int getLegajo();
        int getCalificacion();
        string mostrarCalificacion();
        string getNombre();
        void setNombre(string nombre);
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool sosMayor(Comparable c);
        void setCalificacion(int valor);
    }



}

﻿using System;
using System.Collections.Generic;

namespace MetodologíasDeProgramaciónI
{
    public class Diccionario : Coleccionable, Iterable, Ordenable
    {
        List<ClaveValor> diccionario;
        public Diccionario()
        {
            diccionario = new List<ClaveValor>();
        }
        public Iterador crearIterador()
        {
            return new IteradorDiccionarios(diccionario);
        }
        OrdenEnAula1 ordenInicio = null, ordenFin = null;
        OrdenEnAula2 ordenAlumno = null;
        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            ordenAlumno = orden;
        }
        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            ordenFin = orden;
        }
        public void agregar(Comparable clave, Comparable valor)
        {
            bool encontrado = false; //false si no se encontró. true si se encontró
            for (int i = 0; i < diccionario.Count - 1; i++)
            {
                if (clave.sosIgual(diccionario[i].getClave()))
                {
                    ClaveValor elem = new ClaveValor(clave, valor);
                    diccionario.RemoveAt(i);
                    diccionario.Add(elem);
                    encontrado = true;
                    break;
                }

            }
            if (!encontrado)
            {
                ClaveValor elem = new ClaveValor(clave, valor);
                diccionario.Add(elem);
                if (ordenAlumno != null)
                {
                    ordenAlumno.ejecutar(elem);
                }
            }
            if (diccionario.Count == 1)
            {
                if (ordenInicio != null)
                    ordenInicio.ejecutar();
            }
            if (diccionario.Count == 40)
            {
                if (ordenFin != null)
                    ordenFin.ejecutar();
            }
            

        }
        public Comparable valorDe(Comparable c)
        {
            bool encontrado = false;
            Comparable res = c;
            for (int i = 0; i < diccionario.Count; i++)
            {
                if (c.sosIgual(diccionario[i].getClave()))
                {
                    encontrado = true;
                    res = diccionario[i].getValor();
                    return res;
                }
            }
            if (!encontrado)
                return res = null;

            return res;
        }

        public int cuantos()
        {
            return diccionario.Count;
        }
        public Comparable minimo()
        {
            Comparable min = diccionario[0].getValor();
            for (int i = 0; i < diccionario.Count - 1; i++)
            {
                if (diccionario[i].getValor().sosMenor(min))
                    min = diccionario[i].getValor();
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = diccionario[0].getValor();
            for (int i = 0; i < diccionario.Count - 1; i++)
            {
                if (diccionario[i].getValor().sosMenor(max))
                    max = diccionario[i].getValor();
            }
            return max;
        }
        public bool contiene(Comparable c)
        {
            bool encontrado = false;
            for (int i = 0; i < diccionario.Count - 1; i++)
            {
                if (diccionario[i].getValor().sosIgual(c))
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
        public void agregar(Comparable c)
        {
            ClaveValor.claveGenerica++;
            Comparable claveNueva = new Numero(ClaveValor.claveGenerica);
            for (int i = 0; i < diccionario.Count - 1; i++)
            {
                if (claveNueva.sosIgual(diccionario[i].getClave()))
                {
                    ClaveValor elem = new ClaveValor(claveNueva, c);
                    diccionario.RemoveAt(i);
                    diccionario.Add(elem);
                }
            }
        }
    }
    public class ClaveValor : Comparable
    {
        private Comparable clave;
        private Comparable valor;
        public static int claveGenerica = 0;

        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Comparable getClave()
        {
            return clave;
        }
        public Comparable getValor()
        {
            return valor;
        }
        public bool sosIgual(Comparable c)
        {
            return false;
        }
        public bool sosMenor(Comparable c)
        {
            return false;
        }
        public bool sosMayor(Comparable c)
        {
            return false;
        }
    }
}
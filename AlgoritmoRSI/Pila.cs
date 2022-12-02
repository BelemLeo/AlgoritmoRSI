using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoRSI
{
    internal class Pila

    {
        public Nodos[] listaAlumno;
        public Nodos tope;
        int max;
        int size;
        public Pila()
        {
            listaAlumno = new Nodos[5];
            max = listaAlumno.Length - 1;
        }

        private bool ValidaLleno()
        {
            return (size >= max);
        }

        public void Apilar(Nodos nodo)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            else
            {
                Nodos auxiliar = tope;

                tope = nodo;

                tope.Siguiente = auxiliar;

                listaAlumno[size] = tope;
                size++;
            }

        }
        public void Eliminar()
        {
            if (size > max)
            {
                throw new Exception("Arreglo Vacio");
            }
            size--;
            listaAlumno[size] = null;

        }
        public List<Nodos> VisualizarElementos()
        {
            return listaAlumno.ToList();

        }


    }
    public class Colas
    {

        private Nodos[] ColaAlumnos;
        private int max;
        private int principio;
        private int final;



        public Colas()
        {
            ColaAlumnos = new Nodos[30];
            max = ColaAlumnos.Length - 1;
            principio = 0;
            final = 0;
        }
        private bool ColaVacio()
        {
            return ((principio < 1 && final < 1)
                || principio == final);
        }
        private bool ColaLleno()
        {
            return (final > max);
        }
        public void agregar(Nodos nodocola)
        {
            if (ColaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            ColaAlumnos[final] = nodocola;
            final++;
        }
        public void Eliminar()
        {
            if (ColaVacio())
            {
                throw new Exception("Arreglo Vacio");

            }
            ColaAlumnos[principio] = null;
            principio++;
        }
    }
}
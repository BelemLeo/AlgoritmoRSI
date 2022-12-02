using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoRSI
{
    internal class Nodos
    {
        public string Nombre { get; set; }  
        public string PromedioAnterior { get; set; }   
        public Nodos Siguiente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corzo_01_
{
    class cPostulante
    {
        public string nombre, género;
        public int edad;
        public double peso, estatura;

        public cPostulante()
        {
        }

        public cPostulante(string nombre, string género, int edad, double peso, double estatura)
        {
            this.nombre = nombre;
            this.género = género;
            this.edad = edad;
            this.peso = peso;
            this.estatura = estatura;
        }
    }
}

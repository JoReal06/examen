using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exa
{
    public class Revista: gene
    {
        private string titulo, periodicidad;
        private double costo;

        public Revista(string titulo, double costo,string periodicidad) : base(titulo, costo)
        {
            this.titulo = titulo;
            this.periodicidad = periodicidad;
            this.costo = costo;
        }
    }
}

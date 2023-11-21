using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exa
{
    public class Libro : gene
    {
        private string titulo, autor, fecha_de_pulicacion;
        private double costo;
        private int id;

        public Libro(string titulo, double costo,string fecha,string autor,int id) : base(titulo, costo)
        {
            this.titulo = titulo;
            this.autor = autor;+
            this.fecha_de_pulicacion = fecha;
            this.costo = costo;
            this.id = id;
        }
    }
}

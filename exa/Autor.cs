using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exa
{
    public class Autor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string segu_nombre { get; set; }

        public int libro_publicados { get; set; }

        public Autor(int id, string name, string segun_nombre, int can_libro)
        {
            this.id = id;
            this.Name = name;
            this.segu_nombre = segun_nombre;
            this.libro_publicados = can_libro;
        }

        public Autor()
        { 
        }
    }

}

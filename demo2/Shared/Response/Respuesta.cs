using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2.Shared.Response
{
    public class Respuesta<T>
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T List { get; set; }

        public Respuesta()
        {
            Exito = 0;
        }
    }
}

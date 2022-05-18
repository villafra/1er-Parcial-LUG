using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Entidades
{
    public class BE_Cliente : IEntidable
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public BE_Gift_Card CodigoGiftCard { get; set; }

    }
}

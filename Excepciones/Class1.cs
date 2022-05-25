using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public class Excepción : Exception
    {
        public Excepción()
        {

        }

        public Excepción(string message) : base(message)
        {
            MessageBox.Show(message);
        }

        public Excepción(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}

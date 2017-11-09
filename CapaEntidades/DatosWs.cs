using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class DatosWs
    {


        private int MIdlibro;
        public int Idlibro
        {
            get { return MIdlibro; }
            set { MIdlibro = value; }

        }

        private string MnombreLibro;
        public string NombreLibro
        {
            get { return MnombreLibro; }
            set { MnombreLibro = value; }

        }

        private string Mgenero;
        public string Genero
        {
            get { return Mgenero; }
            set { Mgenero = value; }

        }

        private string mprecio;
        public string Precio
        {
            get { return mprecio; }
            set { mprecio = value; }
        }

        
    }
}

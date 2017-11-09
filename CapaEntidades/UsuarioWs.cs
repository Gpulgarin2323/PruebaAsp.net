using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class UsuarioWs
    {
        private string MnickUsuarios;
        public string NickUsuarios
        {
            get { return MnickUsuarios; }
            set { MnickUsuarios = value; }
        }

        private string MNombreUsuarios;
        public string NombreUsuarios
        {
            get { return MNombreUsuarios; }
            set { MNombreUsuarios = value; }
        }

        private string MEmailUsuarios;
        public string EmailUsuarios
        {
            get { return MEmailUsuarios; }
            set { MEmailUsuarios = value; }
        }

        private string MPassUsuarios;
        public string PassUsuarios
        {
            get { return MPassUsuarios; }
            set { MPassUsuarios = value; }
        }
    }
}

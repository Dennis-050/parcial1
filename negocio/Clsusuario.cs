using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.entidades;

using System;

namespace Parcial1.negocio
{

    public class Clsusuario
    {
        public bool Autenticacion(usuario user)
        {
            if (user.usuarioE.Equals("nombre") && user.contraseña.Equals("d1e2b22"))
            {
                return true;
            }
            return false;
        }
    }
}

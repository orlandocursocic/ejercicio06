using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public static class Operaciones
    {

        public static String concatenaMensaje(Mensaje mensaje)
        {
            return mensaje.getTexto() + mensaje.getNumero1() + mensaje.getNumero2();
        }
    }
}

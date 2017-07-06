using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Mensaje
    {

        private String texto;
        private int numero1;
        private int numero2;

        public Mensaje(String texto, int numero1, int numero2)
        {
            this.texto = texto;
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public String getTexto()
        {
            return this.texto;
        }

        public void setTexto(String texto)
        {
            this.texto = texto;
        }

        public int getNumero1()
        {
            return this.numero1;
        }

        public void setNumero1(int numero1)
        {
            this.numero1 = numero1;
        }

        public int getNumero2()
        {
            return numero2;
        }

        public void setNumero2(int numero2)
        {
            this.numero2 = numero2;
        }

    }
}

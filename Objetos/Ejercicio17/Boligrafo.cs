using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoOk
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            ConsoleColor retorno;
            retorno = this.color;

            return retorno;
        }

        public short GetTinta()
        {
            short retorno;
            retorno = this.tinta;

            return retorno;
        }

        private void SetTinta(short tinta)
        {
            int resultado = GetTinta() + tinta;
            
            if(resultado <=cantidadTintaMaxima && resultado >=0 )
            {
               this.tinta = (short)(resultado);
            }else 
            if(resultado<=0)
            {
                this.tinta = 0;
            }else if(resultado >=100)
            {
                this.tinta = cantidadTintaMaxima; 
            }

        }

        private void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder retorno = new StringBuilder();
            int acum = 0;

            if (GetTinta() > 0)
            {


                while(GetTinta()>0 && acum != gasto)
                {
                    retorno.Append("*");
                    SetTinta((short)(-1));
                    acum++;     
                }
            
                dibujo = retorno.ToString();
                return true;
            }
            else
            {
                dibujo = retorno.ToString();
                return false;
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        static Random ramd;

         static Alumno()
        {
            ramd = new Random();
            
        }

        public void CalcularFinal()
        {
           
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = ramd.Next(4,10);
            }else
            {
               notaFinal = -1;
            }

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("***************************************\n");
            retorno.AppendFormat("Alumno: {0}\n", this.apellido);
            retorno.AppendFormat("Legajo: {0}\n", this.legajo);
            retorno.AppendFormat("Nota1: {0} y nota2: {1}\n", this.nota1, this.nota2);

            CalcularFinal();
            if (notaFinal != -1)
                retorno.AppendFormat("Nota final: {0}", this.notaFinal);
            else
                retorno.AppendFormat("Alumno desaprobado");

            return retorno.ToString();



        }
    }
}

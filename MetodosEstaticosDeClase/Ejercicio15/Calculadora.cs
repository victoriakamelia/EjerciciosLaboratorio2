using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static int Calcular(int numero1, int numero2, string operador)
        {
            int resultado=default;

            switch(operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                   
                    break;
                case "-":
                    resultado = numero1 - numero2;
                   
                    break;
                case "*":
                    resultado = numero1 * numero2;
            
                    break;
                case "/":
                    if(!Validar(numero2))
                    {
                        resultado = 0;
                    }else
                    {
                        resultado = numero1 / numero2;  
                    }
                   
                    break;
                
            }

            return resultado;
        }

        private static bool Validar(int numero)
        {
            if(numero!=0)
            {
                return true;
            }else
            {
                return false;
            }
        }

    }
}

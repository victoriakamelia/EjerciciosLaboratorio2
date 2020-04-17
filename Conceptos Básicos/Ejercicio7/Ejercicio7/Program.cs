using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio, mes, dia;
            int anioactual, mesactual, diaactual;
            int diasanio = 0;
            int acumDias = 0;
            int acumDiasAct = 0;           

            Console.WriteLine("Ingrese año de nacimiento");
            Int32.TryParse(Console.ReadLine(), out anio);

            Console.WriteLine("Ingrese mes de nacimiento");
            Int32.TryParse(Console.ReadLine(), out mes);

            Console.WriteLine("Ingrese dia de nacimiento");
            Int32.TryParse(Console.ReadLine(), out dia);

            anioactual = DateTime.Now.Year;
            mesactual = DateTime.Now.Month;
            diaactual = DateTime.Now.Day;

            for (int i = anio; i < anioactual; i++)
            {
                if (i % 4 == 0 || (i % 100 == 0 && i % 400 == 0))
                {
                    diasanio = diasanio + 366;
                } else { 
                    diasanio = diasanio + 365;
                }
            }

            acumDias = dia;
            for(int j = 1; j < mes; j++)
            {
                switch (j)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        acumDias = acumDias + 30;
                        break;
                    case 2:
                        if (anio % 4 == 0 || (anio % 100 == 0 && anio % 400 == 0))
                        {
                            acumDias = acumDias + 29;
                        }else
                        {
                            acumDias = acumDias + 28;
                        }
                        break;
                    default:
                        acumDias = acumDias + 31;
                        break;

                }
            }

            acumDiasAct = diaactual;
            for (int k = 1; k < mesactual; k++)
            {
                switch (k)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        acumDiasAct = acumDiasAct + 30;
                        break;
                    case 2:
                        if (anioactual % 4 == 0 || (anioactual % 100 == 0 && anioactual % 400 == 0))
                        {
                            acumDiasAct = acumDiasAct + 29;                            
                        }
                        else
                        {
                            acumDiasAct = acumDiasAct + 28;
                        }
                        break;
                    default:
                        acumDiasAct = acumDiasAct + 31;
                        break;
                }
            }
 
            Console.WriteLine(diasanio-acumDias+acumDiasAct);
        
            Console.ReadKey();

            /*         
             int anio, mes, dia;
             DateTime fechanac;

             TimeSpan dias;

             Console.WriteLine("Ingrese año de nacimiento");
             Int32.TryParse(Console.ReadLine(),out anio); 

             Console.WriteLine("Ingrese mes de nacimiento");
             Int32.TryParse(Console.ReadLine(), out mes);

             Console.WriteLine("Ingrese dia de nacimiento");
             Int32.TryParse(Console.ReadLine(), out dia);

             fechanac = new DateTime(anio, mes, dia, 0, 0, 0);

             DateTime fechaactual = DateTime.Now;

             dias = fechaactual.Subtract(fechanac);

             Console.WriteLine(dias.Days);
             Console.ReadKey();*/           
        }
    }
}

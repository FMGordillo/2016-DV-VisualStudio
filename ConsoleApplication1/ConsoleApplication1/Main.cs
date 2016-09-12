using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoMartinGordillo
{
    class MainClass
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                "¿Qué programa quiere ejecutar?" + Environment.NewLine +
                "1. EJERCICIO 1" + Environment.NewLine +
                "2. EJERCICIO 2" + Environment.NewLine +
                "3. EJERCICIO 3" + Environment.NewLine
                );
            bool a = false;
            int inputNum = TP2_01.pedirValorNumerico();
            do
            {
                switch (inputNum)
                {
                    case 1:
                        TP2_01.tp02_01();
                        a = false;
                        break;
                    case 2:
                        a = false;
                        break;
                    case 3:
                        a = false;
                        break;
                    default:
                        a = true;
                        break;
                }

            } while (a == true);

            Console.Read(); //Tiempo muerto, antes de finalizar

        }
    }
}

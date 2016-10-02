using ConsoleApplication1;
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
            int inputNum;
            string nuevoPrograma = 
                "¿Qué programa quiere ejecutar?" + Environment.NewLine +
                "0. TP 001 (el primero de todos)" + Environment.NewLine +
                "1. TP 01" + Environment.NewLine +
                "2. TP 02" + Environment.NewLine +
                "3. NINGUNO, ME QUIERO IR" + Environment.NewLine;

            string tp02 =
                "¿Qué ejercicio?" + Environment.NewLine +
                "1." + Environment.NewLine +
                "2." + Environment.NewLine;

            string wrong = "Ingresaste un valor inválido." + Environment.NewLine;

            string despedida = "¡Muchas gracias por jugar un rato conmigo!" + Environment.NewLine +
                "** Presione cualquier tecla para salir.";

            bool a = false;
            do
            {
                Console.WriteLine(nuevoPrograma);
                inputNum = ResourcesFacu.pedirValorNumerico();
                switch (inputNum)
                {
                    case 0:
                        Console.WriteLine();
                        TP0 tp0 = new TP0();
                        break;
                    case 1:
                        Console.WriteLine(tp02);
                        inputNum = ResourcesFacu.pedirValorNumerico();
                        bool f = false;
                        do
                        {
                            switch (inputNum)
                            {
                                case 1:
                                    TP2_01.tp02_01();
                                    f = false;
                                    break;
                                case 2:
                                    //TP2_02 tp02 = new TP2_02();
                                    f = false;
                                    break;
                                default:
                                    Console.WriteLine(wrong);
                                    f = true;
                                    break;
                            }
                        } while (f == true);

                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 2:
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 3:
                        Console.WriteLine(despedida);
                        a = false;
                        break;
                    default:
                        Console.WriteLine(wrong);
                        a = true;
                        break;
                }

            } while (a == true);

            Console.Read(); //Tiempo muerto, antes de finalizar

        }
    }
}

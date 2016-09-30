using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TP0
    {
        string bienvenida = "¡Bienvenido/a al primer TP!";
        string decisionesPrincipales = "¿Qué querés hacer?" + Environment.NewLine +
            "1. Mostrar mi nombre y mi apellido" + Environment.NewLine +
            "2. Mostrar mi nombre y si soy mayor de edad" + Environment.NewLine + 
            "3. Sumame todos los números (desde el inicio del programa hasta ahora)" + Environment.NewLine + 
            "4. Encontrame el Máximo Común Divisor" + Environment.NewLine +
            "5. Calculame el promedio de todos los números que te meta." + Environment.NewLine + 
            "6. Salir";

        List<int> listaNumeros;

        bool a = false;
        int decision;

        public TP0()
        {
            Console.WriteLine(bienvenida);
            Console.WriteLine(decisionesPrincipales);
            do
            {
                decision = ResourcesFacu.pedirValorNumerico();
                switch (decision)
                {
                    case 1:
                        opcionUno();
                        a = true;
                        break;
                    case 2:
                        Console.WriteLine("En tu pais, ¿a partir de qué edad" +
                            "se considera a alguien mayor de edad?");
                        int max = ResourcesFacu.pedirValorNumerico();
                        opcionDos(max);
                        listaNumeros.Add(max); // ADD
                        a = true;
                        break;
                    case 3:
                        opcionTres();
                        break;
                    case 4:
                        opcionCuatro();
                        break;
                    case 5:
                        opcionCinco();
                        break;
                    case 6:
                        a = false;
                        break;
                    default:
                        a = false;
                        continue;
                }

            } while (a == false);
            
        }

        void opcionUno()
        {
            Console.WriteLine("Ingrese nombre:");
            string nombre = ResourcesFacu.pedirValor();
            Console.WriteLine("Ingrese apellido:");
            string apellido = ResourcesFacu.pedirValor();
            Console.WriteLine(
                "Tu nombre es: " + nombre + " " + apellido);
        }
        void opcionDos(int edadMax)
        {
            Console.WriteLine("Ingrese nombre:");
            string nombre = ResourcesFacu.pedirValor();
            Console.WriteLine("Ingrese edad:");
            int edad = ResourcesFacu.pedirValorNumerico();
            listaNumeros.Add(edad); // ADD
            if(edad <= edadMax)
            {
                Console.WriteLine("Sos menor de edad");
            }
            else
            {
                Console.WriteLine("Feliz legalidad, sos mayor de edad");
            }

        }
        void opcionTres()
        {
            Console.WriteLine("Ingresá un número, para sumar a la lista:");
            int final = ResourcesFacu.pedirValorNumerico();
            listaNumeros.Add(final);

        }
        void opcionCuatro()
        {

        }
        void opcionCinco()
        {

        }
    }
}

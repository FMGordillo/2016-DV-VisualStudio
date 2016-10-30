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

        List<int> listaNumeros = new List<int>();

        static bool a = false;
        int decision;

        public TP0()
        {
            do
            {
                Console.WriteLine(bienvenida);
                Console.WriteLine(decisionesPrincipales);

                decision = ResourcesFacu.pedirValorNumerico();
                switch (decision)
                {
                    case 1:
                        opcionUno();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 2:
                        Console.WriteLine("En tu pais, ¿a partir de qué edad" +
                            "se considera a alguien mayor de edad?");
                        int max = ResourcesFacu.pedirValorNumerico();
                        opcionDos(max);
                        listaNumeros.Add(max); // ADD
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 3:
                        opcionTres();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 4:
                        opcionCuatro();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 5:
                        opcionCinco();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 6:
                        a = false;
                        break;
                    default:
                        a = true;
                        continue;
                }

            } while (a == true);
            
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
            if(edad < edadMax)
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
            Console.WriteLine("Hasta ahora, el array es de: " + listaNumeros.Count
                + " elementos, y los números que listan son: ");
            foreach(int i in listaNumeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("La sumatoria es de: " + listaNumeros.Sum());
        }
        int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        void opcionCuatro()
        {
            Console.WriteLine("Por favor, ingrese un valor. (¡NO INGRESE CERO!)");
            int a = ResourcesFacu.pedirValorNumerico();
            Console.WriteLine("Ahora ingrese otro valor.");
            int b = ResourcesFacu.pedirValorNumerico();
            int resultado = GCD(a, b);
            Console.WriteLine("El mínimo común divisor de " + a + " es: " + resultado);
        }
        void opcionCinco()
        {
            List<int> listaLoca = new List<int>();
            System.Text.StringBuilder textoFinal = new System.Text.StringBuilder();

            Console.WriteLine("Escribí los números para calcular el promedio, y pulsa ENTER.");
            Console.WriteLine(" Para frenar, ingresá 0 + ENTER");

            int valor = ResourcesFacu.pedirValorNumerico();

            while(valor != 0)
            {
                listaLoca.Add(valor);
                valor = ResourcesFacu.pedirValorNumerico();
            }
            foreach (int i in listaLoca)
            {
                textoFinal.Append(i).Append(", ");
            }
            Console.WriteLine("Los números que ingresaste fueron:" + 
                Environment.NewLine + textoFinal.ToString());
            Console.WriteLine("Y el promedio es de: " + listaLoca.Average());

        }
    }
}

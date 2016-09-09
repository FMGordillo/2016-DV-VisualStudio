using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoMartinGordillo
{
    class TP2
    {
        static string equivocado = "VALOR ERRÓNEO, POR FAVOR INGRESE UN NUEVO VALOR." + Environment.NewLine;

        public static int pedirValorNumerico()
        {
            int valorNumerico;
            string valor = Console.ReadLine();
            Int32.TryParse(valor, out valorNumerico);
            return valorNumerico;
        }

        static void Main(string[] args)
        {
            
            string bienvenida = "¡Ahora puede calcular el área y el perímetro de una de las siguientes formas geométricas!" + Environment.NewLine
                + "Por favor ingrese un valor." + Environment.NewLine 
                + "*** 1: Calcular cuadrado" + Environment.NewLine
                + "*** 2: Calcular triangulo" + Environment.NewLine
                + "*** 3: Calcular circulo" + Environment.NewLine;

            bool a = false;
            do
            {
                Console.WriteLine(bienvenida);
                int inputNum = pedirValorNumerico();
                switch (inputNum)
                {
                    case 1:
                        CalculoCuadrado cuadrado = new CalculoCuadrado();
                        a = false;
                        break;
                    case 2:
                        CalculoTriangulo triangulo = new CalculoTriangulo();
                        a = false;
                        break;
                    case 3:
                        CalculoCirculo circulo = new CalculoCirculo();
                        a = false;
                        break;
                    default:
                        Console.WriteLine(equivocado);
                        a = true;
                        continue;
                }
            } while (a == true);
            
            
        }

        interface CalculoForma
        {
            float calcularArea();
            float calcularPerimetro();
        }

        class CalculoCirculo : CalculoForma
        {
            public float calcularArea()
            {
                throw new NotImplementedException();
            }

            public float calcularPerimetro()
            {
                throw new NotImplementedException();
            }
        }
        class CalculoCuadrado : CalculoForma
        {
            public float calcularArea()
            {
                throw new NotImplementedException();
            }

            public float calcularPerimetro()
            {
                throw new NotImplementedException();
            }
        }
        class CalculoTriangulo : CalculoForma
        {
            int opcion;
            int decision;
            public CalculoTriangulo()
            {
                bool sigue = true;

                string valoresDiferentes = 
                    "1: Triángulo Equilátero" + Environment.NewLine +
                    "2: Triángulo Isósceles" + Environment.NewLine +
                    "3: Triángulo Escaleno";
                string valoresDiferentes2 =
                    "¿Qué quiere calcular?" + Environment.NewLine +
                    "1: ÁREA" + Environment.NewLine +
                    "2: PERÍMETRO" + Environment.NewLine;
                do
                {
                    Console.WriteLine(valoresDiferentes);
                    decision = pedirValorNumerico();
                    switch (decision)
                    {
                        case 1:
                            Console.WriteLine();
                            opcion = 1;
                            sigue = false;
                            break;
                        case 2:
                            Console.WriteLine();
                            opcion = 2;
                            sigue = false;
                            break;
                        case 3:
                            Console.WriteLine();
                            opcion = 3;
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }
                } while (sigue == true);


                do
                {
                    Console.WriteLine(valoresDiferentes2);
                    decision = pedirValorNumerico();
                    switch (decision)
                    {
                        case 1:
                            Console.WriteLine();
                            sigue = false;
                            break;
                        case 2:
                            Console.WriteLine();
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }

                } while (sigue == true);
            }

            public float calcularArea()
            {
                int a;
                int b;
                int c;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Por favor, ingrese uno de sus lados:");
                        a = pedirValorNumerico();
                        calcularArea(a);
                        break;
                    case 2:
                        Console.WriteLine("Por favor, ingrese uno de los lados (NO la base):");
                        a = pedirValorNumerico();
                        Console.WriteLine("Ahora ingrese la base:");
                        b = pedirValorNumerico();
                        calcularArea(a, b);
                        break;
                    case 3:
                        Console.WriteLine("Por favor, ingrese uno de los lados:");
                        a = pedirValorNumerico();
                        Console.WriteLine("Ahora, ingrese otra de los lados:");
                        b = pedirValorNumerico();
                        Console.WriteLine("Y por último, ingrese el lado restante:");
                        c = pedirValorNumerico();
                        calcularArea(a, b, c);
                        break;
                }
                return 440F;
            }

            private float calcularArea(int a)
            {
                throw new NotImplementedException();
            }
            private float calcularArea(int a, int b)
            {
                throw new NotImplementedException();
            }
            private float calcularArea(int a, int b, int c)
            {
                throw new NotImplementedException();
            }

            public float calcularPerimetro()
            {
                throw new NotImplementedException();
            }
        }

    }
}

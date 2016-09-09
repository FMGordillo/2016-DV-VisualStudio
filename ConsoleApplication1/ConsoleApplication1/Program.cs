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
        public static bool seguir(int a)
        {
            if(a == 1) { return true; }
            else { return false; }
        }

        static void Main(string[] args)
        {   
            string bienvenida = "¡Ahora puede calcular el área y el perímetro de una de las siguientes formas geométricas!" + Environment.NewLine
                + "Por favor ingrese un valor." + Environment.NewLine 
                + "*** 1: Calcular cuadrado" + Environment.NewLine
                + "*** 2: Calcular triangulo" + Environment.NewLine
                + "*** 3: Calcular circulo" + Environment.NewLine;
            string seguirTxt = "¿Quiere hacer otra consulta?";

            bool a = false;
            do
            {
                Console.WriteLine(bienvenida);
                int inputNum = pedirValorNumerico();
                switch (inputNum)
                {
                    case 1:
                        CalculoCuadrado cuadrado = new CalculoCuadrado();
                        Console.WriteLine(seguirTxt); // Tiempo muerto para ver resultado
                        a = seguir(pedirValorNumerico());
                        break;
                    case 2:
                        CalculoTriangulo triangulo = new CalculoTriangulo();
                        Console.WriteLine(seguirTxt); // Tiempo muerto para ver resultado
                        a = seguir(pedirValorNumerico());
                        break;
                    case 3:
                        CalculoCirculo circulo = new CalculoCirculo();
                        Console.WriteLine(seguirTxt); // Tiempo muerto para ver resultado
                        a = seguir(pedirValorNumerico());
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
            double calcularArea();
            double calcularPerimetro();
        }

        class CalculoCirculo : CalculoForma
        {
            public double calcularArea()
            {
                throw new NotImplementedException();
            }

            public double calcularPerimetro()
            {
                throw new NotImplementedException();
            }
        }
        class CalculoCuadrado : CalculoForma
        {
            public double calcularArea()
            {
                throw new NotImplementedException();
            }

            public double calcularPerimetro()
            {
                throw new NotImplementedException();
            }
        }
        class CalculoTriangulo : CalculoForma
        {
            int opcion;
            int decision;
            double respuestaTriangulo;
            public CalculoTriangulo() // ¡¡¡Constructor!!!
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
                            respuestaTriangulo = calcularArea();
                            if(respuestaTriangulo == 440F)
                            {
                                Console.WriteLine("Disculpa, pero si es un triángulo rectángulo, NO puede ser equilátero.");
                            }
                            else
                            {
                                Console.WriteLine("El área es " + respuestaTriangulo);
                            }
                            sigue = false;
                            break;
                        case 2:
                            respuestaTriangulo = calcularPerimetro();
                            Console.WriteLine("El perímetro es: " + respuestaTriangulo);
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }

                } while (sigue == true);
            }

            bool tricky = false;

            public double calcularPerimetro() // Heredada de Interfaz
            {
                int a;
                int b;
                int c;
                double respuesta = (Double)440;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Por favor, ingrese uno de sus lados:");
                        a = pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a);
                        break;
                    case 2:
                        Console.WriteLine("Por favor, ingrese uno de los lados iguales:");
                        a = pedirValorNumerico();
                        Console.WriteLine("Ahora ingrese el lado restante:");
                        b = pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a, b);
                        break;
                    case 3:
                        Console.WriteLine("Por favor, ingrese uno de los lados:");
                        a = pedirValorNumerico();
                        Console.WriteLine("Ahora, ingrese otra de los lados:");
                        b = pedirValorNumerico();
                        Console.WriteLine("Y por último, ingrese el lado restante:");
                        c = pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a, b, c);
                        break;
                }
                return respuesta;
            }
            private double calcularPerimetro(double a) // Equilatero
            {
                return a * 3;
            }
            private double calcularPerimetro(double a, double b) // Isosceles
            {
                return 2 * a + b;
            }
            private double calcularPerimetro(double a, double b, double c) // Escaleno
            {
                return a + b + c;
            }

            public double calcularArea() // Heredada de Interfaz
            {
                bool sigue = true;
                double a;
                double b;
                double respuesta = 440F;

                do
                {
                    Console.WriteLine(
                        "¿Es un triángulo rectángulo?" + Environment.NewLine +
                        "1: SI" + Environment.NewLine +
                        "2: NO" + Environment.NewLine);
                    decision = pedirValorNumerico();
                    switch (decision)
                    {
                        case 1:
                            Console.WriteLine("Entonces te pido uno de los catetos:");
                            a = (Double)pedirValorNumerico();
                            Console.WriteLine("Ahora te pido el otro cateto:");
                            b = (Double)pedirValorNumerico();
                            respuesta = calcularArea(a, b);
                            sigue = false;
                            break;
                        case 2:
                            Console.WriteLine("Entonces te pido la base:");
                            a = (Double)pedirValorNumerico();
                            Console.WriteLine("Ahora te pido la altura:");
                            b = (Double)pedirValorNumerico();
                            respuesta = (a * b) / 2;
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }

                } while (sigue == true);
                return respuesta;
            }
            public double calcularArea(double a, double b) // Rectángulo
            {
                if (!tricky)
                {
                    return (a * b) / 2;
                }
                return 440F;
            }
        }


        }

    }

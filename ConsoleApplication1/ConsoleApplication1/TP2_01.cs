using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace FacundoMartinGordillo
{
    class TP2_01
    {

        static bool a = false;

        static string equivocado = "VALOR ERRÓNEO, POR FAVOR INGRESE UN NUEVO VALOR." + Environment.NewLine;

        static string values =
                    "¿Qué quiere calcular?" + Environment.NewLine +
                    "1: ÁREA" + Environment.NewLine +
                    "2: PERÍMETRO" + Environment.NewLine +
                    "3: Salir" + Environment.NewLine;
        public TP2_01() //"CONSTRUCTOR"
        {
            string bienvenida = "¡Ahora puede calcular el área y el perímetro de una de las siguientes formas geométricas!" + Environment.NewLine
                + "Por favor ingrese un valor (con o sin coma). TODO SE CALCULA EN cm" + Environment.NewLine
                + "*** 1: Calcular cuadrado" + Environment.NewLine
                + "*** 2: Calcular triangulo" + Environment.NewLine
                + "*** 3: Calcular circulo" + Environment.NewLine;
            do
            {
                Console.WriteLine(bienvenida);
                int inputNum = ResourcesFacu.pedirValorNumerico();
                switch (inputNum)
                {
                    case 1:
                        new CalculoCuadrado();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 2:
                        new CalculoTriangulo();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
                        break;
                    case 3:
                        new CalculoCirculo();
                        Console.WriteLine(ResourcesFacu.getSeguirTxt()); // Tiempo muerto para ver resultado
                        a = ResourcesFacu.seguir(ResourcesFacu.pedirValorNumerico());
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
            int decision;

            public CalculoCirculo()
            {
                bool sigue = true;
                double respuestaCirculo;

                do
                {
                    Console.WriteLine(values);
                    decision = ResourcesFacu.pedirValorNumerico();
                    switch (decision)
                    {
                        case 1: //AREA
                            respuestaCirculo = calcularArea();
                            Console.WriteLine("El área es " + respuestaCirculo);
                            sigue = false;
                            break;
                        case 2: //PERIMETRO
                            respuestaCirculo = calcularPerimetro();
                            Console.WriteLine("El perímetro (circunferencia) es " + respuestaCirculo);
                            sigue = false;
                            break;
                        case 3: // Salir
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }

                } while (sigue == true);
            }
            public double calcularArea()
            {
                Console.WriteLine("Ingrese el radio:");
                int radio = ResourcesFacu.pedirValorNumerico();
                return Math.PI * (radio^2);
            }

            public double calcularPerimetro()
            {
                Console.WriteLine("Por favor ingrese el radio");
                int radio = ResourcesFacu.pedirValorNumerico();
                return Math.PI * (radio * 2);
            }
        }
        class CalculoCuadrado : CalculoForma
        {
            int decision;

            public CalculoCuadrado()
            {
                bool sigue = true;
                double respuestaCuadrado;
                do
                {
                    Console.WriteLine(values);
                    decision = ResourcesFacu.pedirValorNumerico();
                    switch (decision)
                    {
                        case 1: //AREA
                            respuestaCuadrado = calcularArea();
                            Console.WriteLine("El área es " + respuestaCuadrado);
                            sigue = false;
                            break;
                        case 2: //PERIMETRO
                            respuestaCuadrado = calcularPerimetro();
                            Console.WriteLine("El perímetro es " + respuestaCuadrado);
                            sigue = false;
                            break;
                        case 3: // Salir
                            sigue = false;
                            break;
                        default:
                            Console.WriteLine(equivocado);
                            sigue = true;
                            continue;
                    }

                } while (sigue == true);
            }
            public double calcularArea()
            {
                Console.WriteLine("Por favor, ingrese uno de sus lados:");
                int a = ResourcesFacu.pedirValorNumerico();
                return calcularArea(a);
            }

            public double calcularArea(int a)
            {
                return Math.Pow(a, 2);
            }

            public double calcularPerimetro()
            {
                Console.WriteLine("Por favor, ingrese uno de sus lados:");
                int a = ResourcesFacu.pedirValorNumerico();
                return calcularPerimetro(a);
            }

            public double calcularPerimetro(int a)
            {
                return a * 4;
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
                    "3: Triángulo Escaleno" + Environment.NewLine +
                    "4: Salir";
                do
                {
                    Console.WriteLine(valoresDiferentes);
                    decision = ResourcesFacu.pedirValorNumerico();
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
                        case 4: // Salir
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
                    Console.WriteLine(values);
                    decision = ResourcesFacu.pedirValorNumerico();
                    switch (decision)
                    {
                        case 1: //AREA
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
                        case 2: // PERIMETRO
                            respuestaTriangulo = calcularPerimetro();
                            Console.WriteLine("El perímetro es: " + respuestaTriangulo);
                            sigue = false;
                            break;
                        case 3: // Salir
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
                        a = ResourcesFacu.pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a);
                        break;
                    case 2:
                        Console.WriteLine("Por favor, ingrese uno de los lados iguales:");
                        a = ResourcesFacu.pedirValorNumerico();
                        Console.WriteLine("Ahora ingrese el lado restante:");
                        b = ResourcesFacu.pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a, b);
                        break;
                    case 3:
                        Console.WriteLine("Por favor, ingrese uno de los lados:");
                        a = ResourcesFacu.pedirValorNumerico();
                        Console.WriteLine("Ahora, ingrese otra de los lados:");
                        b = ResourcesFacu.pedirValorNumerico();
                        Console.WriteLine("Y por último, ingrese el lado restante:");
                        c = ResourcesFacu.pedirValorNumerico();
                        respuesta = (Double)calcularPerimetro(a, b, c);
                        break;
                    case 4:
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
                    decision = ResourcesFacu.pedirValorNumerico();
                    switch (decision)
                    {
                        case 1:
                            Console.WriteLine("Entonces te pido uno de los catetos:");
                            a = (Double)ResourcesFacu.pedirValorNumerico();
                            Console.WriteLine("Ahora te pido el otro cateto:");
                            b = (Double)ResourcesFacu.pedirValorNumerico();
                            respuesta = calcularArea(a, b);
                            sigue = false;
                            break;
                        case 2:
                            Console.WriteLine("Entonces te pido la base:");
                            a = (Double)ResourcesFacu.pedirValorNumerico();
                            Console.WriteLine("Ahora te pido la altura:");
                            b = (Double)ResourcesFacu.pedirValorNumerico();
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

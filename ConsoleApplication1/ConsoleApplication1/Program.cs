using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoMartinGordillo
{
    class TP2
    {

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
            string equivocado = "VALOR ERRÓNEO, POR FAVOR INGRESE UN NUEVO VALOR.";

            bool a = false;

            Console.WriteLine(bienvenida);
            int inputNum = pedirValorNumerico();

            do
            {
                switch (inputNum)
                {
                    case 1:
                        CalculoCuadrado cuadrado = new CalculoCuadrado();
                        break;
                    case 2:
                        CalculoTriangulo triangulo = new CalculoTriangulo(inputNum);
                        break;
                    case 3:
                        CalculoCirculo circulo = new CalculoCirculo();
                        break;
                    default:
                        Console.WriteLine(equivocado);
                        inputNum = pedirValorNumerico();
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
            public CalculoTriangulo(int decision)
            {
                switch(decision)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }

            public float calcularArea()
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

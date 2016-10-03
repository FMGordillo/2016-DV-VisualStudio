using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class ResourcesFacu
    {
        private static Random random = new Random();

        public static int pedirValorNumerico()
        {
            int valorNumerico;
            Int32.TryParse(pedirValor(), out valorNumerico);
            return valorNumerico;
        }

        public static string pedirValor()
        {
            return Console.ReadLine();
        }

        public static bool seguir(int a)
        {
            string muchasGracias =
                "¡Muchas gracias por usar nuestro software!";
            if (a == 1) { return true; }
            else
            {
                Console.WriteLine(muchasGracias);
                return false;
            }
        }

        public static String getSeguirTxt()
        {
            return "¿Quiere hacer otra consulta?" + Environment.NewLine +
                "1: SI" + Environment.NewLine +
                "OTRA TECLA: NO" + Environment.NewLine;
        }

        public static String generarRandomText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int generarRandomInt(int length)
        {
            string s = string.Empty;
            for (int i = 0; i < length; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
                return s;
        }
    }
}

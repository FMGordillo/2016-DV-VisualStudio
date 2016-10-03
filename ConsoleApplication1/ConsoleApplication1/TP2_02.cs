using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacundoMartinGordillo.TP2_02;

namespace FacundoMartinGordillo
{
    class TP2_02 :IMotor, IRuedas, ICajaDeCambios //Asumamos que es VEHÍCULO
    {
        public TP2_02()
        {
                
        }

        public int cilindros
        {
            get
            {
                return cilindros;
            }

            set
            {
                cilindros = ConsoleApplication1.ResourcesFacu.generarRandomInt(1);
            }
        }

        public bool isManual
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int cantidadCambios
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int diametro
        {
            get
            {
                return diametro;
            }

            set
            {
                diametro = ConsoleApplication1.ResourcesFacu.generarRandomInt(1);
            }
        }

        internal interface IMotor
        {
            int cilindros { get; set; }
            void iniciar();
            void frenar();

        }
        internal interface IRuedas
        {
            int diametro{ get; set; }
            void iniciar();
            void frenar();
        }
        internal interface ICajaDeCambios
        {
            bool isManual { get; set; }
            int cantidadCambios { get; set; }
        }

        public void iniciar()
        {
            throw new NotImplementedException();
        }

        public void frenar()
        {
            throw new NotImplementedException();
        }
    }
}

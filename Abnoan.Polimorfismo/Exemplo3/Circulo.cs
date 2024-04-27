using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exemplo3
{
    public class Circulo : IFiguraGeometrica
    {
        private double raio;
        private double[] pontos; // Array interno para armazenar pontos

        public Circulo(double raio)
        {
            this.raio = raio;
            this.pontos = new double[0]; // Inicializar array vazio
        }

        public double Area
        {
            get { return Math.PI * raio * raio; }
        }

        public double Perimetro
        {
            get { return 2 * Math.PI * raio; }
        }

        public void CalcularArea()
        {            
        }

        public void CalcularPerimetro()
        {            
        }

        public event EventHandler AreaAlterada;
        public event EventHandler PerimetroAlterado;

        public double this[int indice]
        {
            get
            {
                if (indice < 0 || indice >= pontos.Length)
                {
                    throw new IndexOutOfRangeException("Índice fora do intervalo do array.");
                }

                return pontos[indice];
            }
            set
            {
                if (indice < 0 || indice >= pontos.Length)
                {
                    throw new IndexOutOfRangeException("Índice fora do intervalo do array.");
                }

                pontos[indice] = value;
            }
        }
    }
}
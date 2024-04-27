using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exemplo3
{
    public interface IFiguraGeometrica
    {
        // Propriedades
        double Area { get; }
        double Perimetro { get; }

        // Métodos
        void CalcularArea();
        void CalcularPerimetro();

        // Eventos
        event EventHandler AreaAlterada;
        event EventHandler PerimetroAlterado;

        // Indexadores
        double this[int indice] { get; set; }
    }
}
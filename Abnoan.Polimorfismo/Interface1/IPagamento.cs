using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Interface1
{
    public interface IPagamento
    {
        bool ProcessarPagamento(decimal valor);
    }
}
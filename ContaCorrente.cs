using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaheranca
{
    public class ContaCorrente
    {
        private string numeroConta;
        private string titularConta;

        public string NumeroConta { get => numeroConta; set => numeroConta = value; }
        public string TitularConta { get => titularConta; set => titularConta = value; }
    }
}

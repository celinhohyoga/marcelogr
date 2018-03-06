using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Fornecedor : Pessoa
    {
        public static implicit operator Fornecedor(Fornecedor v)
        {
            throw new NotImplementedException();
        }
    }
}

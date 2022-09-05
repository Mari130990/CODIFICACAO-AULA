using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC9_ENTROCO_REMOTO_2.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC9_ENTROCO_REMOTO_2.Interfaces;

namespace UC9_ENTROCO_REMOTO_2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {


        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float redimento)
        {
            if (redimento <= 1500)
            {
                return 0;


            }
            else if (redimento > 1500 && redimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;

                return resultado;
            }
            else if (redimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;

                return resultado;

            }
            else

            {
                float resultado = (rendimento / 100) * 5f;

                return resultado;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}

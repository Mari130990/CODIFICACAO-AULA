using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC9_ENTROCO_REMOTO_2.Interfaces;

namespace UC9_ENTROCO_REMOTO_2.Classes
{
    public class PessoaJuridica : Pessoa ,  IPessoaJuridica
    {

        public string? cnpj { get; set; }

        public string? razaosocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f;
            }





            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05f;

            }
            else if (rendimento <= 10000)
            {

                return rendimento * 0.07f;
            }
            else
            {
                return rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }

}
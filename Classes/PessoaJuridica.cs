using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UC9_ENTROCO_REMOTO_2.Interfaces;

namespace UC9_ENTROCO_REMOTO_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? cnpj { get; set; }

        public string? razaosocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

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

            bool returnCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{14})|(\{2}.\d{3}.\d{3}/\d{4}-\d{2})$)");

            if (cnpj.Length == 14)


                if (returnCnpjValido)
                {


                    if (cnpj.Length == 14)
                    {
                        string subStringCnpj14 = cnpj.Substring(8, 4);

                        if (subStringCnpj14 == " 0001")
                        {
                            return true;
                        }
                        return false;


                    }
                }

            string subStringCnpj18 = cnpj.Substring(11, 4);

            if (subStringCnpj18 == "0001")
            {
                return true;
            }

            return false;

        }
        public void inserir(PessoaJuridica pj)
        {
            Utils.verificarPastaArquivo(caminho);

            string[] pjValores = { $"{pj.nome},{pj.cnpj},{pj.razaosocial}" };

            File.AppendAllLines(caminho, pjValores);
        }

        public List<PessoaJuridica> LerArquivo()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica novaPj = new PessoaJuridica();

                novaPj.nome = atributos[0];
                novaPj.cnpj = atributos[1];
                novaPj.razaosocial = atributos[2];

                listaPj.Add(novaPj);
            }
            return listaPj;
        }
    }



}































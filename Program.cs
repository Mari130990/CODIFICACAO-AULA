// See https://aka.ms/new-console-template for more information
using UC9_ENTROCO_REMOTO_2.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
List<PessoaFisica> listPf = new List<PessoaFisica>();
PessoaJuridica metodosPj = new PessoaJuridica();

Console.Clear();
Console.WriteLine(@$"
 =======================================
 | Bem vindo ao sistema de cadastro de |
 |      Pessoa Fisisca e Juridicas     |
 =======================================
");

Utils.BarraCarregamento("Carregando", 10, ".", 200);
string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
========================================
|      Escolha uma das Opções abaixo   |
|--------------------------------------|
|        1-Pessoa Fisica               |
|        2- Pessoa Juridica            |
|                                      |
|        0- Para Sair                  |
========================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
              
          ========================================
          |      Escolha uma das Opções abaixo   |
          |--------------------------------------|
          |        1-Cadastar Pessoa Fisica      |
          |        2- Lista Pessoas Fisica       |
          |                                      |
          |        0- Voltar ao menu anterior    |
           ========================================
           ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.WriteLine($"Digite o nome da pessoa Fisica que deseja cadastar");


                        Endereco novoEndPf = new Endereco();

                        novaPf.nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"digite a da de nascimento Ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();
                            dataValida = novaPf.ValidarDataNasc(dataNascimento);

                            if (!dataValida)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inalida, por favor digite novamente");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataCovertida);
                                novaPf.dataNasc = dataCovertida;

                            }


                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mesnal(Digite somente números");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento(Aperte enterpara vazio)");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endererço é comercial? S/N");
                        string endCom = Console.ReadLine().ToLower();

                        if (endCom == "S")
                        {

                            novoEndPf.endComplemento = true;

                        }
                        else
                        {
                            novoEndPf.endComplemento = false;


                        }

                        novaPf.endereco = novoEndPf;

                        // listPf.Add(novaPf);

                        //StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                        //sw.WriteLine(novaPf.nome);
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(novaPf.nome);
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"O cadastro foi realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":
                        Console.Clear();

                        if (listPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPf in listPf)

                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPf.nome}
Endereço: {cadaPf.endereco.Logradouro}, {cadaPf.endereco.numero}
Maior de idade:{cadaPf.dataNasc.ToString("d")}
Imposto a ser pago{metodosPf.CalcularImposto(cadaPf.rendimento).ToString("C")}
  ");

                                Console.WriteLine($"Aperte Enter para continuar");
                                Console.ReadLine();
                            }

                        }

                        else
                        {
                            Console.WriteLine($"Lista Vazia");
                            Thread.Sleep(2000);
                        }

                        using (StreamReader sr = new StreamReader("Mariana.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($" {linha} ");
                            }
                        }
                        Console.WriteLine($"Aperte o 'Enter' para continuar...");
                        Console.ReadLine();
                        break;

                    case "0":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Voltando ao menu anterior");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"opção iválida, por favor digite uma opção valida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;


                }


            } while (opcaoPf != "0");


            Console.Clear();

            //Console.WriteLine(@$"




            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();


            novaPj.nome = "Nome Pj";
            novaPj.razaosocial = "Razão Social";
            novaPj.cnpj = "62.401.115/0001-40";
            novaPj.rendimento = 6000.5f;

            novoEndPj.Logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.endComplemento = true;

            novaPj.endereco = novoEndPj;

            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPj.nome}
            //Razão Social : {novaPj.razaosocial}
            // CNPJ: {novaPj.cnpj} - Valido: {(novaPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}

            // ");

            metodosPj.inserir(novaPj);

            List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaExibicaoPj)
            {
                //      Console.Clear();
                //        Console.WriteLine(@$"
                //       Nome: {novaPj.nome}
                //      Razão Social : {novaPj.razaosocial}
                //       CNPJ: {novaPj.cnpj} - Valido: {(novaPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}

                //      ");

                metodosPj.inserir(novaPj);

                List<PessoaJuridica> listaExibicaoPJ = metodosPj.LerArquivo();

                foreach (PessoaJuridica CadaItem in listaExibicaoPj)
                {
                    Console.Clear();
                    Console.WriteLine(@$"
                 Nome: {cadaItem.nome}
                Razão Social : {cadaItem.razaosocial}
                 CNPJ: {cadaItem.cnpj} - Valido: {(cadaItem.ValidarCnpj(cadaItem.cnpj) ? "Sim" : "Não")}

                 ");
                }
            }

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            break;

        case "0":


            Console.WriteLine($"obrigado por utilizar nosso sistema");

            Utils.BarraCarregamento("Finalizando", 5, "+", 500);


            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"opção iválida, por favor digite uma opção valida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");



//PessoaFisica novaPf = new PessoaFisica();

Console.WriteLine("Hello, World!");


novaPf.nome = "Mariana";

novaPf.cpf = "123456789";
DateTime temp = new DateTime(2000, 01, 01);


Console.WriteLine(novaPf.ValidarDataNasc(temp));


((UC9_ENTROCO_REMOTO_2.Interfaces.IPessoaFisica)novaPf).ValidarDataNasc(temp);

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - cpf:" + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} - CPF:{novaPf.cpf}");




float impostoPagar = novaPf.CalcularImposto(1600);
Console.WriteLine(impostoPagar);


// Console.WriteLine(((UC9_ENTROCO_REMOTO_2.Interfaces.IPessoaJuridica)novaPj).ValidarCnpj("62401115000145"));

//  novaPj.CalcularImposto(6600.5f);

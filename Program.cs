// See https://aka.ms/new-console-template for more information
using UC9_ENTROCO_REMOTO_2.Classes;

    PessoaFisica novaPf = new PessoaFisica();
    
        Console.WriteLine("Hello, World!");


        novaPf.nome = "Mariana";

        novaPf.cpf = "123456789";

        Console.WriteLine(novaPf.nome);

        Console.WriteLine("Nome: " +  novaPf.nome + " - cpf:" + novaPf.cpf);
        Console.WriteLine($"Nome: {novaPf.nome} - CPF:{novaPf.cpf}");
  
   float impostoPagar = novaPf.CalcularImposto(1600);
   Console.WriteLine(impostoPagar);

  PessoaJuridica novaPj = new PessoaJuridica();
  novaPj.CalcularImposto (6600.5f);

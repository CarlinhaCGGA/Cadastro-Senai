using Cadastro.Classes;

Console.WriteLine(@"Escolha uma das opções abaixo: 
1 - Cadastrar PJ 
2 - Sair do sistema");
string opcao = Console.ReadLine()!;

PessoaJuridica metodo = new PessoaJuridica();

if(opcao == "1"){
PessoaJuridica pessoaj = new PessoaJuridica();

Console.WriteLine("Informe o nome da pj:");
pessoaj.Nome = Console.ReadLine();

Console.WriteLine("Informe o rendimento da pj:");
pessoaj.Rendimento = float.Parse(Console.ReadLine()!);

Console.WriteLine("Informe seu CNPJ:");
pessoaj.CNPJ = Console.ReadLine();


metodo.Inserir(pessoaj);
Console.WriteLine("Showw, pj cadastrado com sucessoooooo! :p");

}else if(opcao == "2"){
      Console.WriteLine("Sistema encerrado com sucesso!");
}else{
    Console.WriteLine("Eai digitou a opção errada, mané :P");
}






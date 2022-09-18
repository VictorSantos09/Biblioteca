using Trabalho_Biblioteca;

IsEmpty empty = new IsEmpty();
Livro livro = new Livro();
Random random = new Random();

//string teste = "sa"; teste = teste + "";  CTRL KC + CTRL KU

bool userUsing = true;
while (userUsing)
{

    Console.WriteLine("Bem vindo!\n");
    Console.WriteLine("O que deseja fazer?\n1 - Cadastrar novo livro\n2 - Alugar livro\n3 - Devolver do livro\n4 - Ver estoque\n5 - Sair ");
    string userInputChoice = Console.ReadLine();
    userInputChoice = empty.Empty(userInputChoice);
    if (userInputChoice == "1")
    {
        Console.Clear();
        livro.CadastroLivro();
    }
    if (userInputChoice == "2")
    {
        Console.Clear();
        livro.LocarLivro();
    }
    if (userInputChoice == "3")
    {
        livro.DevolverLivro();
        Console.Clear();
    }
    if (userInputChoice == "4")
    {
        Console.Clear();
        livro.Estoque();
    }
    if (userInputChoice == "5")
    {
        Console.WriteLine("Encerrando...");
        userUsing = false;
    }
}
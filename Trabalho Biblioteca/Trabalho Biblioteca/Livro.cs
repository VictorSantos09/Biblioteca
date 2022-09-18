using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Biblioteca
{
    public class Livro
    {
        IsEmpty isEmpty = new IsEmpty();
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
        public string LivroAlugado { get; set; }
        public int LivrosLocados { get; set; }
        public int LivrosQuantidade { get; set; }
        public int LivroRestante { get; set; }

        public void CadastroLivro()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do livro");
            Nome = Console.ReadLine();
            Nome = isEmpty.Empty(Nome);
            Console.WriteLine("Digite a categoria do livro");
            Categoria = Console.ReadLine();
            Categoria = isEmpty.Empty(Categoria);
            Console.WriteLine("Digite o autor do livro");
            Autor = Console.ReadLine();
            Autor = isEmpty.Empty(Autor);
            Console.WriteLine($"{Nome} Cadastrado com sucesso");
        }
        public void DevolverLivro()
        {
            Console.Clear();
            LivrosLimite();
            Console.WriteLine("Digite quantos livros deseja devolver");
            LivrosQuantidade = Convert.ToInt32(Console.ReadLine());
            LivrosQuantidade = isEmpty.EmptyINT(LivrosQuantidade);
            Console.WriteLine($"{LivrosQuantidade} Devolvidos!\n");
        }
        public void LocarLivro()
        {
            Console.Clear();
            if (LivrosLimite())
            {
                Console.WriteLine("Digite o nome do livro desejado:");
                LivroAlugado = Console.ReadLine();
                LivroAlugado = isEmpty.Empty(LivroAlugado);
                if (LivroAlugado == Nome)
                {
                    Console.WriteLine($"Livro {Nome} Alugado!\n");
                    LivrosLocados++;
                    Console.WriteLine($"Livros Alugados: {LivrosLocados}");
                }
                else
                {
                    Console.WriteLine("Livro não encontrado\n");
                }
            }
        }
        public bool LivrosLimite()
        {
            Console.Clear();
            LivroRestante = 3 - LivrosLocados;
            Console.WriteLine($"Você pode alugar no máximo 3 livros");
            Console.WriteLine($"Livros alugados {LivrosLocados} | Livros Restantes: {LivroRestante}");

            if (LivrosLocados == 3)
            {
                Console.WriteLine("Você alugou o maximo permitido");
                return false;
            }
            if (LivrosLocados >= 3)
            {
                Console.WriteLine("Limite atingido, devolva para liberar");
                return false;
            }
            return true;
        }
        public void Estoque()
        {
            Console.Clear();
            Random random = new Random();
            int rand = random.Next(55, 643);
            Console.WriteLine($"Livros disponiveis em estoque: {rand}");
        }
    }
}

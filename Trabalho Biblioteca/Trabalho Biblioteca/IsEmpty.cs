using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Biblioteca
{
    public class IsEmpty
    {
        public string Empty(string input)
        {
            while (input == string.Empty)
            {
                Console.WriteLine("Digite algo");
                input = Console.ReadLine();
            }
                return input;
        }
        public int EmptyINT(int input)
        {
            while (input == 0)
            {
                Console.WriteLine("Digite algo");
                input =  Convert.ToInt32 (Console.ReadLine());
            }
            return input;
        }
    }
}

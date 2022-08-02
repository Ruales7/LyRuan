using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um objetro p, do tipo da classe Pessoa1
            Pessoa1 p = new Pessoa1();

            //Exibindo na tela informaçôes do objeto p,
            //realizando uma chamada no método ToString
            Console.WriteLine(p.ToString());

            //Atribuindo um nome ao objetop, por meio da propriedade nome
            p.Nome = "Neymar";

            //Exibindo na tela informações do objeto p,
            //após a atribuição do nome
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}

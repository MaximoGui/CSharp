using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade, então pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor de idade, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João é menor de idade, então não pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}

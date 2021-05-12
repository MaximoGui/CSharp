using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cliente guilherme = new Cliente();

            guilherme.nome = "Guilherme";
            guilherme.cpf = "123.321.123-12";
            guilherme.profissao = "Desenvolvedor";*/

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = guilherme;

            conta.titular = new Cliente();
            conta.titular.nome = "Guilherme Máximo";
            conta.titular.cpf = "123.321.123-12";
            conta.titular.profissao = "Desenvolvedor";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //Console.WriteLine(guilherme.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}

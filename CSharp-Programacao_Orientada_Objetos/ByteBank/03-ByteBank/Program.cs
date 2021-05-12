using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJapa = new ContaCorrente();
            contaDoJapa.titular = "Guilherme";
            contaDoJapa.agencia = 333;
            contaDoJapa.numero = 333121;

            ContaCorrente contaDoJapones = new ContaCorrente();
            contaDoJapones.titular = "Guilherme";
            contaDoJapones.agencia = 333;
            contaDoJapones.numero = 333121;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoJapones == contaDoJapa));

            int idade = 21;
            int idadeMaisUmaVez = 21;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDoJapa = contaDoJapones;
            Console.WriteLine(contaDoJapa == contaDoJapones);

            contaDoJapa.saldo = 300;
            Console.WriteLine(contaDoJapa.saldo);
            Console.WriteLine(contaDoJapones.saldo);

            if (contaDoJapa.saldo >= 100)
            {
                contaDoJapa.saldo -= 100;
            }

            Console.ReadLine();

        }
    }
}

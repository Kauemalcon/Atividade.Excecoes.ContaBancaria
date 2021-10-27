using System;
using System.Globalization;
using Atividade.Exceções.ContaBancaria.Entitis;
namespace Atividade.Exceções.ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Entre com os dados da conta: ");
            Console.Write("Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Cliente: ");
            string cliente = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Instanciando a classe Conta
            Conta n = new Conta(numeroConta, cliente, saldo, saque);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            double  valorSaque = double.Parse(Console.ReadLine());

            try
            {
                //Chama o metodo de saque
                n.Saque(valorSaque);
                Console.WriteLine("Saldo Atual: "+ n.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(ApplicationException e)
            {
                //Aplicação do (Excepion.Message) usando e.message
                Console.WriteLine("Erro " + e.Message);
            }

        }
    }
}

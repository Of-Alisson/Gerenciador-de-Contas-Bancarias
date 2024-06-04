using System;

namespace Gerenciador
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Alisson Jose de Andrade Lima", "123.456.789.98");
            ContaC corrente1 = new ContaC("001", cliente1, 500);
            ContaP poupanca1 = new ContaP("002", cliente1, 0.01m); 

            corrente1.Depositar(1000); 
            corrente1.Sacar(200);
            corrente1.Transferir(300, poupanca1);

            poupanca1.JurosAplicado();
            poupanca1.Sacar(50);

            Console.WriteLine($"Saldo Conta Corrente: {corrente1.Saldo:C}");
            Console.WriteLine($"Saldo Conta Poupança: {poupanca1.Saldo:C}");

        }
    }
}
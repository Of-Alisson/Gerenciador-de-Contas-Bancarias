using System;

public abstract class Conta
{
    public string Numero { get; set; }
    public decimal Saldo{ get; protected set; }
    Cliente Cliente{ get; set; } 

     
     public Conta(string numero, Cliente cliente)

    {
        Numero = numero; 
        Cliente = cliente;
        Saldo = 0;
    } 

    public void Depositar(decimal valor)
    {
        if(valor > 0)
        {
            Saldo +=valor;
            Console.WriteLine($"\nDepósito de {Saldo} realizado com Sucesso!!!");
        }
        else
        {
            Console.WriteLine("Valor Inválido!!!");
        }
    }

    public virtual void Sacar(decimal valor)
    {
        if(valor > 0 && valor <=Saldo)
        {
            Saldo -= valor;

            Console.WriteLine($"\nSaque de {valor} Realizado com sucesso\n Saldo:{Saldo}");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente para Saque\nSaldo:{Saldo}");
        }
    }

    public void Transferir(decimal valor, Conta contaDestino)
    {
        if(valor > 0 && valor <= Saldo)
        {
            Sacar(valor);
            contaDestino.Depositar(Saldo);
            Console.WriteLine($"Transferência de {valor} realizada com sucesso!!\nSaldo: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Falha em realizar a transferência, verifique seu saldo, ou entre em contado com uma agência\n Saldo: {Saldo}");
        }
    }

}
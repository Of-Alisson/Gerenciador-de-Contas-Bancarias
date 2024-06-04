using System;

public class ContaC : Conta
{
    public decimal LimiteCheque { get; set; }

    public ContaC(string numero, Cliente cliente,decimal limiteChuque) : base(numero, cliente)
    {
        LimiteCheque = limiteChuque;
    }

    public override void Sacar(decimal valor)
    {
        if(valor > 0 && valor <= (Saldo + LimiteCheque))
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor}, da conta corrente realizado com Sucesso!!!\n Saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Saque indisponível\n Saldo:{Saldo}");
        }
    }
}

using System;

public class ContaP : Conta
{
    public decimal TaxaJuros{ get; set; }

    public ContaP(string numero, Cliente cliente, decimal taxajuros) : base(numero, cliente) 
    {
        TaxaJuros = taxajuros;
    }
    public void JurosAplicado()
    {
        decimal juros = Saldo * TaxaJuros;
        Saldo += juros;
        Console.WriteLine($"Juros: {juros}, Saldo em Conta: {Saldo}");
    }
}
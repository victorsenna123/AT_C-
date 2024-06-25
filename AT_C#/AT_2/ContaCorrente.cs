using System;

class ContaCorrente : Conta
{
    public ContaCorrente(decimal saldoInicial, decimal limiteInicial) : base(saldoInicial, limiteInicial) { }

    public override void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser positivo.");
        }
        Saldo += valor;
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do saque deve ser positivo.");
        }
        if (Saldo + Limite < valor)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        Saldo -= valor;
    }
}

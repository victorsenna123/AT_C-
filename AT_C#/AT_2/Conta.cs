using System;

abstract class Conta
{
    private decimal _saldo;
    private decimal _limite;

    public decimal Saldo
    {
        get { return _saldo; }
        protected set { _saldo = value; } // Somente leitura fora da classe e suas derivadas
    }

    public decimal Limite
    {
        get { return _limite; }
        set
        {
            if (value < 0)
                throw new ArgumentException("O limite não pode ser negativo.");
            _limite = value;
        }
    }

    public Conta(decimal saldoInicial, decimal limiteInicial)
    {
        Saldo = saldoInicial;
        Limite = limiteInicial;
    }

    public abstract void Depositar(decimal valor);
    public abstract void Sacar(decimal valor);
}

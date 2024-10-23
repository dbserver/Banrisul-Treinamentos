public class ContaBancaria
{ 
    public string Cliente { get; set; } = string.Empty; 
    public int NumConta { get; set; }
    public decimal Saldo { get; set; }

    public ContaBancaria(string cliente, int numConta, decimal saldo)
    {
        Cliente = cliente;
        NumConta = numConta;
        Saldo = saldo;
    }

    public virtual void Sacar(decimal valorsSaque)
    {
        if (valorsSaque <= Saldo)
        {
            Saldo -= valorsSaque;
        }
        else
        {
            throw new Exception("Saque não permitido.");
        }

    }

    public void Depositar(decimal valorDeposito)
    {
        Saldo += valorDeposito;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Cliente: {Cliente}");
        Console.WriteLine($"Número da Conta: {NumConta}");
        Console.WriteLine($"Saldo: R${Saldo:F2}");
    }
}



public class ContaPoupanca : ContaBancaria
{
    public int DiaRendimento { get; set; } = 0; 


    public ContaPoupanca(string cliente, int num_conta, decimal saldo, int diaRendimento) : base(cliente, num_conta, saldo)
    {
        DiaRendimento = diaRendimento;
    }

    public void CalculaNovoSaldo(decimal taxaRendimento)
    {
        Saldo = Saldo + (Saldo * (taxaRendimento / 100));
    }

}

public class ContaEspecial : ContaBancaria
{
    public decimal Limite {  get; set; }

    public ContaEspecial(string cliente, int num_conta, decimal saldo, decimal limite) : base(cliente, num_conta, saldo)
    {
        Limite = limite;
    }

    public override void Sacar(decimal valorSaque)
    {
        if(valorSaque > Saldo + Limite)
        {
            throw new Exception("Saque não disponível.");
        } else
        {
            Saldo -= valorSaque; 
        }
    }
}


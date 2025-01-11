int input = 0;

Banco banco = new Banco();

Console.WriteLine("Quanto quer despositar? ");
input = Convert.ToInt32(Console.ReadLine());

banco.deposito(input);

Console.WriteLine(banco.mostraValor);

public class Casa
    {
        public string endereço;
        public string cor;
    }

public class Carro 
    { 
        public string marca;
        public string cor;
    }

public class Banco
{
    private int dinheiro;

    public int deposito(int deposito)
    {
        return dinheiro += deposito;
    }

    public void mostraValor()
    {
        Console.WriteLine(dinheiro);
    }

}
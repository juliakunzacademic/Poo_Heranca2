namespace ReservasEspacos.Modelo;

public abstract class Espaco
{
    
    public string Identificacao { get; }
    public string Localizacao { get; }
    public int Capacidade { get; }

    public Espaco(string identificacao, string localizacao, int capacidade)
    {
        if (string.IsNullOrEmpty(identificacao))
            throw new ArgumentException("A identificação é obrigatória.", nameof(identificacao));

        if (string.IsNullOrEmpty(localizacao))
            throw new ArgumentException("A localização é obrigatória.", nameof(localizacao));

        if (capacidade <= 0)
            throw new ArgumentException("A capacidade deve ser maior que zero.", nameof(capacidade));

        Identificacao = identificacao;
        Localizacao = localizacao;
        Capacidade = capacidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Identificação: {Identificacao}");
        Console.WriteLine($"Localização: {Localizacao}");
        Console.WriteLine($"Capacidade: {Capacidade}");
    }

    public abstract decimal CalcularCusto(int horas);
}

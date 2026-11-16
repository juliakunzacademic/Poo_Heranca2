namespace ReservasEspacos.Modelo;

public class SalaEstudo : Espaco
{
    public decimal ValorHora { get; }

    public SalaEstudo(string identificacao, string localizacao, int capacidade, decimal valorHora)
        : base(identificacao, localizacao, capacidade)
    {
        if (valorHora <= 0)
            throw new ArgumentException("O valor por hora deve ser maior que zero.", nameof(valorHora));

        ValorHora = valorHora;
    }

    public override decimal CalcularCusto(int horas)
    {
        if (horas <= 0)
            throw new ArgumentException("A quantidade de horas deve ser maior que zero.", nameof(horas));

        return horas * ValorHora;
    }
}

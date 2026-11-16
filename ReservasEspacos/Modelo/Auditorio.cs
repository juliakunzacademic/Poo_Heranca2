namespace ReservasEspacos.Modelo;

public class Auditorio : Espaco
{
    public decimal ValorHora { get; }
    public decimal TaxaPreparacao { get; }

    public Auditorio(string identificacao, string localizacao, int capacidade, decimal valorHora, decimal taxaPreparacao)
        : base(identificacao, localizacao, capacidade)
    {
        if (valorHora <= 0)
            throw new ArgumentException("O valor por hora deve ser maior que zero.", nameof(valorHora));

        if (taxaPreparacao < 0)
            throw new ArgumentException("A taxa de preparação não pode ser negativa.", nameof(taxaPreparacao));

        ValorHora = valorHora;
        TaxaPreparacao = taxaPreparacao;
    }

    public override decimal CalcularCusto(int horas)
    {
        if (horas <= 0)
            throw new ArgumentException("A quantidade de horas deve ser maior que zero.", nameof(horas));

        return horas * ValorHora + TaxaPreparacao;
    }
}
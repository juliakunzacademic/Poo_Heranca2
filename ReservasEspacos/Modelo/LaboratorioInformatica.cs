namespace ReservasEspacos.Modelo;

public class LaboratorioInformatica : Espaco
{
    public int QuantidadeComputadores { get; }
    public decimal ValorHoraPorComputador { get; }

    public LaboratorioInformatica(string identificacao, string localizacao, int capacidade,
        int quantidadeComputadores, decimal valorHoraPorComputador)
        : base(identificacao, localizacao, capacidade)
    {
        if (quantidadeComputadores <= 0)
            throw new ArgumentException("A quantidade de computadores deve ser maior que zero.", nameof(quantidadeComputadores));

        if (quantidadeComputadores > Capacidade)
            throw new ArgumentException("A quantidade de computadores não pode ser maior que a capacidade.", nameof(quantidadeComputadores));

        if (valorHoraPorComputador <= 0)
            throw new ArgumentException("O valor por hora de cada computador deve ser maior que zero.", nameof(valorHoraPorComputador));

        QuantidadeComputadores = quantidadeComputadores;
        ValorHoraPorComputador = valorHoraPorComputador;
    }

    public override decimal CalcularCusto(int horas)
    {
        if (horas <= 0)
            throw new ArgumentException("A quantidade de horas deve ser maior que zero.", nameof(horas));

        return horas * QuantidadeComputadores * ValorHoraPorComputador;
    }
}
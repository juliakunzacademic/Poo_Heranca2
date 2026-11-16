namespace ProcessamentoDocumentos.Modelo;

public class RelatorioFinanceiro : Documento
{
    public decimal ReceitaTotal { get; }
    public decimal DespesaTotal { get; }

    public RelatorioFinanceiro(string titulo, string autor, DateTime dataCriacao,
        decimal receitaTotal, decimal despesaTotal)
        : base(titulo, autor, dataCriacao)
    {
        if (receitaTotal < 0)
            throw new ArgumentException("A receita total não pode ser negativa.", nameof(receitaTotal));

        if (despesaTotal < 0)
            throw new ArgumentException("A despesa total não pode ser negativa.", nameof(despesaTotal));

        ReceitaTotal = receitaTotal;
        DespesaTotal = despesaTotal;
    }

    public override void Processar()
    {
        Console.WriteLine($"Relatório \"{Titulo}\": saldo de {ReceitaTotal - DespesaTotal:C}");
    }

    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"Saldo: {ReceitaTotal - DespesaTotal:C}");
    }
}

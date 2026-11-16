namespace ProcessamentoDocumentos.Modelo;

public class Planilha : Documento
{
    public int QuantidadeLinhas { get; }
    public int QuantidadeColunas { get; }

    public Planilha(string titulo, string autor, DateTime dataCriacao,
        int quantidadeLinhas, int quantidadeColunas)
        : base(titulo, autor, dataCriacao)
    {
        if (quantidadeLinhas <= 0)
            throw new ArgumentException("A quantidade de linhas deve ser maior que zero.", nameof(quantidadeLinhas));

        if (quantidadeColunas <= 0)
            throw new ArgumentException("A quantidade de colunas deve ser maior que zero.", nameof(quantidadeColunas));

        QuantidadeLinhas = quantidadeLinhas;
        QuantidadeColunas = quantidadeColunas;
    }

    public override void Processar()
    {
        Console.WriteLine($"Planilha \"{Titulo}\": {QuantidadeLinhas * QuantidadeColunas} células.");
    }

    public new void ExibirResumo()
    {
        Console.WriteLine($"Resumo da planilha: {QuantidadeLinhas} linhas e {QuantidadeColunas} colunas");
    }
}

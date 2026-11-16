namespace ProcessamentoDocumentos.Modelo;

public class DocumentoTexto : Documento
{
    public string Conteudo { get; }
    public int QuantidadePalavras { get; }

    public DocumentoTexto(string titulo, string autor, DateTime dataCriacao, string conteudo)
        : base(titulo, autor, dataCriacao)
    {
        if (string.IsNullOrEmpty(conteudo))
            throw new ArgumentException("O conteúdo do documento não pode ser vazio.", nameof(conteudo));

        Conteudo = conteudo;
        QuantidadePalavras = conteudo.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public override void Processar()
    {
        Console.WriteLine($"Processando documento de texto: {QuantidadePalavras} palavra(s).");
    }
}
namespace ProcessamentoDocumentos.Modelo;

public abstract class Documento
{
    public string Titulo { get; }
    public string Autor { get; }
    public DateTime DataCriacao { get; }


    public Documento(string titulo, string autor, DateTime dataCriacao)
    {
        if (string.IsNullOrEmpty(titulo))
        throw new ArgumentException("O título é obrigatório.", nameof(titulo));

        if (string.IsNullOrEmpty(autor))
        throw new ArgumentException("O autor é obrigatório.", nameof(autor));

        if (dataCriacao > DateTime.Now)
            throw new ArgumentException("A data de criação não pode ser no futuro.", nameof(dataCriacao));

        Titulo = titulo;
        Autor = autor;
        DataCriacao = dataCriacao;
    }

    public abstract void Processar();
    
    public virtual void ExibirResumo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Data de Criação: {DataCriacao.ToShortDateString()}");
    }
}

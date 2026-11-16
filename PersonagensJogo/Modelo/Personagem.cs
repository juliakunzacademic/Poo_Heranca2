namespace PersonagensJogo.Modelo;

public class Personagem
{
    public string Nome { get; }
    public int PontosDeVida { get; private set; }
    public int ForcaDeAtaque { get; }

    public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)
    {
        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("O nome é obrigatório.", nameof(nome));

        if (pontosDeVida <= 0)
            throw new ArgumentException("Os pontos de vida devem ser maiores que zero.", nameof(pontosDeVida));

        if (forcaDeAtaque <= 0)
            throw new ArgumentException("A força de ataque deve ser maior que zero.", nameof(forcaDeAtaque));

        Nome = nome;
        PontosDeVida = pontosDeVida;
        ForcaDeAtaque = forcaDeAtaque;
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Pontos de Vida: {PontosDeVida}");
        Console.WriteLine($"Força de Ataque: {ForcaDeAtaque}");
    }

    public virtual int Atacar()
    {
        return ForcaDeAtaque;
    }

    public void ReceberDano(int dano)
    {
        if (dano < 0)
            throw new ArgumentException("O dano deve ser um valor não negativo.", nameof(dano));

        PontosDeVida -= dano;
        if (PontosDeVida < 0)
            PontosDeVida = 0;
    }
}
namespace PersonagensJogo.Modelo;

public class Guerreiro : Personagem
{
    public int BonusEspada { get; }

    public Guerreiro(string nome, int pontosDeVida, int forcaDeAtaque, int bonusEspada)
        : base(nome, pontosDeVida, forcaDeAtaque)
    {
        if (bonusEspada < 0)
            throw new ArgumentException("O bônus da espada não pode ser negativo.", nameof(bonusEspada));

        BonusEspada = bonusEspada;
    }

    public override int Atacar()
    {
        return ForcaDeAtaque + BonusEspada;
    }
}
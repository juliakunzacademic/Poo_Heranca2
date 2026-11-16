namespace PersonagensJogo.Modelo;

public class Paladino : Guerreiro
{
    public int BonusSagrado { get; }

    public Paladino(string nome, int pontosDeVida, int forcaDeAtaque, int bonusEspada, int bonusSagrado)
        : base(nome, pontosDeVida, forcaDeAtaque, bonusEspada)
    {
        if (bonusSagrado < 0)
            throw new ArgumentException("O bônus sagrado não pode ser negativo.", nameof(bonusSagrado));

        BonusSagrado = bonusSagrado;
    }

    public override int Atacar()
    {
        return base.Atacar() + BonusSagrado;
    }
}
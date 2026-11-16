namespace PersonagensJogo.Modelo;

public class Arqueiro : Personagem
{
    public int BonusCritico { get; }

    public Arqueiro(string nome, int pontosDeVida, int forcaDeAtaque, int bonusCritico)
        : base(nome, pontosDeVida, forcaDeAtaque)
    {
        if (bonusCritico <= 0)
            throw new ArgumentException("O bônus crítico deve ser maior que zero.", nameof(bonusCritico));

        BonusCritico = bonusCritico;
    }

    public override int Atacar()
    {
        return base.Atacar();
    }

    public int Atacar(bool ataqueCritico)
    {
        if (ataqueCritico)
            return Atacar() + BonusCritico;

        return Atacar();
    }
}

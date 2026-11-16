namespace PersonagensJogo.Modelo;

public class Mago : Personagem
{
    public int ManaAtual { get; private set; }
    public int CustoManaAtaque { get; }
    public int BonusMagico { get; }

    public Mago(string nome, int pontosDeVida, int forcaDeAtaque,
        int manaAtual, int custoManaAtaque, int bonusMagico)
        : base(nome, pontosDeVida, forcaDeAtaque)
    {
        if (manaAtual < 0)
            throw new ArgumentException("A mana não pode ser negativa.", nameof(manaAtual));

        if (custoManaAtaque <= 0)
            throw new ArgumentException("O custo de mana do ataque deve ser maior que zero.", nameof(custoManaAtaque));

        if (bonusMagico < 0)
            throw new ArgumentException("O bônus mágico não pode ser negativo.", nameof(bonusMagico));

        ManaAtual = manaAtual;
        CustoManaAtaque = custoManaAtaque;
        BonusMagico = bonusMagico;
    }

    public override int Atacar()
    {
        if (ManaAtual >= CustoManaAtaque)
        {
            ManaAtual -= CustoManaAtaque;
            return ForcaDeAtaque + BonusMagico;
        }

        return base.Atacar();
    }
}
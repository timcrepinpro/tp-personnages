class Magicien : Personnage
{
    protected int mana;

    public Magicien() { }

    public Magicien(string nom, int vie, int mana) : base(nom, vie)
    {
        this.mana = mana;
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Mana: {mana}");
    }
    public void LancerSort()
    {
        Console.WriteLine($"le magicien {nom} lance un sort !");
    }
}
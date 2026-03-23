class Guerrier : Personnage
{
    protected int armure;

    public Guerrier() { }

    public Guerrier(string nom, int vie, int armure) : base(nom, vie)
    {
        this.armure = armure;
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Armure: {armure}");
    }
    public void Attaquer()
    {
        Console.WriteLine($"le guerrier {nom} attaque !");
    }
    
}


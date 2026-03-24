class Archer : Personnage
{
    private int precision;

    public Archer(string nom, int vie, int precision) : base(nom, vie)
    {
        this.precision = precision;
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Précision: {precision}");
    }

    public void Tirer()
    {
        Console.WriteLine($"L'archer {nom} tire une flèche avec une précision de {precision} !  ");
    }

    public int GetPrecision()
    {
        return precision;
    }

    public void SetPrecision(int precision)
    {
        this.precision = precision;
    }
}
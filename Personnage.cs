class Personnage
{
    protected string nom;
    protected int vie;


    public Personnage() { }
    public Personnage(string nom, int vie)
    {
        this.nom = nom;
        this.vie = vie;
    }

    public void RecevoirDegat(int degats)
    {
        vie -= degats;
        if (vie < 0)
        {
            vie = 0;
        }
    }

    public void afficher()
    {
        Console.WriteLine($"Nom: {nom}, Vie: {vie}");
    }

    public void RecevoirDegat(int degats, int reduction)
    {
        int degatsSubis = degats - reduction;
        if (degatsSubis < 0)
        {
            degatsSubis = 0;
        }
        vie -= degatsSubis;
        if (vie < 0)
        {
            vie = 0;
        }
    }

}
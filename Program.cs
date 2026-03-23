namespace program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Personnage p1 = new Personnage("Jean eude", 100);
        p1.afficher();
        p1.RecevoirDegat(20);
        p1.afficher();
    }
}

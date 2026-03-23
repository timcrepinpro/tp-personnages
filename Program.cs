using System.Runtime.Serialization;

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

        Guerrier g1 = new Guerrier("arthur", 100, 50);
        g1.afficher();

        Magicien m1 = new Magicien("Merlin", 80, 200);
        m1.afficher();
    }
}

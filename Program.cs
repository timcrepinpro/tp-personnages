using System.Runtime.Serialization;

namespace program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Personnage> personnages = new List<Personnage>
        {
            new Personnage("Jean eude", 100),
            new Guerrier("Arthur", 100, 20),
            new Magicien("Merlin", 80, 50)
        };

        foreach (var personnage in personnages)
        {
            if (personnage is Guerrier guerrier)
            {
                personnage.afficher();
                guerrier.Attaquer();                
            }
            else if (personnage is Magicien magicien)
            {
                personnage.afficher();
                magicien.LancerSort(); 
            }
        }


        /*

        Personnage p1 = new Personnage("Jean eude", 100);
        p1.afficher();
        p1.RecevoirDegat(20);
        p1.afficher();

        Guerrier g1 = new Guerrier("arthur", 100, 50);
        g1.afficher();

        Magicien m1 = new Magicien("Merlin", 80, 200);
        m1.afficher();

        g1.RecevoirDegat(30, 10);
        g1.afficher();

        */
    }
}

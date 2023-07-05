// See https://aka.ms/new-console-template for more information
using Heroes_vs_Monster;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");



Heroes hero;
string choixH;
do
{
    Console.WriteLine("quelle heroes voulez-vous choisir");
    Console.WriteLine($" 1 les Humains ");
    Console.WriteLine($" 2 les nains ");
    choixH = Console.ReadLine();
}
while (choixH != "1" && choixH != "2");



if (choixH == "1")
{
    hero = new Humain();

}
else
{
   hero = new Nain();
}

Console.WriteLine("Entrez un nom");
hero.Nom = Console.ReadLine();
Console.WriteLine($"Votre Heroes s'appelle : {hero.Nom}");


Console.WriteLine($"son endurance est de : {hero.Endurance}");
Console.WriteLine($"sa force est de : {hero.Force}");
Console.WriteLine($"sais point de vie sont : {hero.PointDeVie}");

Console.WriteLine("creation du Monstre");
Console.WriteLine($"le monstre et ");












//hero.Frappe(monstre)






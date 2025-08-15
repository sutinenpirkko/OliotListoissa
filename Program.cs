namespace OliotListoissa;

class Program
{
    static void Main(string[] args)
    {
        Pelaaja pelaaja = new Pelaaja("Mikko");

        Console.WriteLine(pelaaja);

        pelaaja.Arvonta();

        Console.WriteLine(pelaaja);

        List<Pelaaja> tyypit = [pelaaja, new Pelaaja("Maija")];

        Console.WriteLine("Anna pelaajan nimi:");

        string pelaajanNimi = Console.ReadLine();

        tyypit.Add(new Pelaaja(pelaajanNimi));

        Pelaaja pelaaja1 = new Pelaaja(pelaajanNimi);

        tyypit.Add(pelaaja1);

        foreach (Pelaaja kaveri in tyypit)
        {
            kaveri.Arvonta();
        }

        foreach (Pelaaja kaveri in tyypit)
        {
            Console.WriteLine(kaveri);
        }

        tyypit.Sort();

        foreach (Pelaaja kaveri in tyypit)
        {
            Console.WriteLine(kaveri);
        }

    }
}

public class Pelaaja
{
    public string Pelaajanimi {get; private set;}
    public int Pistemaara {get; set;}

    private int _bias;

    public Pelaaja (string nimi)
    {
        this.Pelaajanimi = nimi;
        this.Pistemaara = 0;

        Random random = new Random();
        _bias = random.Next(-11, 11);
    }

    public override string ToString()
    {
        return this.Pelaajanimi + " : " + this.Pistemaara;
    }

    public void Arvonta()
    {
        Random random = new Random();
        Pistemaara = Pistemaara + random.Next(-11, 11) + -_bias; 
    }
}
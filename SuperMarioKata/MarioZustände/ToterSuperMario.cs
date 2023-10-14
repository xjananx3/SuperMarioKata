using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class ToterSuperMario : ISuperMario
{
    public int AnzahlLeben { get; }
    public ToterSuperMario()
    {
        
    }

    public ISuperMario WirdGetroffen()
    {
        return this;
    }

    public ISuperMario FindetLeben()
    {
        var neueAnzahlLeben = AnzahlLeben + 1;
        
        return new KleinerSuperMario(neueAnzahlLeben);
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }

    public ISuperMario FindetFeuerblume()
    {
        return this;
    }

    public ISuperMario FindetEisblume()
    {
        return this;
    }
}
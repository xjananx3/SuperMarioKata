using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class SuperMarioMitFeuerblume : ISuperMario
{
    public int AnzahlLeben { get; }
    public SuperMarioMitFeuerblume(int anzahlLeben)
    {
        AnzahlLeben = anzahlLeben;
    }
    
    public ISuperMario WirdGetroffen()
    {
        return new SuperMarioMitPilz(AnzahlLeben);
    }

    public ISuperMario FindetLeben()
    {
        var neueAnzahlLeben = AnzahlLeben + 1;
        
        return new SuperMarioMitFeuerblume(neueAnzahlLeben);
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }

    public ISuperMario FindetFeuerblume()
    {
        return this;
    }
}
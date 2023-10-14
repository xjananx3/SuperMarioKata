using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class SuperMarioMitEisblume : ISuperMario
{
    public int AnzahlLeben { get; }

    public SuperMarioMitEisblume(int anzahlLeben)
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
        
        return new SuperMarioMitEisblume(neueAnzahlLeben);
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }

    public ISuperMario FindetFeuerblume()
    {
        return new SuperMarioMitFeuerblume(AnzahlLeben);
    }

    public ISuperMario FindetEisblume()
    {
        return this;
    }
}
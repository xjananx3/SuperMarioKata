using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class SuperMarioMitPilz : ISuperMario
{
    public int AnzahlLeben { get; }
    
    public SuperMarioMitPilz(int anzahlLeben)
    {
        AnzahlLeben = anzahlLeben;
    }

    public ISuperMario WirdGetroffen()
    {
        return new KleinerSuperMario(AnzahlLeben);
    }

    public ISuperMario FindetLeben()
    {
        var neueAnzahlLeben = AnzahlLeben + 1;
        
        return new SuperMarioMitPilz(neueAnzahlLeben);
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }

    public ISuperMario FindetFeuerblume()
    {
        return new SuperMarioMitFeuerblume(AnzahlLeben);
    }
}
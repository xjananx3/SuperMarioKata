using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class KleinerSuperMario : ISuperMario
{
    public int AnzahlLeben { get; }
    public KleinerSuperMario(int anzahlLeben)
    {
        AnzahlLeben = anzahlLeben;
    }
    
    public ISuperMario WirdGetroffen()
    {
        if (AnzahlLeben > 0)
        {
            var neueAnzahlLeben = AnzahlLeben - 1;
            return new KleinerSuperMario(neueAnzahlLeben);
        }
        
        return new ToterSuperMario();
    }

    public ISuperMario FindetLeben()
    {
        var neueAnzahlLeben = AnzahlLeben + 1;
        
        return new KleinerSuperMario(neueAnzahlLeben);
    }

    public ISuperMario FindetPilz()
    {
        return new SuperMarioMitPilz(AnzahlLeben);
    }
}
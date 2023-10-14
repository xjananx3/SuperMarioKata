namespace SuperMarioKata.Interfaces;

public interface ISuperMario
{
    int AnzahlLeben { get; }
    ISuperMario WirdGetroffen();
    ISuperMario FindetLeben();
    ISuperMario FindetPilz();

}
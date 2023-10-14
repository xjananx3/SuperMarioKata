using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class KleinerSuperMario : ISuperMario
{
    public KleinerSuperMario()
    {
        
    }

    public ISuperMario WirdGetroffen()
    {
        return new ToterSuperMario();
    }

    public ISuperMario FindetPilz()
    {
        return new SuperMarioMitPilz();
    }
}
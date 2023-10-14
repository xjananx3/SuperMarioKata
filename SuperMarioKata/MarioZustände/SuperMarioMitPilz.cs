using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class SuperMarioMitPilz : ISuperMario
{
    public SuperMarioMitPilz()
    {
        
    }

    public ISuperMario WirdGetroffen()
    {
        return new KleinerSuperMario();
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }
}
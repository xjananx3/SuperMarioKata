using SuperMarioKata.Interfaces;

namespace SuperMarioKata.MarioZustände;

public class ToterSuperMario : ISuperMario
{
    public ToterSuperMario()
    {
        
    }

    public ISuperMario WirdGetroffen()
    {
        return this;
    }

    public ISuperMario FindetPilz()
    {
        return this;
    }
}
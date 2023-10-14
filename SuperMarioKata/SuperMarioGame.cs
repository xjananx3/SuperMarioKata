using SuperMarioKata.Interfaces;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata;

public class SuperMarioGame
{
    public SuperMarioGame()
    {
        
    }
    public ISuperMario Start()
    {
        return new KleinerSuperMario();
    }

    
}
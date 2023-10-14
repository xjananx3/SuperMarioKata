using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration3Tests
{
    [Fact]
    public void SuperMario_Sollte_drei_Leben_bei_Start_haben()
    {
        var marioGame = new SuperMarioGame();

        var marioGameStart = marioGame.Start();

        marioGameStart.AnzahlLeben.Should().Be(3);
    }
    
    [Fact]
    public void SuperMario_Sollte_Leben_verlieren_Wenn_er_stirbt()
    {
        var kleinerMario = new KleinerSuperMario(3);

        var marioStirbt = kleinerMario.WirdGetroffen();

        marioStirbt.Should().BeOfType<KleinerSuperMario>();
        marioStirbt.AnzahlLeben.Should().Be(2);
    }

    [Fact]
    public void SuperMario_Sollte_tot_sein_wenn_alle_Leben_aufgebraucht()
    {
        var mario = new KleinerSuperMario(0);

        var marioStirbt = mario.WirdGetroffen();

        marioStirbt.Should().BeOfType<ToterSuperMario>();
    }
}
using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration6Tests
{
    [Fact]
    public void SuperMario_Sollte_wachsen_Wenn_er_eine_Eisblume_findet()
    {
        var kleinerMario = new KleinerSuperMario(3);
        var marioMitPilz = new SuperMarioMitPilz(3);

        var kleinerMarioFindetEisblume = kleinerMario.FindetEisblume();
        var marioMitPilzFindetEisblume = marioMitPilz.FindetEisblume();

        kleinerMarioFindetEisblume.Should().BeOfType<SuperMarioMitEisblume>();
        marioMitPilzFindetEisblume.Should().BeOfType<SuperMarioMitEisblume>();
    }
    
    [Fact]
    public void SuperMarioMitEisblume_Sollte_verkleinern_Wenn_er_getroffen_wird()
    {
        var superMarioMitEisblume = new SuperMarioMitEisblume(3);

        var superMarioMitEisblumeWirdGetroffen = superMarioMitEisblume.WirdGetroffen();

        superMarioMitEisblumeWirdGetroffen.Should().BeOfType<SuperMarioMitPilz>();
    }
    
    [Fact]
    public void SuperMarioMitEisblume_Sollte_Eisblume_bleiben_Wenn_er_Eisblume_findet()
    {
        var superMarioMitEisblume = new SuperMarioMitEisblume(3);

        var superMarioMitEisblumefindetEisblume = superMarioMitEisblume.FindetEisblume();

        superMarioMitEisblumefindetEisblume.Should().BeOfType<SuperMarioMitEisblume>();
    }

    [Fact]
    public void SuperMarioMitEisblume_Sollte_zu_Feuerblume_werden_Wenn_er_Feuerblume_findet()
    {
        var superMarioMitEisblume = new SuperMarioMitEisblume(3);

        var superMarioMitEisblumefindetFeuerblume = superMarioMitEisblume.FindetFeuerblume();

        superMarioMitEisblumefindetFeuerblume.Should().BeOfType<SuperMarioMitFeuerblume>();
    }
}
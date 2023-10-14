using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration5Tests
{
    [Fact]
    public void SuperMario_Sollte_wachsen_Wenn_er_eine_Feuerblume_findet()
    {
        var kleinerMario = new KleinerSuperMario(3);
        var marioMitPilz = new SuperMarioMitPilz(3);

        var kleinerMarioFindetFeuerblume = kleinerMario.FindetFeuerblume();
        var marioMitPilzFindetFeuerblume = marioMitPilz.FindetFeuerblume();

        kleinerMarioFindetFeuerblume.Should().BeOfType<SuperMarioMitFeuerblume>();
        marioMitPilzFindetFeuerblume.Should().BeOfType<SuperMarioMitFeuerblume>();
    }

    [Fact]
    public void SuperMarioMitFeuerblume_Sollte_verkleinern_Wenn_er_getroffen_wird()
    {
        var superMarioMitFeuerblume = new SuperMarioMitFeuerblume(3);

        var superMarioMitFeuerblumeWirdGetroffen = superMarioMitFeuerblume.WirdGetroffen();

        superMarioMitFeuerblumeWirdGetroffen.Should().BeOfType<SuperMarioMitPilz>();
    }

    [Fact]
    public void SuperMarioMitFeuerblume_Sollte_Feuerblume_bleiben_Wenn_er_Feuerblume_findet()
    {
        var superMarioMitFeuerblume = new SuperMarioMitFeuerblume(3);

        var superMarioMitFeuerblumefindetFeuerblume = superMarioMitFeuerblume.FindetFeuerblume();

        superMarioMitFeuerblumefindetFeuerblume.Should().BeOfType<SuperMarioMitFeuerblume>();
    }
}
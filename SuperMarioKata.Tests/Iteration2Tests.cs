using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration2Tests
{
    [Fact]
    public void KleinerSuperMario_Sollte_Bei_Pilzfund_SuperMarioMitPilz_Sein()
    {
        // Arrange
        var kleinerMario = new KleinerSuperMario(2);
        
        // Act
        var kleinerMarioFindetPilz = kleinerMario.FindetPilz();
        
        // Assert
        kleinerMarioFindetPilz.Should().BeOfType<SuperMarioMitPilz>();
    }

    [Fact]
    public void SuperMarioMitPilz_Sollte_Bei_Pilzfund_SuperMarioMitPilz_Bleiben()
    {
        var superMarioMitPilz = new SuperMarioMitPilz(3);

        var superMarioMitPilzfindetPilz = superMarioMitPilz.FindetPilz();

        superMarioMitPilzfindetPilz.Should().BeOfType<SuperMarioMitPilz>();
    }

    [Fact]
    public void SuperMarioMitPilz_Sollte_Bei_Treffer_KleinerSuperMario_Sein()
    {
        var superMarioMitPilz = new SuperMarioMitPilz(2);

        var superMarioMitPilzWirdGetroffen = superMarioMitPilz.WirdGetroffen();

        superMarioMitPilzWirdGetroffen.Should().BeOfType<KleinerSuperMario>();
    }
}
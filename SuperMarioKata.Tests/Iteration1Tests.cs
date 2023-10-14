using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration1Tests
{
    [Fact]
    public void SuperMario_Sollte_Bei_Start_klein_sein()
    {
        // Arrange
        var mario = new SuperMarioGame();

        // Act
        var kleinerMario = mario.Start();

        // Assert
        kleinerMario.Should().BeOfType<KleinerSuperMario>();
    }

    [Fact]
    public void KleinerSuperMario_Sollte_Bei_Treffer_Tot_Sein()
    {
        var mario = new KleinerSuperMario();

        var superMarioWirdGetroffen = mario.WirdGetroffen();

        superMarioWirdGetroffen.Should().BeOfType<ToterSuperMario>();
    }
}
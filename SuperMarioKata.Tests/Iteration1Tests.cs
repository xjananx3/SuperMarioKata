using FluentAssertions;

namespace SuperMarioKata.Tests;

public class Iteration1Tests
{
    [Fact]
    public void SuperMario_Sollte_Bei_Start_klein_sein()
    {
        // Arrange
        var mario = new SuperMario();

        // Act
        var kleinerMario = mario.Start();

        // Assert
        kleinerMario.Should().Be("Kleiner Super Mario");
    }

    [Fact]
    public void SuperMario_Sollte_Bei_Treffer_Tot_Sein()
    {
        var mario = new SuperMario();

        var superMarioWirdGetroffen = mario.WirdGetroffen();

        superMarioWirdGetroffen.Should().Be("Toter Super Mario");
    }
}
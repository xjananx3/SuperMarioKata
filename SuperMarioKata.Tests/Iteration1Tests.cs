using FluentAssertions;

namespace SuperMarioKata.Tests;

public class Iteration1Tests
{
    [Fact]
    public void SuperMario_Sollte_Bei_Start_klein_sein()
    {
        // Arrange
        SuperMario mario = new SuperMario();

        // Act
        var kleinerMario = mario.Start();

        // Assert
        kleinerMario.Should().Be("Kleiner Super Mario");
    }
}
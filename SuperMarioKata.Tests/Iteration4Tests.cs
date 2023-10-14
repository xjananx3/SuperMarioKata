using FluentAssertions;
using SuperMarioKata.MarioZustände;

namespace SuperMarioKata.Tests;

public class Iteration4Tests
{
    [Fact]
    public void SuperMario_Leben_Sollte_sich_erhöhen_wenn_Mario_Leben_findet()
    {
        var mario = new KleinerSuperMario(3);

        var marioFindetLeben= mario.FindetLeben();

        marioFindetLeben.AnzahlLeben.Should().Be(4);
    }

    [Fact]
    public void ToterSuperMario_Sollte_Wieder_Spielbar_sein_wenn_er_Leben_findet()
    {
        var toterMario = new ToterSuperMario();

        var toterMarioFindetLeben = toterMario.FindetLeben();

        toterMario.FindetLeben().Should().BeOfType<KleinerSuperMario>();
    }
}
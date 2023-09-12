using Biblioteca;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Operaciones_Suma_DebeRetornarSumaCorrectamente()
    {
        Operaciones operacion  = new Operaciones();

        int resultado = operacion.Sumar(2, 4);

        Assert.Equal(resultado, 6);
    }

    [Fact]
    public void Operaciones_Suma_DebeRetornarSumaIncorrectamente()
    {
        Operaciones operacion  = new Operaciones();

        int resultado = operacion.Sumar(2, 4);

        Assert.NotEqual(resultado, 7);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Biblioteca;

namespace Tests
{
    public class PersonaTest
    {
        [Fact]
        public void PersonaMenorEdad()
        {
            Persona persona = new Persona("op", 17);

            bool resultado = persona.EsMayorEdad();

            Assert.Equal(resultado, false);
        }

        [Theory]
        [InlineData("Ramon", 37)]
        [InlineData("Ramon", 90)]
        [InlineData("elpepe", 1000000000)]
        public void PersonaMayorEdad(string nombre, int edad)
        {
            //Act
            Persona persona = new Persona(nombre, edad);

            //Arrange
            bool resultado = persona.EsMayorEdad();

            //Assert
            Assert.Equal(resultado, true);
        }
    }
}
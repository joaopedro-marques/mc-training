using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class PetAPartirDoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmPet()
        {
            // Arrange
            string linhaValida = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            // Act
            Pet pet = PetAPartirDoCsv.ConverteDoTexto(linhaValida);

            // Assert
            Assert.NotNull(pet);
            Assert.Equal(Guid.Parse("456b24f4-19e2-4423-845d-4a80e8854a41"), pet.Id);
            Assert.Equal("Lima Limão", pet.Nome);
            Assert.Equal(TipoPet.Gato, pet.Tipo);
        }

        [Fact]
        public void QuandoAStringForNulaDeveLancarArgumentNullException()
        {
            // Arrange
            string? linhaNula = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => 
                PetAPartirDoCsv.ConverteDoTexto(linhaNula));
        }

        [Fact]
        public void QuandoStringForVaziaDeveLancarArgumentException()
        {
            // Arrange
            string linhaVazia = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => 
                PetAPartirDoCsv.ConverteDoTexto(linhaVazia));
        }

        [Fact]
        public void QuandoStringTiverQuantidadeInsufficientDeCamposDeveLancarFormatException()
        {
            // Arrange
            string linhaInvalida = "invalid-guid;PetName"; // Missing type field

            // Act & Assert
            Assert.Throws<FormatException>(() => 
                PetAPartirDoCsv.ConverteDoTexto(linhaInvalida));
        }

        [Fact]
        public void QuandoStringTiverGuidInvalidoDeveLancarFormatException()
        {
            // Arrange
            string linhaInvalida = "invalid-guid;PetName;1"; // Invalid GUID format

            // Act & Assert
            Assert.Throws<FormatException>(() => 
                PetAPartirDoCsv.ConverteDoTexto(linhaInvalida));
        }

        [Fact]
        public void QuandoStringTiverTipoInvalidoDeveLancarArgumentException()
        {
            // Arrange
            string linhaInvalida = "MAISHBFSOUMASJIDOAHOU"; // Invalid type

            // Act & Assert
            Assert.Throws<FormatException>(() => 
                PetAPartirDoCsv.ConverteDoTexto(linhaInvalida));
        }
    }
}

using _M1S05__Ex4ao6.Classes;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S05__Ex4ao6Test
{
    public class ValidadorDeNumerosTest
    {
        [Fact]
        public void TesteEhNumeroPrimo()
        {
            bool resultado = ValidadorDeNumeros.EhNumeroPrimo(17);

            Assert.True(resultado);
        }

        [Fact]
        public void TesteParOuImpar()
        {
            string resultado = ValidadorDeNumeros.ParOuImpar(17);

            string esperado = "Impar";

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteEhDivisivelPor()
        {
            bool resultado = ValidadorDeNumeros.EhDivisivelPor(15, 5);

            Assert.True(resultado);
        }
    }
}

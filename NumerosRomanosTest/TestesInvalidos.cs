using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumerosRomanosTest
{
    [TestClass]
    public class TestesInvalidos
    {
        [TestMethod]
        [DataRow(null, "Número Inválido")]
        public void TesteInvalidoRomanoParaArabico(string numeroRomano, string mensagemErro)
        {
            ConversorRomanoParaArabico conversor = new ConversorRomanoParaArabico();
            Assert.AreEqual(mensagemErro, conversor.Validar(numeroRomano));
        }

        [TestMethod]
        [DataRow(0, "Número Inválido")]
        public void TesteInvalidoArabicoParaRomano(int numeroArabico, string mensagemErro)
        {
            ConversorArabicoParaRomano conversor = new ConversorArabicoParaRomano();
            Assert.AreEqual(mensagemErro, conversor.Validar(numeroArabico));
        }
    }
}

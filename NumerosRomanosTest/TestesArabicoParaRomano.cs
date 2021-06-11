using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumerosRomanosTest
{
    [TestClass]
    public class TestesArabicoParaRomano
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(10, "X")]
        [DataRow(150, "CL")]
        [DataRow(1100, "MC")]
        [DataRow(4000, "ĪV̄")]
        [DataRow(5000, "V̄")]
        [DataRow(6000, "V̄Ī")]
        [DataRow(10000, "X̄")]
        [DataRow(20000, "X̄X̄")]
        [DataRow(24000, "X̄X̄ĪV̄")]
        [DataRow(24150, "X̄X̄ĪV̄CL")]
        [DataRow(24180, "X̄X̄ĪV̄CLXXX")]

        public void ArabicoParaRomano(int numeroArabico, string numeroRomano)
        {
            ConversorArabicoParaRomano conversor = new ConversorArabicoParaRomano();
            Arabicos arabicos = new Arabicos(numeroArabico);
            conversor.converter(arabicos);
            Assert.AreEqual(numeroRomano, arabicos.resultado);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumerosRomanosTest
{
    [TestClass]
    public class TestesRomanoParaArabico
    {
        [TestMethod]
        [DataRow("I",1)]
        [DataRow("II",2)]
        [DataRow("III",3)]
        [DataRow("X",10)]
        [DataRow("CL",150)]
        [DataRow("MC",1100)]
        [DataRow("ĪV̄", 4000)]
        [DataRow("V̄", 5000)]
        [DataRow("V̄Ī", 6000)]
        [DataRow("ĪX̄D ", 9500)]
        [DataRow("X̄", 10000)]
        [DataRow("X̄X̄", 20000)]
        [DataRow("X̄X̄ĪV̄", 24000)]
        [DataRow("X̄X̄ĪV̄CL", 24150)]
        [DataRow("X̄X̄ĪV̄CLXXX", 24180)]        
        
        public void RomanoParaArabico(string numeroRomano, int numeroArabico)
        {
            ConversorRomanoParaArabico conversor = new ConversorRomanoParaArabico();
            Romano romano = new Romano(numeroRomano);
            conversor.converter(romano);
            Assert.AreEqual(numeroArabico, romano.resultado);
        }             

    }
}

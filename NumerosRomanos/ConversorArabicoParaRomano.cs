using System;
using System.Collections.Generic;

namespace NumerosRomanos
{
    public class ConversorArabicoParaRomano
    {
        public Dictionary<int,
            string> numerosArabicosParaRomanos = GerarDicionario();

        public void converter(Arabicos arabicos)
        {
            if (Validar(arabicos.numero) != "Válido")
                ApresentarMensagemErro(Validar(arabicos.numero));

            else
                arabicos.resultado = GetResultado(arabicos.numero);
        }

        public string Validar(int valor)
        {
            if (valor == 0)
                return "Número Inválido";

            else
                return "Válido";
        }

        #region Métodos Privados
        private string GetResultado(int numero)
        {
            foreach (int n in numerosArabicosParaRomanos.Keys)
            {
                if (numero >= n) return numerosArabicosParaRomanos[n] + GetResultado(numero - n);
            }
            return "";
        }

        private void ApresentarMensagemErro(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            Console.ResetColor();
            Console.ReadLine();
        }

        private static Dictionary<int, string> GerarDicionario()
        {
            Dictionary<int, string> numerosArabicosParaRomanos = new Dictionary<int, string>()
            {
                { 10000, "X̄"}, { 9000, "ĪV̄"}, { 8000, "V̄ĪĪĪ"}, { 7000, "V̄ĪĪ"}, { 6000, "V̄Ī"},
                { 5000, "V̄"}, { 4000, "ĪV̄"}, { 1000, "M"}, { 900, "CM"}, { 500, "D"},
                { 400, "DC"}, { 100, "C"}, { 90, "XC"}, { 50, "L"}, { 40, "XL"},
                { 10, "X"}, { 9, "IX"}, { 5, "V"}, { 4, "IV"}, { 1, "I"}
            };
            return numerosArabicosParaRomanos;
        }
        #endregion
    }
}

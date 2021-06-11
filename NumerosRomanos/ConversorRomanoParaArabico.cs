using System;
using System.Collections.Generic;

namespace NumerosRomanos
{
    public class ConversorRomanoParaArabico
    {
        public Dictionary<string,
            int> numerosRomanosParaArabicos = GerarDicionario();
        public int ultimoNumero = 999999999;
        public int resultado = 0;

        public void converter(Romano romano)
        {
            FormatarNumero(romano);

            if (Validar(romano.numero) != "Válido")
                ApresentarMensagemErro(Validar(romano.numero));

            else
                GetResultado(romano);
        }
        public string Validar(string valor)
        {
            if (valor == null)
                return "Número Inválido";

            else
                return "Válido";
        }

        #region Métodos Privados
        private void GetResultado(Romano romano)
        {
            foreach (char c in romano.numero)
            {
                string v = Convert.ToString(c);
                resultado = TransformarEmArabicos(v);

                if (ultimoNumero < resultado)
                {
                    romano.resultado -= ultimoNumero;
                    romano.resultado += resultado - ultimoNumero;
                }
                else
                    romano.resultado += resultado;

                ultimoNumero = resultado;
            }
        }

        private void ApresentarMensagemErro(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void FormatarNumero(Romano romano)
        {
            romano.numero = romano.numero.Replace("Ī", "O");
            romano.numero = romano.numero.Replace("V̄", "P");
            romano.numero = romano.numero.Replace("X̄", "K");
        }

        private int TransformarEmArabicos(string v)
        {
            if (numerosRomanosParaArabicos.ContainsKey(v))
                return numerosRomanosParaArabicos[v];

            return 0;
        }

        private static Dictionary<string, int> GerarDicionario()
        {
            Dictionary<string, int> numerosRomanosParaArabicos = new Dictionary<string, int>()
            {
            { "I", 1 },{ "V", 5},{ "X", 10},{ "L", 50},{ "C", 100},{ "D", 500},{ "M", 1000},{ "O", 1000},
                { "P", 5000},{ "K", 10000}
            };
            return numerosRomanosParaArabicos;
        }
        #endregion
    }
}

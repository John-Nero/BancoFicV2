using System;
using System.Collections.Generic;
using System.IO;

namespace BancoFicV2.Agencia
{
    class Agencia
    {
        int Numero;

        public List<Agencia> LIstaDasAgencias = new List<Agencia>();
        const string CaminhoAgencia = @"C:\temp\Teste\BancoFicV2\BancoFicV2\Agencia\AgenciasDoPais.txt";

        public Agencia(int numero)
        {

            Numero = numero;
        }
        public List<Agencia> TxtParaAgencias()
        {
            //ESTADO | NUMERO
            //Bahia  | 03
            try
            {
                string[] LeTexto = File.ReadAllLines(CaminhoAgencia);
                foreach (string s in LeTexto)
                {
                    string[] ModeloInteiro = s.Split(" | ");
                    LIstaDasAgencias.Add(new Agencia(int.Parse(ModeloInteiro[0])));
                }
                return LIstaDasAgencias;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

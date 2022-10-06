using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BancoFicV2
{
    class SalvarELer
    {
        //ATENÇÃO Para o funcionamento correto do projeto é nescessario adaptar os caminhos dos arquivos.

        //Caminhos Para Local De Busca
        internal const string CaminhoPoupanca = @"C:\Users\john.barros\OneDrive - Clearsale S.A\Área de Trabalho\DadosDosClientesPoupanca.json";
        internal const string CaminhoCorrente = @"C:\Users\john.barros\OneDrive - Clearsale S.A\Área de Trabalho\DadosDosClientesCorrente.json";

        //Listas dos tipos de Conta
        public List<ContaPoupanca> LIstaDasPoupancas = new List<ContaPoupanca>();
        public List<ContaCorrente> LIstaDasCorrentes = new List<ContaCorrente>();

        //Metodos de Save e atualização da Conta Poupanca
        public List<ContaPoupanca> JsonParaPoupancas()
        {
            try
            {
                string json = File.ReadAllText(CaminhoPoupanca);
                LIstaDasPoupancas = JsonConvert.DeserializeObject<List<ContaPoupanca>>(json);
                return LIstaDasPoupancas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void AtualizarContaPoupanca(ContaPoupanca Poupanca)
        {
            if(LIstaDasPoupancas.Count == 0) { JsonParaPoupancas(); }
            {
                foreach (ContaPoupanca Conta in LIstaDasPoupancas)
                {
                    if (Poupanca.Agencia == Conta.Agencia && Poupanca.Numero == Conta.Numero)
                    {
                        LIstaDasPoupancas.Remove(Conta);
                        break;
                    }
                }
            }
            using var file = File.AppendText(CaminhoPoupanca);
            LIstaDasPoupancas.Add(Poupanca);
            file.Close();

            PoupancaParaJson();
        }
        public void PoupancaParaJson()
        {
            File.Delete(CaminhoPoupanca);
            using var file = File.AppendText(CaminhoPoupanca);
            var listaParaJson = JsonConvert.SerializeObject(LIstaDasPoupancas, Formatting.Indented);

            file.WriteLine(listaParaJson);

        }

        //Metodos de save e atualização da Conta corrente
        public List<ContaCorrente> JsonParaCorrentes()
        {
            try
            {
                string json = File.ReadAllText(CaminhoCorrente);
                LIstaDasCorrentes = JsonConvert.DeserializeObject<List<ContaCorrente>>(json);
                return LIstaDasCorrentes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void AtualizarContaCorrente(ContaCorrente Corrente)
        {
            if(LIstaDasCorrentes.Count == 0) { JsonParaCorrentes(); }
            JsonParaCorrentes();
            if (LIstaDasCorrentes != null)
            {
                foreach (ContaCorrente Conta in LIstaDasCorrentes)
                {
                    if (Corrente.Agencia == Conta.Agencia && Corrente.Numero == Conta.Numero)
                    {
                        LIstaDasCorrentes.Remove(Conta);
                        break;
                    }
                }
            }
            using var file = File.AppendText(CaminhoCorrente);
            LIstaDasCorrentes.Add(Corrente);
            file.Close();

            CorrenteParaJson();
        }
        public void CorrenteParaJson()
        {
            File.Delete(CaminhoCorrente);
            using var file = File.AppendText(CaminhoCorrente);
            var listaParaJson = JsonConvert.SerializeObject(LIstaDasCorrentes, Formatting.Indented);

            file.WriteLine(listaParaJson);

        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Configuration;

namespace BancoFicV2
{
    class SalvarELer
    {
        //Caminhos Para Local De Busca
        internal string CaminhoPoupanca = "@" + ConfigurationManager.AppSettings["CaminhoPoupanca"];
        internal string CaminhoCorrente = "@" + ConfigurationManager.AppSettings["CaminhoCorrente"];

        //Listas dos tipos de Conta
        public List<ContaPoupanca> LIstaDasPoupancas = new List<ContaPoupanca>();
        public List<ContaCorrente> LIstaDasCorrentes = new List<ContaCorrente>();

        //Metodos de Save e atualização de Conta

        public void AtualizarDadosDeConta(TipoDeConta Tipo, Conta conta)
        {
            try
            {
                switch (Tipo)
                {
                    case TipoDeConta.ContaPoupanca:

                    if (LIstaDasPoupancas.Count == 0)
                    {
                        LerContas(TipoDeConta.ContaPoupanca);
                    }
                    if (LIstaDasPoupancas != null)
                    {
                        foreach (ContaPoupanca Conta in LIstaDasPoupancas)
                        {
                            if (conta.Agencia == Conta.Agencia && conta.Numero == Conta.Numero)
                            {
                                LIstaDasPoupancas.Remove(Conta);
                                break;
                            }
                        }
                    }
                    LIstaDasPoupancas.Add((ContaPoupanca)conta);
                    File.Delete(CaminhoPoupanca);
                    ContaParaJson(TipoDeConta.ContaPoupanca);

                    break;

                    case TipoDeConta.ContaCorrente:

                    if (LIstaDasCorrentes.Count == 0)
                    {
                        LerContas(TipoDeConta.ContaCorrente);
                    }
                    if (LIstaDasCorrentes != null)
                    {
                        foreach (ContaCorrente Conta in LIstaDasCorrentes)
                        {
                            if (conta.Agencia == Conta.Agencia && conta.Numero == Conta.Numero)
                            {
                                LIstaDasCorrentes.Remove(Conta);
                                break;
                            }
                        }
                    }
                    LIstaDasCorrentes.Add((ContaCorrente)conta);
                    File.Delete(CaminhoCorrente);
                    ContaParaJson(TipoDeConta.ContaCorrente);

                    break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                               "Desculpe",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public void LerContas(TipoDeConta conta)
        {
            try
            {
                switch (conta)
                {
                    case TipoDeConta.ContaPoupanca:

                    string JsonP = File.ReadAllText(CaminhoPoupanca);
                    LIstaDasPoupancas = JsonConvert.DeserializeObject<List<ContaPoupanca>>(JsonP);

                    break;

                    case TipoDeConta.ContaCorrente:

                    string JsonC = File.ReadAllText(CaminhoCorrente);
                    LIstaDasCorrentes = JsonConvert.DeserializeObject<List<ContaCorrente>>(JsonC);

                    break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                               "Desculpe",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public void ContaParaJson(TipoDeConta conta)
        {
            try
            {
                using var fileP = File.AppendText(CaminhoPoupanca);
                using var fileC = File.AppendText(CaminhoCorrente);
                switch (conta)
                {
                    case TipoDeConta.ContaPoupanca:

                    fileC.Close();

                    var listaPoupancaParaJson = JsonConvert.SerializeObject(LIstaDasPoupancas, Formatting.Indented);
                    fileP.WriteLine(listaPoupancaParaJson);
                    fileP.Close();

                    break;

                    case TipoDeConta.ContaCorrente:

                    fileP.Close();

                    var listaCorrenteParaJson = JsonConvert.SerializeObject(LIstaDasCorrentes, Formatting.Indented);
                    fileC.WriteLine(listaCorrenteParaJson);
                    fileC.Close();

                    break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                               "Desculpe",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

    }
}

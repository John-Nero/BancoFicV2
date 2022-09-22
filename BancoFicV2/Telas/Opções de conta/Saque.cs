﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Saque : Form
    {
        Conta conta;
        ContaCorrente Corrente = new ContaCorrente();
        ContaPoupanca Poupanca = new ContaPoupanca();
        SalvarELer Salvar = new SalvarELer();

        public Saque(Conta conta1)
        {
            conta = conta1;
            InitializeComponent();
        }

        private void Saque_Load(object sender, EventArgs e)
        {

        }

        private void BtSacar_Click(object sender, EventArgs e)
        {
            if (conta.Id == 1)
            {
                try
                {
                    Poupanca.SetConta(conta.Titular, conta.Agencia,conta.Numero , conta.Cpf, conta.Saldo, conta.Id);
                    Poupanca.Sacar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaPoupanca(Poupanca);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
                           "Saque concluido",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.None);
                    conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Poupanca,0);
                    opcoes.Show();
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                           "Desculpe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
            }
            else if (conta.Id == 2)
            {
                try
                {
                    Corrente.SetConta(conta.Titular, conta.Agencia, conta.Numero, conta.Cpf, conta.Saldo, conta.Id);
                    Corrente.Sacar(double.Parse(txtValor.Text));
                    Salvar.AtualizarContaCorrente(Corrente);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
                               "Saque concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
                    conta = null;
                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente,Corrente.LimiteEmprestimo);
                    opcoes.Show();
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                           "Desculpe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
            }
        }
    }
}

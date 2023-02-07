using BancoFicV2.Contas;
using BancoFicV2.Enums;
using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Emprestimo : Form
    {

        ContaCorrente Corrente;
        SalvarELer Salvar = new SalvarELer();
        ValidacaoEFormatacao Validacao = new ValidacaoEFormatacao();



        public Emprestimo(ContaCorrente corrente)
        {
            Corrente = corrente;
            InitializeComponent();
        }

        private void BtSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TxtValor.Text) <= Corrente.LimiteEmprestimo)
                {
                    Corrente.SetConta(Corrente.Titular, Corrente.Agencia, Corrente.Numero, Corrente.Cpf, Corrente.Saldo, Corrente.Tipo);
                    Corrente.SolicitarEmprestimo(double.Parse(TxtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente, Corrente);
                    MessageBox.Show($"Seu saldo atual é de {Corrente.Saldo.ToString("F2")}, Clique em OK para retornar a tela de opções",
                               "Deposito concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);

                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                    opcoes.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show($"A quantidade que você deseja sacar é acima do seu limite atual de emprestimo.",
                       "Limite indisponivel",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Desculpe",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Corrente.SetConta(Corrente.Titular, Corrente.Agencia, Corrente.Numero, Corrente.Cpf, Corrente.Saldo, Corrente.Tipo);
            OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
            opcoesDeConta.Show();
            this.Visible = false;

        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valorFinal = Validacao.ValidarNumeros(e, 2);

            TxtValor.Text = valorFinal;
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 8 && e.KeyValue != 46)
            {
                if (TxtValor.Text.Length != 0) { TxtValor.Text = TxtValor.Text.Remove(0, 1); }
            }
        }
    }
}
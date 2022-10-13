using System;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Emprestimo : Form
    {

        ContaCorrente Corrente;
        SalvarELer Salvar = new SalvarELer();

        public Emprestimo(ContaCorrente corrente)
        {
            Corrente = corrente;
            InitializeComponent();
        }

        private void BtSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtValor.Text) <= Corrente.LimiteEmprestimo)
                {
                    Corrente.SetConta(Corrente.Titular, Corrente.Agencia, Corrente.Numero, Corrente.Cpf, Corrente.Saldo,2);
                    Corrente.SolicitarEmprestimo(double.Parse(txtValor.Text));
                    Salvar.AtualizarDadosDeConta(TipoDeConta.ContaCorrente,Corrente);
                    MessageBox.Show("Clique em OK para retornar a tela de opções",
                               "Deposito concluido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);

                    OpcoesDeConta opcoes = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
                    opcoes.Show();
                    this.Visible = false;
                }
                else {
                    MessageBox.Show($"A quantidade que você deseja sacar é acima do seu limite atual de emprestimo.",
                       "Limite indisponivel",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error) ;
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
            Corrente.SetConta(Corrente.Titular, Corrente.Agencia, Corrente.Numero, Corrente.Cpf, Corrente.Saldo, 2);
            OpcoesDeConta opcoesDeConta = new OpcoesDeConta(Corrente, Corrente.LimiteEmprestimo);
            opcoesDeConta.Show();
            this.Visible = false;

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoFicV2
{
    public partial class Opcoesiniciais : Form
    {
        public Opcoesiniciais()
        {
            InitializeComponent();
        }

        private void Opcoesiniciais_Load(object sender, EventArgs e)
        {

        }

        private void LoginPoupanca_Click(object sender, EventArgs e)
        {
            var loginPoupanca = new LoginPoupanca();
            loginPoupanca.Show();
            this.Visible = false;
        }

        private void LoginCorrente_Click(object sender, EventArgs e)
        {
            var loginCorrente = new LoginCorrente();
            loginCorrente.Show();
            this.Visible = false;
        }

        private void CriarPoupanca_Click(object sender, EventArgs e)
        {
            var criarPoupanca = new CriarContaPoupanca();
            criarPoupanca.Show();
            this.Visible = false;
        }

        private void CriarCorrente_Click(object sender, EventArgs e)
        {
            var criarCorrente = new CriarContaCorrente();
            criarCorrente.Show();
            this.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

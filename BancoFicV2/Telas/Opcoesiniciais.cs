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

        private void loginPoupanca_Click(object sender, EventArgs e)
        {
            var loginPoupanca = new LoginPoupanca();
            loginPoupanca.Show();
        }

        private void loginCorrente_Click(object sender, EventArgs e)
        {
            var loginCorrente = new LoginCorrente();
            loginCorrente.Show();
        }

        private void criarPoupanca_Click(object sender, EventArgs e)
        {
            var criarPoupanca = new CriarContaPoupanca();
            criarPoupanca.Show();
        }

        private void criarCorrente_Click(object sender, EventArgs e)
        {
            var criarCorrente = new CriarContaCorrente();
            criarCorrente.Show();
        }
    }
}

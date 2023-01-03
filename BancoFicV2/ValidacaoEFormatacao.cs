using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BancoFicV2
{
    public class ValidacaoEFormatacao
    {


        internal List<string> NumerosMonetariosDigitados = new List<string>();
        internal List<string> NumerosDigitados = new List<string>();
        internal List<string> LetrasDigitadas = new List<string>();

        internal string NomeDeRetorno;
        internal string NumeroRetorno;
        internal string ValorDeRetorno = "";
        internal string ValorTotalString = "";

        private string Formatar(string digito)
        {

            try
            {
                if (digito != null)
                {
                    if (NumerosMonetariosDigitados.Count >= 5)
                    {
                        ValorTotalString = ValorTotalString + digito;
                        string temporaria = Convert.ToInt32(ValorTotalString).ToString(@"0\.000\,00");
                        if (double.Parse(temporaria) > 5000)
                        {
                            //  MessageBox.Show($"O limite de tranfêrencia On-Line é de 5.000,00(Cinco mil reais), para transfêrencia maiores visite uma agência",
                            //    "LIMITE DE TRANSFÊRENCIA ULTRAPASADO",
                            //MessageBoxButtons.OK,
                            //MessageBoxIcon.Warning);

                            ValorTotalString = ValorTotalString.Remove(ValorTotalString.Length - 1);

                            return ValorDeRetorno;
                        }
                        else { NumerosMonetariosDigitados.Add(digito); }
                    }
                    else { NumerosMonetariosDigitados.Add(digito); }
                }


                ValorDeRetorno = "";
                ValorTotalString = "";
                if (NumerosMonetariosDigitados.Count != 0) { foreach (string numero in NumerosMonetariosDigitados) { ValorTotalString += numero; } }
                else { ValorTotalString = "0"; }
                ValorDeRetorno = Convert.ToInt32(ValorTotalString).ToString(@"0\.000\,00");
                ValorDeRetorno = ValorDeRetorno.TrimStart('0');
                ValorDeRetorno = ValorDeRetorno.Trim('.');
                ValorDeRetorno = ValorDeRetorno.TrimStart('0');


                if (ValorDeRetorno.Length == 3) { ValorDeRetorno = "0" + ValorDeRetorno; return ValorDeRetorno; }
                else { return ValorDeRetorno; }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                       "Desculpe",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                throw;
            }
        }

        public string ValidarNumeros(KeyPressEventArgs e, int TipoDeFormatacao)
        {
            ;
            try
            {
                int tecla = (int)e.KeyChar;

                switch (TipoDeFormatacao)
                {
                    case 1:

                    if (char.IsDigit(e.KeyChar) || tecla == 8 || tecla == 46)
                    {
                        if (tecla == 8 || tecla == 46) { DeletarNumero(TipoDeFormatacao); }
                        else
                        {
                            NumeroRetorno = "";
                            NumerosDigitados.Add(e.KeyChar.ToString());
                            foreach (string numero in NumerosDigitados)
                            {
                                NumeroRetorno += numero;
                            }
                            return NumeroRetorno;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas numeros",
                                "Digite apenas numeros",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return NumeroRetorno;
                    }
                    return null;


                    case 2:

                    if (char.IsDigit(e.KeyChar) || tecla == 8 || tecla == 46)
                    {
                        if (tecla == 8 || tecla == 46) { DeletarNumero(TipoDeFormatacao); return ValorDeRetorno; }
                        else { return Formatar(e.KeyChar.ToString()); }
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas numeros",
                                "Digite apenas numeros",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return null;
                    }


                    default:
                    {
                        Console.WriteLine("OPÇÂO INVALIDA VERIFIQUE SE O TIPO DE FORMATAÇÂO ESTÁ CORRETO");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public string ValidarLetra(KeyPressEventArgs e)
        {
            try
            {
                int tecla = (int)e.KeyChar;

                if (char.IsLetter(e.KeyChar) || tecla == 8 || tecla == 46)
                {
                    if (tecla == 8 || tecla == 46) { DeletarLetra(); }
                    else
                    {

                        LetrasDigitadas.Add(e.KeyChar.ToString());
                    }
                    NomeDeRetorno = "";
                    foreach (string letra in LetrasDigitadas)
                    {
                        NomeDeRetorno += letra;
                    }
                    return NomeDeRetorno;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas Letras",
                            "Digite apenas Letras",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return NomeDeRetorno;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public void DeletarNumero(int TipoDeDelecao)
        {
            switch (TipoDeDelecao)
            {
                case 1:
                if (NumerosDigitados.Count != 0)
                {
                    NumerosDigitados.Reverse();
                    NumerosDigitados.RemoveRange(0, 1);
                    NumerosDigitados.Reverse();
                }
                break;

                case 2:
                if (NumerosMonetariosDigitados.Count != 0)
                {
                    NumerosMonetariosDigitados.Reverse();
                    NumerosMonetariosDigitados.RemoveRange(0, 1);
                    NumerosMonetariosDigitados.Reverse();
                    Formatar(null);
                }
                break;

                default:
                Console.WriteLine("CONFIRME SE SELECIONOU A OPÇÃO CERTA PARA DELETAR");
                break;
            }


        }

        public void DeletarLetra()
        {
            if (LetrasDigitadas.Count != 0)
            {
                LetrasDigitadas.Reverse();
                LetrasDigitadas.RemoveRange(0, 1);
                LetrasDigitadas.Reverse();
            }
        }

    }
}

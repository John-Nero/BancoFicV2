using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BancoFicV2
{
    public class ValidacaoEFormatacao
    {
        string digito;
        List<string> NumerosDigitados = new List<string>();
        List<string> LetrasDigitadas = new List<string>();
        string ValorDeRetorno;
        string NomeDeRetorno;
        string ValorTotalString = "";

        public string Formatar(string digito)
        {
            try
            {

                double ValorTotalInt = 0;
                string valor = "";
                if (NumerosDigitados.Count == 5 || NumerosDigitados.Count == 6)
                {
                    ValorTotalString = ValorTotalString + digito;
                    ValorTotalString = Convert.ToInt32(ValorTotalString).ToString(@"0\.000\,00");

                    if (float.Parse(ValorTotalString) > 5000)
                    {

                        MessageBox.Show($"O limite de tranfêrencia On-Line é de 5.000,00(Cinco mil reais), para transfêrencia maiores visite uma agência",
                              "LIMITE DE TRANSFÊRENCIA ULTRAPASADO",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                        ValorTotalString = ValorTotalString.TrimEnd(char.Parse(digito));
                        goto avanco;
                    }

                }
                if (digito != null)
                { NumerosDigitados.Add(digito); }
            avanco:;
                if (NumerosDigitados.Count == 0)
                {
                    valor = "0,00";
                }
                else
                {
                    ValorTotalString = "";
                    foreach (string numero in NumerosDigitados)
                    {
                        ValorTotalString += numero;
                    }
                    valor = Convert.ToInt32(ValorTotalString).ToString(@"0\.000\,00");

                    ValorTotalInt = double.Parse(valor);

                }

                if (NumerosDigitados.Count != 0)
                {
                    valor = valor.TrimStart('0');
                    valor = valor.Trim('.');
                    valor = valor.TrimStart('0');
                }
                if (valor.Length == 3)
                {
                    return ValorDeRetorno = "0" + valor;
                }
                else { return ValorDeRetorno = valor; }

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

        public string ValidarNumerosParaValoresMonetarios(KeyPressEventArgs e)
        {
            try
            {
                int tecla = (int)e.KeyChar;

                if (!char.IsDigit(e.KeyChar) && tecla != 8 && tecla == 46)
                {
                    e.Handled = true;
                    MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas numeros",
                            "Digite apenas numeros",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                else if (char.IsDigit(e.KeyChar))
                {
                    return digito = e.KeyChar.ToString();
                }

                else if (tecla == 8 || tecla == 46)
                {
                    NumerosDigitados.Reverse();
                    NumerosDigitados.RemoveRange(0, 1);
                    NumerosDigitados.Reverse();
                    return digito = null;
                }
                return "";
            }
            catch
            {
                throw;
            }
        }

        public string ValidarLetras(KeyPressEventArgs e)
        {
            try
            {
                int tecla = (int)e.KeyChar;

                if (!char.IsLetter(e.KeyChar) || tecla != 8 && tecla == 46)
                {
                    e.Handled = true;
                    MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas Letras",
                            "Digite apenas Letras",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return NomeDeRetorno;
                }
                else if (tecla == 8 || tecla == 46)
                {
                    if (LetrasDigitadas != null)
                    {
                        LetrasDigitadas.Reverse();
                        LetrasDigitadas.RemoveRange(0, 1);
                        LetrasDigitadas.Reverse();
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
                    NomeDeRetorno = "";
                    LetrasDigitadas.Add(e.KeyChar.ToString());
                    foreach (string letra in LetrasDigitadas)
                    {
                        NomeDeRetorno += letra;
                    }
                    return NomeDeRetorno;
                }
            }
            catch { throw; }
        }

        public string ValidarNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (e != null)
                {
                    int tecla = (int)e.KeyChar;

                    if (!char.IsDigit(e.KeyChar) && tecla != 8 || tecla == 46)
                    {
                        e.Handled = true;
                        MessageBox.Show($"o caracter {e.KeyChar.ToString().ToUpper()} não é permitido. Por favor digite apenas numeros",
                                "Digite apenas numeros",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }


                    else if (tecla == 8 || tecla == 46)
                    {
                        if (NumerosDigitados.Count != 0)
                        {
                            NumerosDigitados.Reverse();
                            NumerosDigitados.RemoveRange(0, 1);
                            NumerosDigitados.Reverse();

                            goto avanco;
                        }
                    }
                    else { NumerosDigitados.Add(e.KeyChar.ToString()); }
                }

            avanco:;

                digito = "";

                foreach (string numero in NumerosDigitados)
                {
                    digito += numero;
                }

                return digito;

            }
            catch
            {
                throw;
            }
        }

        public void LimpaLista()
        {
            NumerosDigitados.Clear();
        }
    }
}

using System;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
            
    }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            Cliente cliente = new Cliente("Victor");
            this.conta.Titular = cliente;
            this.conta.Deposita(250.0);
            this.conta.Numero = 1;
            this.MostraConta();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

            string textoValorDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoValorDeposito);
            this.conta.Deposita(valorDeposito);
            this.MostraConta();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            this.conta.Saca(valorSaque);
            this.MostraConta();
        }

        private void MostraConta()
        {
            textoTitular.Text = this.conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoNumero.Text = Convert.ToString(this.conta.Numero);
        }
    }
}

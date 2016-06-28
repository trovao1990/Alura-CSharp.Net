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

        private void button1_Click(object sender, EventArgs e)
        {
          /*  Conta umaConta = new Conta();
            Cliente cliente1 = new Cliente("Vinicius");
            umaConta.Titular = cliente1;

            //cliente1.nome = "Vinicius"; // ou umaConta.titular.nome = "Vinicius";
            //cliente1.rg = "124742";
            umaConta.Deposita(2000.0);
            umaConta.Saca(500.0);
           
          
            MessageBox.Show("Nome do cliente" + umaConta.Titular.Nome);*/
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

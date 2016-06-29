using System;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        Conta contaSelecionada;
        Conta contaDestino;


        public Form1()
        {
            InitializeComponent();
            
         }

        private void Form1_Load(object sender, EventArgs e)
        {

            contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new Conta();
            Cliente c1 = new Cliente("Vinicius");
            Cliente c2 = new Cliente("Ranay");
           
            contas[0].Numero = 1;
            contas[0].Titular= c1;
            contas[0].Deposita(3000.0);

            contas[1].Numero = 2;
            contas[1].Titular = c2;
            contas[1].Deposita(3020.0);


            foreach (Conta c in contas)
            {
                comboOrigem.Items.Add(c.Numero);
            }
            foreach (Conta c in contas)
            {
                comboDestino.Items.Add(c.Numero);
            }

        }





        private void btnDeposito_Click(object sender, EventArgs e)
        {
           
            string textoValorDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoValorDeposito);
            contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Deposita(valorDeposito);
            this.MostraConta();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {    
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Saca(valorSaque);
            this.MostraConta();

        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboOrigem.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void MostraConta()
        {
            
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            contas[0].Deposita(10);
            contas[1].Deposita(100);

            /*for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("O saldo da conta "+ "é " + contas[i].Saldo);
            }

            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta " + "é " + conta.Saldo);
            } */
        }


        private void btnTotalizador_Click(object sender, EventArgs e)
        {
         /*   TotalizadorDeContas t = new TotalizadorDeContas();
            Conta c1 = new Conta();
            c1.Deposita(10.0);
            t.Adiciona(c1);

            Conta c2 = new Conta();
            c2.Deposita(120.0);
            t.Adiciona(c2);

            ContaPoupanca cp1 = new ContaPoupanca();
            cp1.Deposita(100.0);
            t.Adiciona(cp1);
            MessageBox.Show("Total de Contas: " + t.Total); */
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaSelecionada = this.BuscaContaSelecionada();
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            contaSelecionada = this.BuscaContaSelecionada();
            int indiceContaDestino = comboDestino.SelectedIndex;
            Conta contaDestino = this.contas[indiceContaDestino];
            string textoTransferencia = textoValor.Text;
            double valorTransferencia = Convert.ToDouble(textoTransferencia);
            contaSelecionada.Transfere(valorTransferencia, contaDestino);
            this.MostraConta();
        }
    }
}

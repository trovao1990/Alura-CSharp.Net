using System;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente cliente1 = new Cliente("Vinicius");
            umaConta.Titular = cliente1;

            //cliente1.nome = "Vinicius"; // ou umaConta.titular.nome = "Vinicius";
            //cliente1.rg = "124742";
            umaConta.Deposita(2000.0);
            umaConta.Saca(500.0);
           
          
            MessageBox.Show("Nome do cliente" + umaConta.Titular.Nome);
        }
    }
}

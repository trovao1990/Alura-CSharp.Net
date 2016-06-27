using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            umaConta.numero = 1;
            umaConta.titular = "Vinicius Trovão";
            umaConta.saldo = 2000.0;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Ranay Nobrega";
            outraConta.saldo = 1800.0;

            umaConta.Transfere(200, outraConta);


            MessageBox.Show("O saldo de Vinicius é " + umaConta.saldo);
            MessageBox.Show("O Saldo de Ranay é " + outraConta.saldo);       
        }
    }
}

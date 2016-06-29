﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.10;
        }

        public void CalculaRendimento()
        {
            this.Saldo += 100.0;
        }
        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}

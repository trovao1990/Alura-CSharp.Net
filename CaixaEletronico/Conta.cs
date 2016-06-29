using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Conta
    {
        public int Numero {
            get; set;
        }

        public double Saldo
        {
            get; protected set;
        }

        public Cliente Titular
        {
            get; set;
        }

        public abstract void Saca(double valor);



        public abstract void Deposita(double valor);
       

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}

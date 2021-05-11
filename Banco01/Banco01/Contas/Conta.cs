using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Banco01 {
    public class Conta {


        public Cliente titular;
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
        public virtual void Saca(double valor)
        {
           // if (valor <= this.Saldo)
           // {
                this.Saldo -= valor;
                //return true;
          //  }
           // return false;
        }
        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
        public double PegaSaldo()
        {
            return this.Saldo;
        }
        public void ColocaNumero(int numero)
        {
            this.Numero = numero;
        }

    }
}

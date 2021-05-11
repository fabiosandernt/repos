using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1 {
    class Conta {
        // numero, titular, e saldo são atributos do objeto
        public int numero;
        public string titular;
        public double saldo;
        //método
        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        public void Deposita(double valor)
        {
            if (valor >= 10.00)
            {
                this.saldo += valor;
            } else
            {
                System.Windows.Forms.MessageBox.Show("Só é permitido depósito acima de 10.00");
            }
        }
        public void Transfere(double valor, double contaDestino)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                contaDestino += valor;
            }
        }
    }
}
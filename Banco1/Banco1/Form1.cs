using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco1 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.numero = 1;
            conta.titular = "Victor";
            conta.saldo = 1000;
            //conta.saldo -= 50.0;
            //conta.Saca(10.0);

            Conta contaVictor = new Conta();
            contaVictor.titular = "Victo";
            contaVictor.numero = 1;
            contaVictor.saldo = 100.0;

            Conta contaGuilherme = new Conta();
                        
            bool deuCerto;
            deuCerto = conta.Saca(Convert.ToDouble(imputSaque.Text));
            

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso");
            } 
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            MessageBox.Show("saldo é:" + conta.saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposita(100);      
        }
    }
}

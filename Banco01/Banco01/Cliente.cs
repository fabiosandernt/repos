using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco01 {
    public class Cliente {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}

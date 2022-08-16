using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        //construtor sem parametro
        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
        }
        //construtor com parametro
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        //propriedade dos atributos para acesso
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        //método da classe ImprimeDados
        public abstract String ImprimeDados();
    }
}

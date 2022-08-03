using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLR1
{
    internal class Pessoa1
    {
        //Atributo da classe
        private string nome;
        private int idade;
        private double altura;
        private string Sexo;

        //Construtor sem parâmetro
        public Pessoa1()
        {
            this.nome = null;
            this.idade = 30;
            this.altura = 1.75;
            Sexo = null;
        }

        //Construtor com parâmetro
        public Pessoa1(string nome, int idade, double altura, char Sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();

        }

        //Propriedade do nome para acesso ao seu conteúdo
       public string Nome
        { 
            get { return this.nome; } 
            set { this.nome = value; }
        }
        
        public int Idade 
        {   
            get { return idade; } 
            set { idade = value; }
        }
        
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }
        }


        //Método que retorna um string contendo as informações da pessoa
        public override string ToString()
        {
            return(String.Format("Nome: {0}", nome));
        }

    }
}

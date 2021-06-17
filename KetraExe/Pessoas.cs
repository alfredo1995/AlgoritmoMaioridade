using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetraExe
{
    class Pessoas
    {
        //propriedades da class pessoas
        public string nome { get; set; }
        public int idade { get; set; }

        //construtor da class pessoa (sem parametro )
        public  Pessoas()
        {

        }

        //metodo da class pessoas (com parametro )
        public Pessoas(string nome, int idade)
        {
            //atribuidos os valores nas propriedades
            this.nome = nome;
            this.idade = idade;

        }

        //criar metodo ExibirDados q retornando os valores do atributos da propriedade
        public string ExibirDados()
        {
            return "Nome :"+ this.nome + " Idade: "  + this.idade;
        }



    }
}

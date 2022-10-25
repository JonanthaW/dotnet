using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass04 {
    class Produto {

        // Propriedades
        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; set;}


        // Construtores
        public Produto() { }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
        }

        //Metódo GET & SET , (Propriedades customizadas)
        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null)
                   _nome = value;
            }
        }

        // métodos de classe
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantity) {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }

        // override transforma a função de um método em outro criado apenas no escopo em que ele está.
        override public string ToString() {
            return ($"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

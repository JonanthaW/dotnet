using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass04 {
    internal class Produto {

        // Propriedades
        public string Nome;
        public double Preco;
        public int Quantidade;


        // métodos
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

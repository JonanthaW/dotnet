using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass9 {
    class ContaBancaria {
        public int Conta { get; private set; }
        public string Titular {
            get { return Titular; }
            set {
                if (value != null && value.Length > 1) {
                    Titular = value;
                }
            }
        }
        public double Valor { get; private set; }

        // constructor

        public ContaBancaria() { }
        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }
        public ContaBancaria(int conta, string titular, double valor) : this(conta, titular) {
            RealizarDeposito(valor);
        }


        //métodos

        public void RealizarDeposito(double valorDeposito) {
            Valor += valorDeposito;
        }
        public void RealizarSaque(double valorSaque) {
            Valor = (Valor - valorSaque) - 5;
        }


        public override string ToString() {
            return $"\nDados da conta atualizados:\nConta {Conta}, Titular: {Titular}, Saldo: R${Valor.ToString("F2")}\n";
        }

    
    }
}

# dotnet


### C# Built-IN data Types

* sbyte = -128 até 127
* short = -32768 até 32767
* int = -2147483648 até 2147483647
* long = -9223372036854775808 até 9223372036854775807
* byte = 0 até 255
* ushort = 0 até 65535
* uint = 0 até 4294967295
* ulong = 0 até 18446744073709551615
* char = Qualquer caractére Unicode
* bool = verdadeiro ou falso
* float = 1.5 × 10⁻⁴⁵ to 3.4 × 10³⁸ com 7 digitos de precisão
* double = 5.0 × 10⁻³²⁴ to 1.7 × 10³⁰⁸ com 15-16 digitos de precisão


### Restrições para nomes de variáveis

* Não pode começar com dígito: use uma letra ou _
* Não usar acentos ou til
* Não pode ter espaço em branco
* Usar nomes que tenham sentido


### Convenções C#

* Camel case: lastName(Parametros de métodos, variáveis dentro de métodos)
* Pascal Case: LastName(namespaces, classe, properties, métodos)
* Padrão: _lastName (Atributos internos de classe)

```
namespace Curso
	class ContaBancaria
	{						
		public string Titular {get; set;}
		private double _saldo;

		public void Deposito(double quantia)
		{
			_saldo += quantia;
		}

		public double GetSaldo()
		{
			return _saldo;
		}
	}
}
```

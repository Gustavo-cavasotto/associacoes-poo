using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes_pt_2
{
    public class Moto : Veiculo
    {
        public Moto (string modelo) : base(modelo){ /* base(modelo) é uma forma de dizer que a classe "Gato" está herdando da classe "Animal" e que ela está passando um valor para o construtor da classe base. Sem esse código, o compilador não saberia como inicializar a classe base e geraria um erro de compilação.*/

        }

        public override string Acelerar()
        {
            return "Acelerando Moto!";
        }
    }
}
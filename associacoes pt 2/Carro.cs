using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes_pt_2
{
    public class Carro : Veiculo
    {
        public Carro (string modelo) : base(modelo){

        }

        public override string Acelerar(){
            return "Acelerando Carro!";
        }
    }
}
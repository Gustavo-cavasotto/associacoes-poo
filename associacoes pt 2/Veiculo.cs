using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes_pt_2
{
    public class Veiculo
    {
        public string modelo {get; protected set;}
        
        public Veiculo(string modelo){
            this.modelo = modelo;
        }

        public virtual string Acelerar(){
            return "Acelerando Veículo";
        }
    }
}
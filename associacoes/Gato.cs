using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{

    public class Gato : Animal
    {
        public Gato(string nome) : base(nome) /*base é utilizado para dizer que estamos utilizando o construtor da classe base*/
        {
        }

        public override string Falar() /*override para dizer que estão sobscrevendo um método da classe base */
        {
            return "Miau!";
        }
    }
}
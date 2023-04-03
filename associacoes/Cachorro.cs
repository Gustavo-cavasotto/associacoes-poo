using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{

    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override string Falar()
        {
            return "Au au!";
        }
    }
}
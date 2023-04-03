using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public abstract class Animal /*Adicionamos abstract para tornar a classe Animal impossivel de instanciar */ 
    {
        public string nome {get; protected set;}
        
        public Animal(string nome){
            this.nome = nome;
        }

        public abstract string Falar(); /*Crio a classe falar em animal, para dizer que todas as subclasses precisam possuir*/
    }
}
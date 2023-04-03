using System;

namespace Personagens
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public string[] Poderes { get; set; }

        public Personagem(string nome, int forca, int inteligencia, string[] poderes)
        {
            Nome = nome;
            Forca = forca;
            Inteligencia = inteligencia;
            Poderes = poderes;
        }

        public virtual void Lutar()
        {
            Console.WriteLine($"O personagem {Nome} está lutando!");
        }
    }

    public class Heroi : Personagem
    {
        public Heroi(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes)
        {
        }

        public override void Lutar()
        {
            Console.WriteLine($"O herói {Nome} está lutando!");
            Console.WriteLine($"Força: {Forca}, Inteligência: {Inteligencia}");
        }
    }

    public class Vilao : Personagem
    {
        public Vilao(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes)
        {
        }

        public override void Lutar()
        {
            Console.WriteLine($"O vilão {Nome} está lutando!");
            Console.WriteLine($"Força: {Forca}, Inteligência: {Inteligencia}");
        }
    }

    public class SuperHeroi : Heroi
    {
        public SuperHeroi(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes)
        {
        }

        public void SuperPoder()
        {
            Console.WriteLine($"O super-herói {Nome} está usando seu super poder!");
        }
    }

    public class SuperVilao : Vilao
    {
        public SuperVilao(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes)
        {
        }

        public void SuperPoder()
        {
            Console.WriteLine($"O super-vilão {Nome} está usando seu super poder!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem("John Doe", 10, 10, new string[] { "Super força" });
            Heroi heroi = new Heroi("Superman", 100, 80, new string[] { "Super força", "Visão de raio X" });
            Vilao vilao = new Vilao("Coringa", 20, 90, new string[] { "Mente brilhante", "Habilidade em armas" });
            SuperHeroi superHeroi = new SuperHeroi("Homem de Ferro", 60, 100, new string[] { "Inteligência sobre-humana", "Tecnologia avançada" });
            SuperVilao superVilao = new SuperVilao("Thanos", 90, 30, new string[] { "Infinita força", "Manopla do Infinito" });

            personagem.Lutar();
            heroi.Lutar();
            vilao.Lutar();
            superHeroi.Lutar();
           
            

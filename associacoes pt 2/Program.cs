using associacoes_pt_2;
public class Program
    {
        public static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Veículo genérico");
            veiculo.Acelerar(); // imprime "Acelerando veículo!"

            Carro carro = new Carro("Fusca");
            Console.WriteLine(carro.Acelerar());

            Moto moto = new Moto("CG");
            Console.WriteLine(moto.Acelerar());
        }
    }
using System.Globalization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Realiza a inclusão de veículo que chegou ao estacionamento (Concluído)
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // O usuário informa a placa do veículo estacionado (Concluído)
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // O usuário informa a quantidade de horas que o veículo permaneceu estacionado (Concluído)
                int horas = Convert.ToInt32(Console.ReadLine());

                // Calcula o valor total (Concluído)
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remove o veículo (Concluído)
                veiculos.Remove(placa);

                // Exibe a placa do veículo e o preço total a pagar
                CultureInfo cultura = new CultureInfo("pt-BR");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de {valorTotal.ToString("C", cultura)}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                // Faz a listagem dos veículos estacionados (Concluído)
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

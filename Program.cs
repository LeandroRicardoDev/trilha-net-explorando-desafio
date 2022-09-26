using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa pessoa = new Pessoa();
Reserva reserva = new Reserva();

// Menu
Console.WriteLine("Menu do Projeto de Hospedagem");
Console.WriteLine("Digite o que deseja fazer:");
Console.WriteLine("---------------------");
Console.WriteLine("1 - Adicionar Hóspedes");

Console.WriteLine();
Console.Write("Digite o número correspondente: ");
int Menu = int.Parse(Console.ReadLine());
Console.WriteLine();

int diasReservados = 0;
if (Menu == 1)
{
    Console.WriteLine("Quantos Hóspedes deseja adicionar?");

    int quantidadeHospedes = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (quantidadeHospedes <= 2)
    {
        for (int i = 1; i <= quantidadeHospedes; i++)
        {
            Console.WriteLine("Nome do hóspede: " + i);
            pessoa = new Pessoa(Console.ReadLine());
            hospedes.Add(pessoa);
            Console.WriteLine();

        }
        Console.WriteLine($"Quantos dias de reserva?");
        diasReservados = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    else
    {
        throw new Exception("Esta suíte não está disponível devido a quantidade de hóspedes, favor trocar a suíte.");
    }
}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total das diárias: {reserva.CalcularValorDiaria()}");
Console.WriteLine();
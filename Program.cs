using System.Globalization;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

int opcao = 1;
do
{
    try
    {
        Console.Clear(); //TODO: Problema no VSCode durante o Debug | Está disparando Exception
    }
    catch
    {
        Console.WriteLine("");
    }
    Console.WriteLine("Bem Vindo ao nosso sistema de Hospedagem do Hotel C.NET");
    Console.WriteLine("Por favor selecione a opção desejada: ");
    Console.WriteLine("");
    Console.WriteLine("1 - Listar Suítes");
    Console.WriteLine("2 - Realizar Cadastro de Hóspedes");
    Console.WriteLine("3 - Criar uma Nova Reserva");
    Console.WriteLine("4 - Finalizar Reserva");
    Console.WriteLine("Digite 0 para sair");
    Console.WriteLine("");
    Console.Write("Opção: ");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            //TODO: Lista todas as suites lidas do arquivo de configuração, mostrando o status: Reservada ou não.
            break;
        case 2:
            //TODO: Realizar cadastro de Hóspede e persistir em arquivo, cadastro com identificador unico CPF.
            break;
        case 3:
            //TODO: criar uma nova reserva solicitando CPF para cadastro de hospedes e solicitar seleção de suite.
            break;
        case 4:
            //TODO: finalizar uma reserva, liberar suite e passar valor para o cliente
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 0);

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List < Pessoa > hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
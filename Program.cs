using Contrato.Entidades;
using Contrato.Entidades.Enums;

namespace Contrato {
    internal class Program {
        static void Main(string[] args) {
            string nome;
            string departNome;
            float salarioBase;
            int nContratos;
            string mesAno;
            int mes;
            int ano;

            Console.WriteLine("Nome do departamento: ");
            departNome = Console.ReadLine();

            Console.WriteLine("Nome do trabalhador: ");
            nome = Console.ReadLine();

            Console.WriteLine("Nivel (Junior/Intermediario/Senior):");
            Console.WriteLine("Digitar o nivel completo.");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.WriteLine("Salario Base: ");
            salarioBase = float.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(nome);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);

            Console.WriteLine("Quantos contratos para o trabalhador?: ");
            nContratos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nContratos; i++) {
                Console.WriteLine($"Entre com os dados do #{i} contrato");
                Console.WriteLine("Data (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora:");
                float valorPorHora;
                valorPorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de horas: ");
                int horas;
                horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(date, valorPorHora, horas);
                trabalhador.AdicionarContratos(contrato);
            }
            Console.WriteLine("Entre com o mes e ano no formato (MM/YY): ");
            mesAno = Console.ReadLine();
            mes = int.Parse(mesAno.Substring(0, 2));
            ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Renda com: " + mesAno + ":" + trabalhador.Renda(ano,mes));

        }
    }
}
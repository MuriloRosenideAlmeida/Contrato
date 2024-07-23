using Contrato.Entidades.Enums;
using Microsoft.VisualBasic;

namespace Contrato.Entidades {
    internal class Trabalhador {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public float SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador(string nome, NivelTrabalhador nivel, float salarioBase, Departamento departamento) {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AdicionarContratos(HoraContrato contrato) {
            Contratos.Add(contrato);
        }
        public void RemoveContratos(HoraContrato contrato) {
            Contratos.Remove(contrato);
        }
        public float Renda (int ano, int mes) {
            float soma = SalarioBase;
            foreach(HoraContrato contrato in Contratos) { 
                if(contrato.Date.Year == ano && contrato.Date.Month == mes) {
                    soma = soma + contrato.ValorTotal();
                } 
            }
            return soma;
        }
    }
}

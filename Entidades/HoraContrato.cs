namespace Contrato.Entidades {
    internal class HoraContrato {
        public DateTime Date { get; set; }
        public float ValorPorHora  { get; set; }
        public int Horas { get; set; }

        public HoraContrato(DateTime date, float valorPorHora, int horas) {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }
        public float ValorTotal() {
            return  Horas * ValorPorHora;
        }
    }
}

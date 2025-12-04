namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataFim { get; set; } = DateTime.Today;
        public int NumeroParticipantes { get; set; } = 0;
        public string Local { get; set; } = string.Empty;
        public decimal CustoPorParticipante { get; set; } = 0m;

        public int DuracaoDias => (DataFim.Date - DataInicio.Date).Days + 1;
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}

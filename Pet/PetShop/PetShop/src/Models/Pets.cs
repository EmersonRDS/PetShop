namespace PetShop.src.Models
{
    internal class Pets
    {
        public int IdTutor { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public bool Vacinado { get; set; }
        public string TipoDePelagem { get; set; }

        public string Porte { get; set; }

        public bool PossuiAlergia { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Observacoes { get; set; }
    }
}

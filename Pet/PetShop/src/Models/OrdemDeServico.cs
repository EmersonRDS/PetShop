using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.src.Models
{
    public class OrdemDeServico
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdPet {  get; set; }
        public int EmAberto { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data {  get; set; }
        public string Procedimento { get; set; }

    }
}

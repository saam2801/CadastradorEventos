using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastradorEventos.Models
{
    public class Cadastrado {
        public String descricao { get; set; }
        public String NomeEvento { get; set; }
        public int qtd_Convidados { get; set; }
        public int entradaPreco { get; set; }
        public DateTime comecoFesta { get; set; }
        public DateTime fimFesta { get; set; }
        public int tempoFesta { get => fimFesta.Subtract(comecoFesta).Days; }
    }
}

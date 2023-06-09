using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeChromes.Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public Colaborador Responsavel { get; set; }
        public Equipamento equipamento { get; set; }
        public int Quantidade { get; set; }
        public string Sala { get; set; }
        public string Turma { get; set; }
        public string Retirada { get; set; }
        public string Devolução { get; set; }
        public bool Finalizado { get; set; }
    }
}

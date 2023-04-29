using System.ComponentModel.DataAnnotations;

namespace Ticket.Shared.Entities
{
    public class Tickete
    {
        public int Id { get; set; }
        public DateTime? useDate { get; set; } = null;
        public bool isUsed { get; set; }
        public String? goalType { get; set; }=null;
      
    }
}

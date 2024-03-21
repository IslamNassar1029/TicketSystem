using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Enums;

namespace TicketSystem.DAL.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool IsClosed { get; set; }
        public Severity Severity { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; } = null!;
    }
}

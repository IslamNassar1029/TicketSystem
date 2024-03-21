using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Enums;

namespace TicketSystem.BL.ViewModels.Tickets
{
    public class TicketAddVM
    {
        [RegularExpression("^[\\w\\.-]+@[a-zA-Z\\d-]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public bool IsClosed { get; set; }
        [Required]
        public Severity Severity { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}

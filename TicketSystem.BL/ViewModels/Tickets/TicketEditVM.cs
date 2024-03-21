using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Enums;

namespace TicketSystem.BL.ViewModels.Tickets
{
    public record TicketEditVM
    (   int Id,
        [RegularExpression("^[\\w\\.-]+@[a-zA-Z\\d-]+\\.[a-zA-Z]{2,}$")]
        string Email ,
        [Required]
         DateTime CreatedDate,
        [Required]
         bool IsClosed ,
        [Required]
       Severity Severity ,
        [Required]
       int DepartmentId 
    );
}

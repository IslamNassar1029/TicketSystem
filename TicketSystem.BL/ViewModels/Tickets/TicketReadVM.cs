using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Enums;

namespace TicketSystem.BL.ViewModels.Tickets
{
    public record TicketReadVM(int Id,
    string Email,
    DateTime CreatedDate,
    bool IsClosed,
    Severity Severity,
    int DepartmentId);

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Models;
using TicketSystem.DAL.Repositories.Generic;

namespace TicketSystem.DAL.Repositories.Tickets
{
    public interface ITicketRepository :IGenericRepository<Ticket>
    {
        Ticket? GetWithDepartmentById(int id);
    }
}

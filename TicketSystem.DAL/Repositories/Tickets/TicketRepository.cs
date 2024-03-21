using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Context;
using TicketSystem.DAL.Data.Models;
using TicketSystem.DAL.Repositories.Generic;

namespace TicketSystem.DAL.Repositories.Tickets
{
    public class TicketRepository :GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(SystemContext systemContext):base(systemContext) { }

        public Ticket? GetWithDepartmentById(int id)
        {
            return _context.Set<Ticket>()
                .AsNoTracking()
                .Include(t=>t.Department)
                .FirstOrDefault(t=>t.Id==id);
        }
    }
}

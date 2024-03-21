using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Context;
using TicketSystem.DAL.Data.Models;
using TicketSystem.DAL.Repositories.Generic;
using TicketSystem.DAL.Repositories.Tickets;

namespace TicketSystem.DAL.Repositories.Departments
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SystemContext systemContext) : base(systemContext) { }
    }
}

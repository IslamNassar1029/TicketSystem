using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Models;
using TicketSystem.DAL.Repositories.Generic;

namespace TicketSystem.DAL.Repositories.Departments
{
    public interface IDepartmentRepository:IGenericRepository<Department>
    {
    }
}

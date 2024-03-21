using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Repositories.Departments;
using TicketSystem.DAL.Repositories.Tickets;

namespace TicketSystem.DAL
{
    public interface IUnitOfWork
    {
        public IDepartmentRepository DepartmentRepository { get; }
        public ITicketRepository TicketRepository { get; }

        void SavaChanges();


    }
}

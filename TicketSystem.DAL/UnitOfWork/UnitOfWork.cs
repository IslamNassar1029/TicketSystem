using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DAL.Data.Context;
using TicketSystem.DAL.Repositories.Departments;
using TicketSystem.DAL.Repositories.Tickets;

namespace TicketSystem.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SystemContext _systemContext;

        public IDepartmentRepository DepartmentRepository { get; }
        public ITicketRepository TicketRepository { get; }

        public UnitOfWork(IDepartmentRepository departmentRepository, ITicketRepository ticketRepository,SystemContext systemContext)
        {
            DepartmentRepository = departmentRepository;
            TicketRepository = ticketRepository;
            _systemContext = systemContext;
        }

        public void SavaChanges()
        {
            _systemContext.SaveChanges();
        }
    }
}

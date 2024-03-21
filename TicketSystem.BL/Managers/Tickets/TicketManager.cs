using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.BL.ViewModels.Tickets;
using TicketSystem.DAL;
using TicketSystem.DAL.Data.Models;

namespace TicketSystem.BL.Managers.Tickets
{
    public class TicketManager : ITicketManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public TicketManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(TicketAddVM ticketAddVM)
        {

            var newTicket = new Ticket()
            {
                Email = ticketAddVM.Email,
                CreatedDate = ticketAddVM.CreatedDate,
                DepartmentId = ticketAddVM.DepartmentId,
                Severity = ticketAddVM.Severity,
                IsClosed = ticketAddVM.IsClosed,
            };
            _unitOfWork.TicketRepository.Add(newTicket);
            _unitOfWork.SavaChanges();


        }

        public void Delete(int id)
        {
            var ticket = _unitOfWork.TicketRepository.GetById(id);
            if (ticket is null) { return; }
            _unitOfWork.TicketRepository.Delete(ticket);
            _unitOfWork.SavaChanges();
        }

        public void Edit(TicketEditVM ticketEditVM)
        {
            var ticket = _unitOfWork.TicketRepository.GetById(ticketEditVM.Id);
            if (ticket is null) { return; }
            ticket.Email = ticketEditVM.Email;
            ticket.Severity = ticketEditVM.Severity;
            ticket.CreatedDate = ticketEditVM.CreatedDate;
            ticket.DepartmentId = ticketEditVM.DepartmentId;  
            ticket.IsClosed = ticketEditVM.IsClosed;
            _unitOfWork.TicketRepository.Update(ticket);
            _unitOfWork.SavaChanges();
        }

        public IEnumerable<TicketReadVM> GetAll()
        {
            return _unitOfWork.TicketRepository.GetAll()
                .Select(t => new TicketReadVM
                (t.Id, t.Email, t.CreatedDate, t.IsClosed, t.Severity, t.DepartmentId));
        }

        public TicketEditVM? GetForEditById(int id)
        {
            var t = _unitOfWork.TicketRepository.GetById(id);
            if (t is null) { return null; }

            return new TicketEditVM(t.Id, t.Email, t.CreatedDate, t.IsClosed, t.Severity, t.DepartmentId);
        }

        public TicketDetailsVM GetWithDepartmentById(int id)
        {
            var t=_unitOfWork.TicketRepository.GetWithDepartmentById(id);

            if (t is null) { return null!; }    

            return new TicketDetailsVM (t.Id, t.Email, t.CreatedDate, t.IsClosed, t.Severity, t.DepartmentId,t.Department.Name);
        }
    }
}

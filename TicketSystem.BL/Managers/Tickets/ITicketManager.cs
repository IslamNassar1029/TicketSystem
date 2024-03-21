using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.BL.ViewModels.Tickets;

namespace TicketSystem.BL.Managers.Tickets
{
    public interface ITicketManager
    {
        IEnumerable<TicketReadVM> GetAll();
        TicketDetailsVM GetWithDepartmentById(int id);

        void Add(TicketAddVM ticketAddVM);
        TicketEditVM? GetForEditById(int id);
        void Edit(TicketEditVM ticketEditVM);
        void Delete(int id);
    }
}

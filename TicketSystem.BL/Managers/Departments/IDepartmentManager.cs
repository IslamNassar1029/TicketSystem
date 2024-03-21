using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.BL.ViewModels;

namespace TicketSystem.BL.Managers.Departments
{
    public interface IDepartmentManager
    {
        IEnumerable<Option> GetAllAsOptions();
    }
}

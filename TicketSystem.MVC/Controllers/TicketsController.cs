using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicketSystem.BL.Managers.Departments;
using TicketSystem.BL.Managers.Tickets;
using TicketSystem.BL.ViewModels.Tickets;

namespace TicketSystem.MVC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketManager _ticketManager;
        private readonly IDepartmentManager _departmentManager;

        public TicketsController(ITicketManager ticketManager
            ,IDepartmentManager departmentManager
            )
        {
            _ticketManager = ticketManager;
            _departmentManager = departmentManager;
            
        }
        public IActionResult Index()
        {
            DateTime? created = TempData[Constants.TempDataKeys.Id] as DateTime?;
            ViewData[Constants.TempDataKeys.Id] = created;
            var tickets = _ticketManager.GetAll();
            return View(tickets);
        }
        public IActionResult Details(int id)
        { 
            var ticket = _ticketManager.GetWithDepartmentById(id);
            return View(ticket);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewData[Constants.ViewDataKeys.Departments] = _departmentManager
                .GetAllAsOptions()
                .Select(d=> new SelectListItem (d.Name,d.Value));
            return View();
        }

        [HttpPost]
        public IActionResult Add(TicketAddVM ticketAddVM)
        {
            ViewData[Constants.ViewDataKeys.Departments] = _departmentManager
                .GetAllAsOptions()
                .Select(d => new SelectListItem(d.Name, d.Value));
            if (!ModelState.IsValid)
            {
                return View(ticketAddVM);
            }

            _ticketManager.Add(ticketAddVM);
            TempData[Constants.TempDataKeys.Id] =ticketAddVM.CreatedDate;
            return RedirectToAction(nameof(Index));


        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _ticketManager.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData[Constants.ViewDataKeys.Departments] = _departmentManager
                .GetAllAsOptions()
                .Select(d => new SelectListItem(d.Name, d.Value));
            var ticket=_ticketManager.GetForEditById(id);
            return View(ticket);
        }
        [HttpPost]
        public IActionResult Edit(TicketEditVM ticketEditVM)
        {
            ViewData[Constants.ViewDataKeys.Departments] = _departmentManager
                .GetAllAsOptions()
                .Select(d => new SelectListItem(d.Name, d.Value));

            if (!ModelState.IsValid)
            {
                return View(ticketEditVM);
            }
            _ticketManager.Edit(ticketEditVM);
            TempData[Constants.TempDataKeys.Id] = ticketEditVM.CreatedDate;
            return RedirectToAction(nameof(Index));
        }
    }
}

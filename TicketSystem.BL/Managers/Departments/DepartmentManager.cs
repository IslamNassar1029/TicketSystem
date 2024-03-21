using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.BL.ViewModels;
using TicketSystem.DAL;
using TicketSystem.MVC.Models.AppConfigration;

namespace TicketSystem.BL.Managers.Departments
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IOptions<DataConfigration> _options;

        public DepartmentManager(IUnitOfWork unitOfWork,IConfiguration configuration,IOptions<DataConfigration> options) 
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _options = options;
        }
        public IEnumerable<Option> GetAllAsOptions()
        {
           var data= _options.Value;
            var da = _configuration;
            return _unitOfWork.
                DepartmentRepository
                .GetAll()
                .Select(d => new Option(d.Name, d.Id.ToString()));
        }
    }
}

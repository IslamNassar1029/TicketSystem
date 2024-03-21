using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TicketSystem.MVC.Models.AppConfigration;

namespace TicketSystem.BL.Helpers
{
    public class Utilities : IUtilities
    {
        private DataConfigration _options;

        public Utilities(IOptionsMonitor<DataConfigration> options) {
            _options = options.CurrentValue;
        }
        public string GetValueFromConfig() 
        {
            var x= JsonSerializer.Serialize(_options);
            return x;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Programming_Timeline.Pages
{
    public class ReactModel : PageModel
    {
        private readonly ILogger<ReactModel> _logger;

        public ReactModel(ILogger<ReactModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;

namespace ISSF2020.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            /*
            ViewData["MyNumber"] = 42;
            ViewData["MyString"] = "Hello World";
            */
            ViewData["User"] = HttpContext.Session.GetString("User");

        }
    }
}

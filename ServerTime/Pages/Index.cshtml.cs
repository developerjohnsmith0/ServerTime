using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerTime.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
             string currentTime = DateTime.Now.ToString("hh:mm tt");
             ViewData["CurrentTime"] = currentTime;

            string myMessage = "Hello World";
            ViewData["MyText"] = myMessage;
        }
    }
}

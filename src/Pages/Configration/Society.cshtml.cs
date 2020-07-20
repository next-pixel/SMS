using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Company.WebApplication1.Pages.Configration
{
    public class SocietyModel : PageModel
    {
        public Society society { get; set; }

        public void OnGet()
        {

        }
    }
}
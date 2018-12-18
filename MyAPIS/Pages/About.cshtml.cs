using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datas;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyAPIS.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            var Userdd = new User();
            Userdd.Name = "12355";
            Message = "Your application description page" + Userdd.Name;
        }
    }
}

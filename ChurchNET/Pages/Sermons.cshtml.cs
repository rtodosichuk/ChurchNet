using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ChurchNET.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ChurchNET.Pages
{
    public class SermonsModel : PageModel
    {
        private IHostingEnvironment _env;
        [BindProperty]
        public List<Sermon> Sermons { get; set; }

        public SermonsModel(IHostingEnvironment env)
        {
            _env = env;
        }

        public void OnGet()
        {
            var slist = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "wwwroot/sermonlist.json"));
            Sermons = JsonConvert.DeserializeObject<List<Sermon>>(slist);
        }
    }
}
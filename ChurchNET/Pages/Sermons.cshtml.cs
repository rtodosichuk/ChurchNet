using ChurchNET.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ChurchNET.Pages
{
    /// <summary>
    /// Sermon List Page
    /// </summary>
    public class SermonsModel : PageModel
    {
        private IWebHostEnvironment _env;

        /// <summary>
        /// Sermons List that is sent to the view. 
        /// </summary>
        [BindProperty]
        public List<Sermon> Sermons { get; set; }

        public SermonsModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        /// <summary>
        /// Load the list of sermons from the sermonlist.json file and set the list to be set to the view.
        /// </summary>
        public void OnGet()
        {
            var slist = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "wwwroot/sermonlist.json"));
            Sermons = JsonConvert.DeserializeObject<List<Sermon>>(slist);
        }
    }
}
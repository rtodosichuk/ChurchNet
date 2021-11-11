using ChurchNET.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
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
        private IConfiguration _configuration;

        /// <summary>
        /// Sermons List that is sent to the view. 
        /// </summary>
        //[BindProperty]
        //public List<Sermon> Sermons { get; set; }

        public string YouTubeEmdedLiveSteam { get; set; }
        public string YouTubeDirectLiveSteam { get; set; }
        public string YouTubeChannel { get; set; }

        public SermonsModel(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
            YouTubeEmdedLiveSteam = _configuration["AppSettings:YouTube:EmdedLiveSteam"];
            YouTubeDirectLiveSteam = _configuration["AppSettings:YouTube:DirectLiveSteam"];
            YouTubeChannel = _configuration["AppSettings:YouTube:Channel"];
        }

        /// <summary>
        /// Load the list of sermons from the sermonlist.json file and set the list to be set to the view.
        /// </summary>
        public void OnGet()
        {
            //var slist = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "wwwroot/sermonlist.json"));
            //Sermons = JsonConvert.DeserializeObject<List<Sermon>>(slist);
        }
    }
}
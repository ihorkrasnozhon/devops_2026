using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace devops.Pages
{
    public class IndexModel : PageModel
    {
        public string OS { get; set; }
        public string MachineName { get; set; }
        public string Time { get; set; }

        public void OnGet()
        {
            OS = RuntimeInformation.OSDescription;
            MachineName = Environment.MachineName;
            Time = DateTime.Now.ToString("F");
        }
    }
}
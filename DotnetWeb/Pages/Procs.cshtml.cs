using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ProcsModel : PageModel
{
    public void OnGet()
    {
        ViewData["procs"] = Process.GetProcesses();
    }
}
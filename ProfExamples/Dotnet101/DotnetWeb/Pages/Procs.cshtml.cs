using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcsModel : PageModel
{
    public void OnGet()
    {
        ViewData["procs"] = Process.GetProcesses();
    }
}


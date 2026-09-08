using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcDetailsModel : PageModel
{
    public void OnGet(int id)
    {
        ViewData["proc"] = Process.GetProcessById(id);
    }
}


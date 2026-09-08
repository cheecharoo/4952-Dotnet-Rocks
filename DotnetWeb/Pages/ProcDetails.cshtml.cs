using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ProcDetailsModel : PageModel
{
    public IActionResult OnGet(int id)
    {
        try
        {
            ViewData["proc"] = Process.GetProcessById(id);
            return Page();
        }
        catch (ArgumentException)
        {
            return NotFound();
        }
    }
}
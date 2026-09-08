using DotnetLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetWeb.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? Year { get; private set; }

    public Student? Student {get; set; }

    public void OnGet()
    {
        ViewData["bcit"] = "Burnaby Campus";
        Year = "2027";
        Student = new() { 
            FirstName = "Medhat", 
            LastName = "Elmasry", 
            ID = 123456, 
            School = "Software Development" 
        };
    }
}

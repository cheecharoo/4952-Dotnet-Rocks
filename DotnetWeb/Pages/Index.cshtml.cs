using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetLib;

namespace DotnetWeb.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? Year { get; set; }

    [BindProperty]
    public Student? Student { get; set; }

    public void OnGet()
    {
        ViewData["bcit"] = "Burnaby Campus";
        Year = "2027";
        Student = new()
        {
            ID = 12345,
            FirstName = "John",
            LastName = "Doe",
            School = "BCIT"
        };
    }
}

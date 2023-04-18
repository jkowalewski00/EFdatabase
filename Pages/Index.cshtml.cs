using EFdatabase.Models;
using EFdatabase.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace EFdatabase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]

        public Person Person { get; set; }

        public IList<Person> People { get; set; }

        public IActionResult OnPost()
        {
            People = _context.Person.ToList();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Person.Add(Person);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }

        public void OnGet()
        {
            People = (_context.Person).OrderBy(p => p.LastName).ToList();
        }
    }
}
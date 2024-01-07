using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Grades.Pages
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Credit> Credits { get; set; }

        public async Task OnGetAsync()
        {
            Credits = await _context.Credits.ToListAsync();
        }
    }
}

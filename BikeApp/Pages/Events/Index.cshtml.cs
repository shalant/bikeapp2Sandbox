using BikeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BikeApp.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly BikeApp.Data.ApplicationDbContext _context;

        public IndexModel(BikeApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Events != null)
            {
                Event = await _context.Events.ToListAsync();
            }
        }
    }
}




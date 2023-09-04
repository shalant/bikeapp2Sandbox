using BikeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BikeApp.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly BikeApp.Data.ApplicationDbContext _eventContext;

        public CreateModel(BikeApp.Data.ApplicationDbContext eventContext)
        {
            _eventContext = eventContext;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _eventContext.Events == null || Event == null)
            {
                return Page();
            }

            _eventContext.Events.Add(Event);
            await _eventContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

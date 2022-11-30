using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Data;
using Bigfoot.Models;
using Microsoft.Data.SqlClient;

namespace Bigfoot.Pages.Team
{
    public class IndexModel : PageModel
    {
        private readonly Bigfoot.Data.BigfootContext _context;

        public IndexModel(Bigfoot.Data.BigfootContext context)
        {
            _context = context;
        }
        public IList<Sightings> Sightings { get;set; } = default!;
        public string NameSort { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public string CurrentFilter { get; set; }





        public async Task OnGetAsync(string sortOrder, string filterString)
        {
            
            NameSort = String.IsNullOrEmpty(sortOrder) ? "desc" : "";
            if (_context.Sightings != null)
            {
                Sightings = await _context.Sightings.ToListAsync();
            }
            IQueryable<Sightings> title = from l in _context.Sightings
                        select l;

            if (sortOrder == "desc")
            {
                title = title.OrderByDescending(m => m.State);
            }
            else
            {
                title = title.OrderBy(m => m.State);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                title = title.Where(l => l.State.Contains(SearchString));
            }


             /*titles = from s in _context.Sightings select s;*/
            CurrentFilter = filterString;

            if (!String.IsNullOrEmpty(filterString))
            {
                title = title.Where(s => s.State.Contains(filterString));

            }

            Sightings = await title.ToListAsync();
            
        }


    }
}

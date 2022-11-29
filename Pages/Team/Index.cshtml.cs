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

        public string NameSort { get; set; }

        public IList<Sightings> Sightings { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "desc" : "";
            if (_context.Sightings != null)
            {
                Sightings = await _context.Sightings.ToListAsync();
            }
            var title = from l in _context.Sightings
                        select l;

            if (sortOrder == "desc")
            {
                title = title.OrderByDescending(m => m.Location);
            }
            else
            {
                title = title.OrderBy(m => m.Location);
            }


             Sightings = await title.ToListAsync();
            
        }


    }
}

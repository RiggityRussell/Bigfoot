using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Data;
using Bigfoot.Models;

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

        public async Task OnGetAsync()
        {
            if (_context.Sightings != null)
            {
                Sightings = await _context.Sightings.ToListAsync();
            }
        }


    }
}

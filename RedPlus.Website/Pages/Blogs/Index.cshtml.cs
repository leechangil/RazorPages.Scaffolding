using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedPlus.Website.Data;
using RedPlus.Website.Models;

namespace RedPlus.Website.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private readonly RedPlus.Website.Data.ApplicationDbContext _context;

        public IndexModel(RedPlus.Website.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}

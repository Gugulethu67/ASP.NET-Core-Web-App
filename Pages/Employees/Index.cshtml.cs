using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employees_DashBoard.Data;
using Employees_DashBoard.Model;
using Microsoft.AspNetCore.Authorization;

namespace Employees_DashBoard.Pages.Empoyees
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Employees_DashBoard.Data.ApplicationDbContext _context;

        public IndexModel(Employees_DashBoard.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}

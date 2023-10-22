/**************************************************************************
 **
8-2023 Jürgen Mülbert
 **
 ** SPDX-License-Identifier: EUPL-1.2
 **
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AnniversaryReminder.Data;

using jmbdeData.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnniversaryReminder.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly AnniversaryReminder.Data.ApplicationDbContext _context;

        public CreateModel(AnniversaryReminder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToPage("./Index");
        }
    }
}

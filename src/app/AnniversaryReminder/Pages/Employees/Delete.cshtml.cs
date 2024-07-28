/**************************************************************************
 **
 ** SPDX-FileCopyrightText: © 2018-2023 Jürgen Mülbert
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
using Microsoft.EntityFrameworkCore;

namespace AnniversaryReminder.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly AnniversaryReminder.Data.ApplicationDbContext _context;

        public DeleteModel(AnniversaryReminder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context
                .Employee.FirstOrDefaultAsync(m => m.EmployeeId == id)
                .ConfigureAwait(false);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FindAsync(id).ConfigureAwait(false);

            if (Employee != null)
            {
                _context.Employee.Remove(Employee);
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }

            return RedirectToPage("./Index");
        }
    }
}

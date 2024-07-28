/**************************************************************************
 **
 ** SPDX-FileCopyrightText: © 2018-2023 Jürgen Mülbert
 **
 ** SPDX-License-Identifier: EUPL-1.2
 **
 *************************************************************************/

/*
** jscpd:ignore-start
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnniversaryReminder.Data;
using jmbdeData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

/*
** jscpd:ignore-start
*/

namespace AnniversaryReminder.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly AnniversaryReminder.Data.ApplicationDbContext _context;

        public DetailsModel(AnniversaryReminder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}

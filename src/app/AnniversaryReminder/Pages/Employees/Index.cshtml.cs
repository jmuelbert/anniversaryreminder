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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnniversaryReminder.Pages.Employees
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly AnniversaryReminder.Data.ApplicationDbContext _context;

        public IndexModel(AnniversaryReminder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync().ConfigureAwait(false);
        }
    }
}

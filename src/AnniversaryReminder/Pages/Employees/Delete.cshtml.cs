
/*
 * Copyright (c) 2018-2020 Jürgen Mülbert. All rights reserved.
 *
 * This file is part of AnniversaryReminder
 *
 * Licensed under the EUPL, Version 1.2 or – as soon they
 * will be approved by the European Commission - subsequent
 * versions of the EUPL (the "Licence");
 * You may not use this work except in compliance with the
 * Licence.
 * You may obtain a copy of the Licence at:
 *
 * https://joinup.ec.europa.eu/page/eupl-text-11-12
 *
 * Unless required by applicable law or agreed to in
 * writing, software distributed under the Licence is
 * distributed on an "AS IS" basis,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied.
 * See the Licence for the specific language governing
 * permissions and limitations under the Licence.
 *
 * Lizenziert unter der EUPL, Version 1.2 oder - sobald
 * diese von der Europäischen Kommission genehmigt wurden -
 * Folgeversionen der EUPL ("Lizenz");
 * Sie dürfen dieses Werk ausschließlich gemäß
 * dieser Lizenz nutzen.
 * Eine Kopie der Lizenz finden Sie hier:
 *
 * https://joinup.ec.europa.eu/page/eupl-text-11-12
 *
 * Sofern nicht durch anwendbare Rechtsvorschriften
 * gefordert oder in schriftlicher Form vereinbart, wird
 * die unter der Lizenz verbreitete Software "so wie sie
 * ist", OHNE JEGLICHE GEWÄHRLEISTUNG ODER BEDINGUNGEN -
 * ausdrücklich oder stillschweigend - verbreitet.
 * Die sprachspezifischen Genehmigungen und Beschränkungen
 * unter der Lizenz sind dem Lizenztext zu entnehmen.
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

			Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeId == id);

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

			Employee = await _context.Employee.FindAsync(id);

			if (Employee != null)
			{
				_context.Employee.Remove(Employee);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}

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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jmbdeData.Models

{
	public partial class Fax
	{
		public long FaxId { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Number cannot be longer than 50 characters.")]
		[DataType(DataType.PhoneNumber)]
		public string Number { get; set; }

		[StringLength(20, ErrorMessage = "Serialnumber cannot be longer than 20 characters.")]
		public string SerialNumber { get; set; }

		[StringLength(10, ErrorMessage = "PIN cannot be longer than 10 characters.")]
		public string Pin { get; set; }

		public bool Active { get; set; }
		public bool Replace { get; set; }

		public DeviceName DeviceName { get; set; }
		public DeviceType DeviceType { get; set; }
		public ICollection<Employee> Employee { get; set; }
		public Place Place { get; set; }
		public Department Department { get; set; }
		public Manufacturer Manufacturer { get; set; }
		public Inventory Inventory { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime LastUpdate { get; set; }
	}
}

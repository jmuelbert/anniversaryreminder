/**************************************************************************
**
** Copyright (c) 2016-2018 Jürgen Mülbert. All rights reserved.
**
** This file is part of jmbde
**
** Licensed under the EUPL, Version 1.2 or – as soon they
** will be approved by the European Commission - subsequent
** versions of the EUPL (the "Licence");
** You may not use this work except in compliance with the
** Licence.
** You may obtain a copy of the Licence at:
**
** https://joinup.ec.europa.eu/page/eupl-text-11-12
**
** Unless required by applicable law or agreed to in
** writing, software distributed under the Licence is
** distributed on an "AS IS" basis,
** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
** express or implied.
** See the Licence for the specific language governing
** permissions and limitations under the Licence.
**
** Lizenziert unter der EUPL, Version 1.2 oder - sobald
**  diese von der Europäischen Kommission genehmigt wurden -
** Folgeversionen der EUPL ("Lizenz");
** Sie dürfen dieses Werk ausschließlich gemäß
** dieser Lizenz nutzen.
** Eine Kopie der Lizenz finden Sie hier:
**
** https://joinup.ec.europa.eu/page/eupl-text-11-12
**
** Sofern nicht durch anwendbare Rechtsvorschriften
** gefordert oder in schriftlicher Form vereinbart, wird
** die unter der Lizenz verbreitete Software "so wie sie
** ist", OHNE JEGLICHE GEWÄHRLEISTUNG ODER BEDINGUNGEN -
** ausdrücklich oder stillschweigend - verbreitet.
** Die sprachspezifischen Genehmigungen und Beschränkungen
** unter der Lizenz sind dem Lizenztext zu entnehmen.
**
**************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


// TODO: Change the use of SystemAccount

namespace jmbdeData.Models

{
    public enum Gender {
        F, M
    }

    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string EmployeeIdent { get; set; }
        public Gender Gender { get; set; }
        public JobTitle JobTitle { get; set; }

        [StringLength(50, ErrorMessage = "Firstname cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Lastname cannot be longer than 50 characters.")]
        public string LastName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Street cannot be longer than 50 characters.")]
        public string Street { get; set; }
        public ZipCode ZipCode { get; set; }

        [StringLength(50, ErrorMessage = "Phone Number cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [StringLength(50, ErrorMessage = "Mobile Number cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string HomeMobile { get; set; }

        [StringLength(50, ErrorMessage = "Mail Address cannot be longer than 50 characters.")]
        [DataType(DataType.EmailAddress)]
        public string HomeMailAddress { get; set; }

        [StringLength(50, ErrorMessage = "Mail Address cannot be longer than 50 characters.")]
        [DataType(DataType.EmailAddress)]
        public string BusinessMailAddress { get; set; }

        public bool DataCare { get; set; }

        public bool Active { get; set; }

        public byte[] Photo { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public Department Department { get; set; }
        public ICollection<Function> Function  { get; set; }
        public ICollection<Computer> Computer { get; set; }
        public ICollection<Printer> Printer { get; set; }
        public  Phone Phone { get; set; }
        public Mobile Mobile { get; set; }
        public Fax Fax { get; set; }
        public ICollection<SystemAccount> SystemAccount { get; set; }
        public ICollection<Document> Document { get; set; }
        public ChipCard ChipCard { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }
    }
}

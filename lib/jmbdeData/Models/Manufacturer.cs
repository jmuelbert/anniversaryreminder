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

namespace jmbdeData.Models

{
    public partial class Manufacturer
    {
        public long ManufacturerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Name2 cannot be longer than 50 characters.")]
        public string Name2 { get; set; }

        [StringLength(50, ErrorMessage = "Supporter cannot be longer than 50 characters.")]
        public string Supporter { get; set; }

        [StringLength(50, ErrorMessage = "Street cannot be longer than 50 characters.")]
        public string Street { get; set; }

        [StringLength(50, ErrorMessage = "Street2 cannot be longer than 50 characters.")]
        public string Street22 { get; set; }

        public ZipCode ZipCode { get; set; }

        [StringLength(50, ErrorMessage = "Mail Address cannot be longer than 50 characters.")]
        [DataType(DataType.EmailAddress)]
        public string MailAddress { get; set; }

        [StringLength(50, ErrorMessage = "Phone Number cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [StringLength(50, ErrorMessage = "Fax Number cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]        
        public string FaxNumber { get; set; }

        [StringLength(50, ErrorMessage = "Hotline Number cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string HotlineNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }
    }
}

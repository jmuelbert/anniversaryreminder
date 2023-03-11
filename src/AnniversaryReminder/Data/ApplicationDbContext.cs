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
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnniversaryReminder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public virtual DbSet<jmbdeData.Models.ChipCard> ChipCard { get; set; }
        public virtual DbSet<jmbdeData.Models.ChipCardDoor> ChipCardDoor { get; set; }
        public virtual DbSet<jmbdeData.Models.ChipCardProfile> ChipCardProfile { get; set; }
        public virtual DbSet<jmbdeData.Models.CityName> CityName { get; set; }
        public virtual DbSet<jmbdeData.Models.Company> Company { get; set; }
        public virtual DbSet<jmbdeData.Models.Computer> Computer { get; set; }
        public virtual DbSet<jmbdeData.Models.Department> Department { get; set; }
        public virtual DbSet<jmbdeData.Models.DeviceName> DeviceName { get; set; }
        public DbSet<jmbdeData.Models.DeviceType> DeviceType { get; set; }
        public virtual DbSet<jmbdeData.Models.Document> Document { get; set; }
        public virtual DbSet<jmbdeData.Models.Employee> Employee { get; set; }
        public virtual DbSet<jmbdeData.Models.Fax> Fax { get; set; }
        public virtual DbSet<jmbdeData.Models.Function> Function { get; set; }
        public virtual DbSet<jmbdeData.Models.Inventory> Inventory { get; set; }
        public virtual DbSet<jmbdeData.Models.Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<jmbdeData.Models.Mobile> Mobile { get; set; }
        public virtual DbSet<jmbdeData.Models.Phone> Phone { get; set; }
        public virtual DbSet<jmbdeData.Models.Place> Place { get; set; }
        public virtual DbSet<jmbdeData.Models.Printer> Printer { get; set; }
        public virtual DbSet<jmbdeData.Models.Processor> Processor { get; set; }
        public virtual DbSet<jmbdeData.Models.Software> Software { get; set; }
        public virtual DbSet<jmbdeData.Models.SystemAccount> SystemAccount { get; set; }

        public virtual DbSet<jmbdeData.Models.SystemData> SystemData { get; set; }
        public virtual DbSet<jmbdeData.Models.JobTitle> JobTitle { get; set; }
        public virtual DbSet<jmbdeData.Models.ZipCode> ZipCode { get; set; }
    }
}

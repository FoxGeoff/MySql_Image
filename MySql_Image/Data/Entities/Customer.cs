using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data.Entities
{
    public class Customer
    {
        public uint Id { get; set; }
        public uint? AssociatedEmployeeId { get; set; }
        public uint? AssociatedLocation { get; set; }
        public uint? AssociatedCustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string GateCode { get; set; }
        public sbyte BillAddressDifferent { get; set; }
        public string BillAddress { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillZipCode { get; set; }
        public string Phone1Description { get; set; }
        public string Phone2Description { get; set; }
        public string Phone3Description { get; set; }
        public string Phone1Value { get; set; }
        public string Phone2Value { get; set; }
        public string Phone3Value { get; set; }
        public string Phone1Extension { get; set; }
        public string Phone2Extension { get; set; }
        public string Phone3Extension { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string TaxId { get; set; }
        public byte IsNotExportedContact { get; set; }
        public byte IsRegisteredToC4 { get; set; }
        public string SmallNote { get; set; }
        //public DateTime DateAdded { get; set; }
        public string Notes { get; set; }
        public byte[] TaxIdImage { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}

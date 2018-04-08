using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data.Entities
{
    public class Product
    {
        public uint Id { get; set; }
        public byte IsDiscontinued { get; set; }
        public uint? AssociatedCategoryId { get; set; }
        public uint? AssociatedSnapshotTypeId { get; set; }
        public uint? AssociatedGroupId { get; set; }
        public uint? AssociatedScreenId { get; set; }
        public uint? AssociatedImageId { get; set; }
        public uint? AssociatedRecycleId { get; set; }
        public string MerchantNumber { get; set; }
        public string ProductDescription { get; set; }
        public string AiPartNumber { get; set; }
        public string ManufactureNumber { get; set; }
        public string ManufactureName { get; set; }
        public string MfgUrl { get; set; }
        public string MfgManualUrl { get; set; }
        public uint? AssociatedPrimaryVendorId { get; set; }
        public uint? AssociatedSecondaryVendorId { get; set; }
        public uint? AssociatedTertiaryVendorId { get; set; }
        public double? Retail { get; set; }
        public double? Cost { get; set; }
        public byte AdditionalCost { get; set; }
        public double? DefaultPriority { get; set; }
        public byte? IsTaxable { get; set; }
        public byte IsRecycleFee { get; set; }
        public string ItemsAssociated { get; set; }
        public sbyte IsExcludedDesAinumOverrwrite { get; set; }
        public int CostVerificationBy { get; set; }
    }
}

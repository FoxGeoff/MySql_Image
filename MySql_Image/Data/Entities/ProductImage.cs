using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data.Entities
{
    public class ProductImage
    {
        public uint Id { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string FileName { get; set; }
        public byte[] ImageThumb { get; set; }
        public byte[] ImageFull { get; set; }
    }
}

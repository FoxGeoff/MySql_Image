using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data.Entities
{
    public class ProductImage
    {
        [Key]
        public uint Id { get; set; }
        public DateTime? DateUpdated { get; set; }
        [MaxLength(50)]
        public string FileName { get; set; }
        [MaxLength(50000)]
        public byte[] ImageThumb { get; set; }
        [MaxLength(150000)]
        public byte[] ImageFull { get; set; }

        public string GetImageThumb()
        { var base64 = Convert.ToBase64String(ImageThumb);

            return String.Format("data:image/gif;base64,{0}", base64);
        }

        public string GetImageFull()
        {
            var base64 = Convert.ToBase64String(ImageFull);

            return String.Format("data:image/gif;base64,{0}", base64);
        }
    }
}

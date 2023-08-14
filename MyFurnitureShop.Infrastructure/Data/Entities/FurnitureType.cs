using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Infrastructure.Data
{
    using static Data.Constants.GlobalConstants;
    public class FurnitureType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(FurnitureTypeMaxLength, MinimumLength = FurnitureTypeMinLength)]
        public string Name { get; set; } = null!;

    }
}

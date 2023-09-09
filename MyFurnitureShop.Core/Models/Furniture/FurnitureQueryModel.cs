using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Models.Furniture
{
    public class FurnitureQueryModel : FurnitureModel
    {
        public FurnitureQueryModel()
        {
           Furnitures  = new List<FurnitureModel>();
        }

        public int FurnituresCount { get; set; }

        public IEnumerable<FurnitureModel> Furnitures { get; set; }
    }
}

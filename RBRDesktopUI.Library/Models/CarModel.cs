using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarName { get; set; }
        public string CarClass { get; set; }

        public string FullCarName
        {
            get { return $"{CarBrand} {CarName} {CarClass}"; }
        }
    }
}

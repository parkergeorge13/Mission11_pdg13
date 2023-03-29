using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }
        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter a state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter a zip code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Enter a country")]
        public string Country { get; set; }


    }
}

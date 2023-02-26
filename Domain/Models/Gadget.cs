using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Gadget
    {
        public Gadget()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public int? Sold { get; set; }
        public bool? Status { get; set; }
        public int? IdCategory { get; set; }

        public virtual Category? IdCategoryNavigation { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicRedBook.Models
{
    public class Child
    {
        public Child()
        {
            this.Parents = new HashSet<Microsoft.AspNetCore.Identity.IdentityUser>();
        }

        public int ChildId { get; set; }
        public string ChildName { get; set; }
        public string ChildSurname { get; set; }

        public virtual ICollection<Microsoft.AspNetCore.Identity.IdentityUser> Parents { get; set; }
    }
}

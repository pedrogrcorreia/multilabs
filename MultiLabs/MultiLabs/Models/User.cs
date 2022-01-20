using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MultiLabs.Models {
    public class User : IdentityUser<int>{
        
        public User() {
            LaboratoryTesters = new HashSet<LaboratoryTesters>();
        }

        public virtual ICollection<LaboratoryTesters> LaboratoryTesters { get; set; }
    }
}

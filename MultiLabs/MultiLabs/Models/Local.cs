using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultiLabs.Models {
    public class Local {

        public Local() {
            Laboratories = new HashSet<Laboratory>();
        }

        public int Id { get; set; }

        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Display(Name = "Morada")]
        public string Address { get; set; }

        public virtual ICollection<Laboratory> Laboratories { get; set; }
    }
}

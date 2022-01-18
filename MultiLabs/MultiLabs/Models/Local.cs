using System.Collections.Generic;

namespace MultiLabs.Models {
    public class Local {

        public Local() {
            Laboratories = new HashSet<Laboratory>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Laboratory> Laboratories { get; set; }
    }
}

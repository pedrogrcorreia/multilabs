using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class Laboratory {

        public Laboratory() {
            LaboratoryTests = new HashSet<LaboratoryTest>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name ="Local")]
        public int? LocalId { get; set; }
        public Local Local { get; set; }

        public virtual ICollection<LaboratoryTest> LaboratoryTests { get; set; }
    }
}

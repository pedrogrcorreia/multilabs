using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class Laboratory {

        public Laboratory() {
            LaboratoryTests = new HashSet<LaboratoryTest>();
            LaboratoryTesters = new HashSet<LaboratoryTesters>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name ="Local")]
        public int? LocalId { get; set; }
        public Local Local { get; set; }

        public int? UserId { get; set; } // Gestor do laboratorio
        public User User { get; set; }

        public virtual ICollection<LaboratoryTest> LaboratoryTests { get; set; }

        public virtual ICollection<LaboratoryTesters> LaboratoryTesters { get; set; } // tecnicos do laboratorio
    }
}

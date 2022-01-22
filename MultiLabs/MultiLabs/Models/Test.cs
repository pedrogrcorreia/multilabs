using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultiLabs.Models {
    public class Test {

        public Test() {
            LaboratoryTests = new HashSet<LaboratoryTest>();
        }

        public int Id { get; set; }

        [Display(Name = "Teste/Análise")]
        public string Name { get; set; }

        //public int? LaboratoryTestersId { get; set; }
        //public LaboratoryTesters LaboratoryTesters { get; set; }

        public virtual ICollection<LaboratoryTest> LaboratoryTests { get; set; }
      
    }
}

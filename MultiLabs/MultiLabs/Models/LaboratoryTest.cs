using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class LaboratoryTest {
        [Display(Name = "Laboratory")]
        public int LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}

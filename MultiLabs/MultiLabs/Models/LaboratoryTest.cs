using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class LaboratoryTest {
        [Display(Name = "Laboratório")]
        public int LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Teste/Análise")]
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}

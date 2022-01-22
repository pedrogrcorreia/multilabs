using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class LaboratoryTest {
        [Display(Name = "Laboratório")]
        public int LaboratoryId { get; set; }
        [Display(Name = "Laboratório")]
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Teste/Análise")]
        public int TestId { get; set; }
        [Display(Name = "Teste/Análise")]
        public Test Test { get; set; }
    }
}

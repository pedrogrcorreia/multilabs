using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class LaboratoryTesters {
        [Display(Name = "Laboratory")]
        public int LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Tester")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

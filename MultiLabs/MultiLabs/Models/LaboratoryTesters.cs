using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MultiLabs.Models {
    public class LaboratoryTesters {
        [Display(Name = "Laboratório")]
        public int LaboratoryId { get; set; }
        [Display(Name = "Laboratório")]
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Técnico")]
        public int UserId { get; set; }
        [Display(Name = "Técnico")]
        public User User { get; set; }
    }
}

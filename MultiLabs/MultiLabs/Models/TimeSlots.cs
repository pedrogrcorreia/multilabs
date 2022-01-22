using System;
using System.ComponentModel.DataAnnotations;

namespace MultiLabs.Models {
    public class TimeSlots {
        public int Id { get; set; }

        [Display(Name = "Data")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Vagas")]
        public int AvailableSlots { get; set; }

        [Display(Name = "Laboratório")]
        public int? LaboratoryId { get; set; }

        [Display(Name = "Laboratório")]
        public Laboratory Laboratory { get; set; }
    }
}

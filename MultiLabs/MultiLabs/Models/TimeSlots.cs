using System;

namespace MultiLabs.Models {
    public class TimeSlots {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int AvailableSlots { get; set; }

        public int? LaboratoryId { get; set; }

        public Laboratory Laboratory { get; set; }
    }
}

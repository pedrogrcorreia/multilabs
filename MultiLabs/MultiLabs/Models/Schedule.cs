using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace MultiLabs.Models {
    public class Schedule {
        public int Id { get; set; }

        public int? TestId { get; set; }
        public Test Test { get; set; }

        public int? LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }

        public DateTime DateTime { get; set; }

        public int ClientId { get; set; }

        public int TesterId { get; set; }
    }
}

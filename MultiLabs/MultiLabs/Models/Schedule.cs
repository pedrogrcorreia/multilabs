using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using MultiLabs.Results;

namespace MultiLabs.Models {
    public class Schedule {
        public int Id { get; set; }

        [Display(Name = "Teste/Análise")]
        public int? TestId { get; set; }

        [Display(Name = "Teste/Análise")]
        public Test Test { get; set; }

        [Display(Name = "Laboratório")]
        public int? LaboratoryId { get; set; }
        [Display(Name = "Laboratório")]
        public Laboratory Laboratory { get; set; }

        [Display(Name = "Data")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Cliente")]
        public int ClientId { get; set; }

        [Display(Name = "Cliente")]
        public User Client { get; set; }

        [Display(Name = "Técnico")]
        public int TesterId { get; set; }

        [Display(Name = "Técnico")]
        public User Tester { get; set; }

        [Display(Name = "Resultado")]
        public int? ResultId { get; set; } 

        [Display(Name = "Resultado")]
        public Result Result { get; set; }
    }
}

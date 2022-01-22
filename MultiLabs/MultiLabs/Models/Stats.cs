using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultiLabs.Models {
    public class Stats {

        public Stats() {
           
        }

        public Stats(int Total, int Positive, int Negative, int Inconclusive, DateTime DateTime) {
            this.Total = Total;
            this.Positive = Positive;
            this.Negative = Negative;
            this.Inconclusive = Inconclusive;
            this.DateTime = DateTime;
        }

        [Display(Name = "Total de testes/análises")]
        public int Total { get; set; }

        [Display(Name = "Positivos")]
        public int Positive { get; set; }

        [Display(Name = "Negativos")]
        public int Negative { get; set; }

        [Display(Name = "Inconclusivos")]
        public int Inconclusive { get; set; }

        [Display(Name = "Intervalo")]
        public DateTime DateTime { get; set; }
    }
}

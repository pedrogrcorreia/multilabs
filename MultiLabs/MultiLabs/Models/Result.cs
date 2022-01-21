using System.ComponentModel.DataAnnotations;

namespace MultiLabs.Models {
    public class Result {
        public int Id { get; set; }

        [Display(Name = "Resultado")]
        public string Name { get; set; }
    }
}

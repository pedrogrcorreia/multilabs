namespace MultiLabs.Models {
    public class LaboratoryTest {
        public int LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}

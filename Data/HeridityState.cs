namespace AdmiPanel_HealthApp.Data
{
    public enum Ancest
    {
        Mother,
        Father,
        GrandMother,
        GranFather,
        GrandGrandMother,
        GrandGrandFather,
        Sister,
        Brother,
        Aunt,
        Uncle
    }

    public class HeredityState
    {
        public int HeredityStateId { get; set; }
        public Ancest Ancestor { get; set; }
        public string DesiaseType { get; set; }
        public string Comments { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
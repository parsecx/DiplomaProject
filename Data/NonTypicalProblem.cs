namespace AdmiPanel_HealthApp.Data
{
    public class NonTypicalHealthProblem
    {
        public int NonTypicalHealthProblemId { get; set; }
        public string ProblemName { get; set; }
        public string ProblemDescription { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
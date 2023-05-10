namespace AdmiPanel_HealthApp.Data
{
	public class HealthState
	{
		public int HealthStateId { get; set; }
		public string HealthStateName { get; set; }
		public string HealthStateDescription { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
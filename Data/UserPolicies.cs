namespace AdmiPanel_HealthApp.Data;

public class UserPolicies
{
    public int UserPoliciesId { get; set; }
    public int InsurancePackageId { get; set; }
    public int PaymentVolume { get; set; }
    public bool isPaid { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int ApplicationsCount { get; set; }
    public bool isMedical { get; set; }
}
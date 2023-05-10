namespace AdmiPanel_HealthApp.Data;

public class UserApplications
{
    public int UserApplicationsId { get; set; }
    public string Title { get; set; }
    public string Comments { get; set; }
    public string dataPath { get; set; }
    public string CompensetionType { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public bool isValid { get; set; }
    public DateTime Date { get; set; }
    public int UserDataId { get; set; }
    public UserData UserData { get; set; }
    public int UserPoliciesId { get; set; }
    public UserPolicies UserPolicies { get; set; }
}
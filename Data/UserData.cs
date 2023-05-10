namespace AdmiPanel_HealthApp.Data;

public class UserData
{
    public int UserDataId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int DocumentInfoId { get; set; }
    public DocumentInfo DocumentInfo { get; set; }
    public string Job { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
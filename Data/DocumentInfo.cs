namespace AdmiPanel_HealthApp.Data;

public class DocumentInfo
{
    public int DocumentInfoId { get; set; }
    public string PassportNum { get; set; }
    public DateTime PassportDate { get; set; }
    public DateTime PassportExp { get; set; }
    public string PassportOrgans { get; set; }
    public string ITN { get; set; }
    public string HomeAdress { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
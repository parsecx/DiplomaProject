using AdmiPanel_HealthApp.Data.AdditionalClasses;
namespace AdmiPanel_HealthApp.Data
{
    public class InsurancePackage
    {
        public int InsurancePackageId { get; set; }
        public string InsurancePackageName { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public object AdditionalInfo { get; set; }
    }
}
namespace Hephaestus.DataApi.Entities
{
    public class EducationEntity
    {
        public Guid Id { get; set; }
        public string Degree { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

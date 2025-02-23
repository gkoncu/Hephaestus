namespace Hephaestus.DataApi.Entities
{
    public class PersonalInfoEntity
    {
        public Guid Id { get; set; }
        public string About { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

﻿namespace Hephaestus.DataApi.Entities
{
    public class ExperienceEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}

namespace API_WebApp.Models.DTO
{
    public class SubjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Day { get; set; }
        public string Room { get; set; }
        public string Teacher { get; set; }


        public SubjectDTO()
        {
            Id = 0;
            Name = string.Empty;
            StartTime = string.Empty;
            EndTime = string.Empty;
            Day = string.Empty;
            Room = string.Empty;
            Teacher = string.Empty;
        }
    }
}

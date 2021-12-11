namespace API_WebApp.Models.DTO
{
    public class ScheduleSchemaDTO
    {
        public List<string> Days { get; set; }
        public List<string> Hours { get; set; }

        public ScheduleSchemaDTO()
        {
            Days = new List<string>();
            Hours = new List<string>();
        }
    }
}

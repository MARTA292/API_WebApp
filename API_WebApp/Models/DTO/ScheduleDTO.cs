namespace API_WebApp.Models.DTO
{
    public class ScheduleDTO
    {
        public List<SubjectDTO> Subjects { get; set; }
        public ScheduleSchemaDTO ScheduleSchema { get; set; }

        public ScheduleDTO()
        {
            Subjects = new List<SubjectDTO>();
            ScheduleSchema = new ScheduleSchemaDTO();
        }
    }
}

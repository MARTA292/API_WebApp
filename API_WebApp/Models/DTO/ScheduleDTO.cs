namespace API_WebApp.Models.DTO
{
    public class ScheduleDTO
    {
        public List<SubjectDTO> Subjects { get; set; }

        public ScheduleDTO()
        {
            Subjects = new List<SubjectDTO>();
        }
    }
}

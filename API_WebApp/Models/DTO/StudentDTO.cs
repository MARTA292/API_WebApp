namespace API_WebApp.Models.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentDTO()
        {
            Id = 0;
            Name =  string.Empty;
        }
    }
}

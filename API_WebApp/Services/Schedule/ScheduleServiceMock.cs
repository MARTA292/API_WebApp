using API_WebApp.Models.DTO;

namespace API_WebApp.Services.Schedule
{
    public class ScheduleServiceMock : IScheduleService
    {
        private readonly ILogger<ScheduleServiceMock> _logger;
        public ScheduleServiceMock(ILogger<ScheduleServiceMock> logger)
        {
            _logger = logger;
        }

        public ScheduleDTO GetSchedule(StudentDTO student)
        {
            if(student == null)
            {
                _logger.LogError($"{nameof(GetSchedule)} -> Entidad student con valor null");
                return new ScheduleDTO();
            }
            if(string.IsNullOrEmpty(student.Name)){
                _logger.LogError($"{nameof(GetSchedule)} -> Entidad student con nombre nulo o vacío");
                return new ScheduleDTO();

            }
            var dictionary = new Dictionary<string, ScheduleDTO>
            {
                {
                    "Jorge", new ScheduleDTO()
                    {
                        Subjects = new List<SubjectDTO>()
                        {
                            new SubjectDTO() { Id = 0, Name = "DIPR_3A" , StartTime = "11", EndTime = "13",
                                Day = "Monday", Room = "M101", Teacher = "Eugenio"},
                            new SubjectDTO() { Id = 1, Name = "PWIC_3A" , StartTime = "13", EndTime = "15",
                                Day = "Monday", Room = "M101", Teacher = "Naira"},
                            new SubjectDTO() { Id = 6, Name = "PRESS_2A" , StartTime = "17", EndTime = "19",
                                Day = "Monday", Room = "M205", Teacher = "Mar"},
                            new SubjectDTO() { Id = 2, Name = "PRO_3A" , StartTime = "11", EndTime = "13",
                                Day = "Tuesday", Room = "M101", Teacher = "Teresa"},
                            new SubjectDTO() { Id = 3, Name = "INAR_3A" , StartTime = "13", EndTime = "15",
                                Day = "Tuesday", Room = "M101", Teacher = "Pedro"},
                            new SubjectDTO() { Id = 3, Name = "INAR_3A" , StartTime = "11", EndTime = "13",
                                Day = "Wednesday", Room = "M101", Teacher = "Pedro"},
                            new SubjectDTO() { Id = 4, Name = "ISIN_3A" , StartTime = "13", EndTime = "15",
                                Day = "Wednesday", Room = "M101", Teacher = "Eduardo"},
                            new SubjectDTO() { Id = 6, Name = "PRESS_2A" , StartTime = "17", EndTime = "19",
                                Day = "Wednesday", Room = "M205", Teacher = "Mar"},
                            new SubjectDTO() { Id = 4, Name = "ISIN_3A" , StartTime = "11", EndTime = "13",
                                Day = "Thursday", Room = "M101", Teacher = "Eduardo"},
                            new SubjectDTO() { Id = 5, Name = "PSDI_3A" , StartTime = "13", EndTime = "15",
                                Day = "Thursday", Room = "M101", Teacher = "Marcos"},
                            new SubjectDTO() { Id = 1, Name = "PWIC_3A" , StartTime = "09", EndTime = "11",
                                Day = "Friday", Room = "M101", Teacher = "Naira"},
                            new SubjectDTO() { Id = 5, Name = "PSDI_3A" , StartTime = "11", EndTime = "13",
                                Day = "Friday", Room = "M101", Teacher = "Marcos"}

                        }
                    }
                },
                { 
                    "Marta", new ScheduleDTO()
                    {
                        Subjects = new List<SubjectDTO>()
                        {
                            new SubjectDTO() { Id = 0, Name = "DIPR_3A" , StartTime = "11", EndTime = "13",
                                Day = "Monday", Room = "M101", Teacher = "Eugenio"},
                            new SubjectDTO() { Id = 1, Name = "PWIC_3A" , StartTime = "13", EndTime = "15",
                                Day = "Monday", Room = "M101", Teacher = "Naira"},
                            new SubjectDTO() { Id = 2, Name = "PRO_3A" , StartTime = "11", EndTime = "13",
                                Day = "Tuesday", Room = "M101", Teacher = "Teresa"},
                            new SubjectDTO() { Id = 3, Name = "INAR_3A" , StartTime = "13", EndTime = "15",
                                Day = "Tuesday", Room = "M101", Teacher = "Pedro"},
                            new SubjectDTO() { Id = 3, Name = "INAR_3A" , StartTime = "11", EndTime = "13",
                                Day = "Wednesday", Room = "M101", Teacher = "Pedro"},
                            new SubjectDTO() { Id = 4, Name = "ISIN_3A" , StartTime = "13", EndTime = "15",
                                Day = "Wednesday", Room = "M101", Teacher = "Eduardo"},
                            new SubjectDTO() { Id = 4, Name = "ISIN_3A" , StartTime = "11", EndTime = "13",
                                Day = "Thursday", Room = "M101", Teacher = "Eduardo"},
                            new SubjectDTO() { Id = 5, Name = "PSDI_3A" , StartTime = "13", EndTime = "15",
                                Day = "Thursday", Room = "M101", Teacher = "Marcos"},
                            new SubjectDTO() { Id = 1, Name = "PWIC_3A" , StartTime = "09", EndTime = "11",
                                Day = "Friday", Room = "M101", Teacher = "Naira"},
                            new SubjectDTO() { Id = 5, Name = "PSDI_3A" , StartTime = "11", EndTime = "13",
                                Day = "Friday", Room = "M101", Teacher = "Marcos"}

                        }
                    } 
                
                }
            
            };
            if (dictionary.ContainsKey(student.Name))
            {
                _logger.LogInformation($"{nameof(GetSchedule)} -> Alumno encontrado");
                return dictionary[student.Name];
            }
            _logger.LogInformation($"{nameof(GetSchedule)} -> El estudiante no cursa actualmente");
            return new ScheduleDTO();
        }
    }
}

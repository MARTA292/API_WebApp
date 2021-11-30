using API_WebApp.Models.DTO;

namespace API_WebApp.Services.Schedule
{
    public interface IScheduleService
    {
        ScheduleDTO GetSchedule(StudentDTO student);

    }
}

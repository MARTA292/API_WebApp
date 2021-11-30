using API_WebApp.Models.DTO;
using API_WebApp.Services.Schedule;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ILogger<ScheduleController> _logger;
        private readonly IScheduleService _scheduleService;

        public ScheduleController(ILogger<ScheduleController> logger, IScheduleService scheduleService)
        {
            _logger = logger;
            _scheduleService = scheduleService;
            
        }

        [HttpGet(Name = "GetSchedule")]
        public ScheduleDTO GetSchedule([FromQuery] StudentDTO student)
        {
            if (student == null)
            {
                _logger.LogError($"{nameof(GetSchedule)} -> Entidad student con valor null");
                return new ScheduleDTO();
            }
            if (string.IsNullOrEmpty(student.Name))
            {
                _logger.LogError($"{nameof(GetSchedule)} -> Entidad student con nombre nulo o vacío");
                return new ScheduleDTO();

            }
            try
            {
                var schedule = _scheduleService.GetSchedule(student);
                if(schedule == null)
                {
                    _logger.LogError($"{nameof(GetSchedule)} -> Servicio ha devuelto un horario null");
                    return new ScheduleDTO();
                }
                return schedule;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return new ScheduleDTO();
            }
        }
    }
}

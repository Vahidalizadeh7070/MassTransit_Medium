namespace ScheduleService.API.DTO.ScheduleDTOs
{
    public class CreateScheduleDTO
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public DateTime ScheduleDate { get; set; }
        public bool IsActive { get; set; } = false;
    }
}

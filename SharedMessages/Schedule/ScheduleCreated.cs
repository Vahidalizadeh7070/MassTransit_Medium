using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedMessages.Schedule
{
    public interface ScheduleCreated
    {
        string Id { get; set; }
        string Title { get; set; }
        DateTime ScheduleDate { get; set; }
        bool IsActive { get; set; } 
        DateTime ScheduleCreated { get;set; }

    }
}

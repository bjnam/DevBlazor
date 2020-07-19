using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBlazor
{
    public class AppointmentCollection
    {
        public static List<Appointment> GetAppointments()
        {
            DateTime date = DateTime.Today;
            var dataSource = new List<Appointment>() {
            new Appointment {
                Caption = "PT예약",
                StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                Label = 6,
                Status = 1
            },
            new Appointment {
                Caption = "Upgrade Personal Computers",
                StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                EndDate = date + (new TimeSpan(0, 14, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "PT예약",
                StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                Label = 1,
                Status = 1
            },
            // ...
        };
            return dataSource;
        }
    }
}

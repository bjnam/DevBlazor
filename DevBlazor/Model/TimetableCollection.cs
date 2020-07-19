using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBlazor
{
    public class TimetableCollection
    {
        public static List<TimeTable> GetTimetable()
        {
            DateTime date = DateTime.Today;
            var dataSource = new List<TimeTable>() {
            new TimeTable {
                Date = "2020-08-20",
                Program="헬스오전반",
                Coach="홍길동",
                State=0, //예약가능 1:대기가능 2: 불가
                Reservation=false,//예약상태 fslce: 미예약


            },
            new TimeTable {
                Date = "2020-08-21",
                Program="주부오전반",
                Coach="유재석",
                State=1,
                Reservation=true,
           
            // ...
            },
           };
            return dataSource;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBlazor
{
    public class TimeTable
    {
     
        public string Date { get; set; }
        public string Program { get; set; }
        public string Coach { get; set; }
        public int State { get; set; } //0:예약가능 1: 예약 2: 대기
        public bool Reservation{ get; set; } // 1. 예약된상태 2. 미예약 


    }
}

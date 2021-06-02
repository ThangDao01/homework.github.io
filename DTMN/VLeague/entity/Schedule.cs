using System.Collections.Generic;

namespace DTMN.VLeague.entity
{
    public class Schedule
    {
        
        public static List<Schedule> ScheduleList;
        public string Doi1 { get; set; }
        public string Doi2 { get; set; }
        public string NgayThiDau { get; set; }
        public string GioThiDau { get; set; }
        public string SanThiDau { get; set; }
        

        public Schedule()
        {
        }

        public static List<Schedule> ListSchedules;
        public Schedule(string doi1, string doi2, string ngayThiDau, string gioThiDau, string sanThiDau)
        {
            Doi1 = doi1;
            Doi2 = doi2;
            NgayThiDau = ngayThiDau;
            GioThiDau = gioThiDau;
            SanThiDau = sanThiDau;
        }
    }
}
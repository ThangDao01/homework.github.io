using System.Collections.Generic;

namespace DTMN.VLeague.entity
{      
    public  class FootballTeam
    {
        public string MaDoi { get;set; }
        public string TenDoi { get; set; }
        public string HLV { get; set; }
        public int Tran { get; set; }
        public int Thang { get; set; }
        public int Hoa { get; set; }
        public int Thua { get; set; }
        public int Diem { get; set; }
        

        public FootballTeam()
        {
        }

        public static List<FootballTeam> FootballTeamsList;
        public FootballTeam(string maDoi, string tenDoi, string hlv)
        {
            MaDoi = maDoi;
            TenDoi = tenDoi;
            HLV = hlv;
        }
    }
}
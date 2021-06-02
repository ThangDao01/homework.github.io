using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DTMN.VLeague.entity;
using VLeague.service;

namespace DTMN.VLeague.controller
{
    public class VLeagueController
    {
        private List<FootballTeam> _listTeam = FootballTeam.FootballTeamsList;
        private List<Schedule> _listSchedules = Schedule.ListSchedules;
        private VLeagueService _service = new VLeagueService();

        public bool CreateTeam()
        {
            FootballTeam teamCreate = new FootballTeam();
            Console.WriteLine("=====Thêm mới một đội bóng=======");
            Console.Write("Nhập Mã đội:");
            teamCreate.MaDoi = Console.ReadLine();
            Console.Write("Nhập tên đôi:");
            teamCreate.TenDoi = Console.ReadLine();
            Console.Write("Nhập tên huấn luyện viên:");
            teamCreate.HLV = Console.ReadLine();
            _service.CreateTeam(teamCreate);
            Console.WriteLine("Bạn muốn tiếp tục?(Y/N)");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                FootballTeam.FootballTeamsList.Add(teamCreate);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTeam()
        {
            FootballTeam teamUpdate = new FootballTeam();
            Console.WriteLine("=====Thêm mới một đội bóng=======");
            Console.Write("Nhập Mã đội:");
            teamUpdate.MaDoi = Console.ReadLine();
            Console.Write("Sửa Tên đội:");
            teamUpdate.TenDoi = Console.ReadLine();
            Console.Write("Sửa Tên huấn luyện viên:");
            teamUpdate.HLV = Console.ReadLine();
            Console.WriteLine("Bạn có muốn cập nhật thông tin?(Y/N)");
            string choice1 = Console.ReadLine();
            if (choice1 == "Y")
            {
                _service.UpdateTeam(teamUpdate);
            }

            Console.WriteLine("Bạn muốn tiếp tục?(Y/N)");
            string choice2 = Console.ReadLine();
            if (choice2 == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListTeam()
        {
            Console.WriteLine(
                "===========================================================================================");
            Console.WriteLine(
                "| Mã đội |     Tên đội          | Huân luyện viên     |Trận  | Thắng | Hòa  | Thua | Điểm ");
            Console.WriteLine(
                "===========================================================================================");
            for (int i = 0; i < _listTeam.Count; i++)
            {
                FootballTeam teamList = _listTeam[i];
                Console.WriteLine("| {0,-6} | {1,-20} | {2,-20}| {3,-5}| {4,-6}| {5,-5}| {6,-5}| {7,5}"
                    , teamList.MaDoi, teamList.TenDoi, teamList.HLV, teamList.Tran, teamList.Thang, teamList.Hoa,
                    teamList.Thua, teamList.Diem);
                Console.WriteLine(
                    "===========================================================================================");
            }

            Console.WriteLine(
                "===========================================================================================");
        }

        public bool CreateSchedule()
        {
            Console.WriteLine("=====Tạo lịch thi đấu=======");
            Schedule schedule = new Schedule();
            Console.Write("Đội thứ 1:");
            schedule.Doi1 = Console.ReadLine();
            Console.Write("Đội thứ 2:");
            schedule.Doi2 = Console.ReadLine();
            Console.Write("Ngày thi đấu:");
            schedule.NgayThiDau = Console.ReadLine();
            Console.Write("Giời thi đấu:");
            schedule.GioThiDau = Console.ReadLine();
            Console.Write("Sân thi đấu:");
            schedule.SanThiDau = Console.ReadLine();
            _service.CreateSchedule(schedule);
            return true;
        }

        public void EditResult()
        {
            ListTeam();
            Console.WriteLine("Chọn team muốn thay đổi kết quả");
            string madoi = Console.ReadLine();
            FootballTeam teamEdit = FindTeam(madoi);
            Console.WriteLine("Nhập số trận :");
            teamEdit.Tran = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số trận thắng:");
            teamEdit.Thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số trận hòa :");
            teamEdit.Hoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số trận thua:");
            teamEdit.Thua = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số điểm :");
            teamEdit.Diem = Convert.ToInt32(Console.ReadLine());
            _service.UpdateTeam(teamEdit);
        }
        
        public FootballTeam FindTeam(string madoi)
        {
            for (int i = 0; i < _listTeam.Count; i++)
            {
                if (madoi == _listTeam[i].MaDoi)
                {
                    return _listTeam[i];
                }
            }

            return null;
        }

        public void ListSchedule()
        {
            for (int i = 0; i < _listSchedules.Count; i++)
            {
                Schedule schedule = _listSchedules[i];
                Console.WriteLine("=================================================================");
                Console.WriteLine(
                    "|        Đội 1        |        Đội 2        |    Ngày Thi Đấu     |   Giờ Đấu |  Sân Thi Đấu ");
                Console.WriteLine("{0,-20}|{1,-20}|{2,-20}|{3,-10}|{4,-20}", schedule.Doi1, schedule.Doi2,
                    schedule.NgayThiDau, schedule.GioThiDau, schedule.SanThiDau);
                Console.WriteLine("=================================================================");
                Console.WriteLine("=================================================================");
            }
        }

        public void fakedata()
        {
            _listSchedules.Add(new Schedule("Thể công- Viettel", "Hoàng Anh Gia Lai", "30/02/2099", "12:00AM",
                "Sân Mỹ Đình"));
            _listSchedules.Add(new Schedule("Hà Nội FC", "Hải Phòng FC", "30/02/2099", "12:00AM", "Sân Mỹ Đình"));
            _listSchedules.Add(new Schedule("Hoàng Anh Gia Lai", "SHB Đà Nẵng", "30/02/2099", "12:00AM",
                "Sân Mỹ Đình"));
            _listSchedules.Add(new Schedule("Than Quảng Ninh", "Sông Lam Nghệ An", "30/02/2099", "12:00AM",
                "Sân Mỹ Đình"));
            _listSchedules.Add(new Schedule("Đông Á Thanh Hóa", "TP. Hồ Chí Minh FC", "30/02/2099", "12:00AM",
                "Sân Mỹ Đình"));
            _listTeam.Add(new FootballTeam("TCVT", "Thể công- Viettel", "Nguyễn Văn a"));
            _listTeam.Add(new FootballTeam("HNFC", "Hà Nội FC", "Nguyễn Văn a"));
            _listTeam.Add(new FootballTeam("HAGL", "Hoàng Anh Gia Lai", "Nguyễn Văn a"));
            _listTeam.Add(new FootballTeam("THAN", "Than Quảng Ninh", "Nguyễn Văn a"));
            _listTeam.Add(new FootballTeam("DNATH", "Đông Á Thanh Hóa", "Nguyễn Văn a"));
        }
    }
}
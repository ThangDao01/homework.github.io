using System;
using System.Threading;
using DTMN.VLeague.controller;

namespace VLeague.view
{
    public class ApplicationMenu
    {
        private VLeagueController _vLeagueController = new VLeagueController();
        
        public void MainMenu()
        {
            _vLeagueController.fakedata();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("--Chào mừng đến với V-League 2008-----");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Quản lý danh sách đội bóng.");
                Console.WriteLine("2. Quản lý lịch thi đấu.");
                Console.WriteLine("3. Quản lý kết quả thi đấu.");
                Console.WriteLine("4. Thống kê.");
                Console.WriteLine("0. Thoát.");
                Console.Write("\n Your choice is :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("0. Thoát.");
                        break;
                    case 1:
                        TeamListMenu();
                        break;
                    case 2:
                        ScheduleMenu();
                        break;
                    case 3:
                        Console.WriteLine("3. Quản lý kết quả thi đấu.");
                        break;
                    case 4:
                        Console.WriteLine("4. Thống kê.");
                        break;
                }

                Console.WriteLine("\n-->Enter to continue!");
                Console.ReadLine();
            }
        }

        public void TeamListMenu()
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("--Quản lý danh sách đội bóng-----");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Xem danh sách đội bóng");
                Console.WriteLine("2. Cập nhật danh sách đội bóng");
                Console.WriteLine("3. Thêm mới một đội bóng");
                Console.WriteLine("0. Trờ về menu chính.");
                Console.Write("\n Your choice is :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("0. Trờ về menu chính.");
                        break;
                    case 1:
                        _vLeagueController.ListTeam();
                        break;
                    case 2:
                        if (_vLeagueController.CreateTeam())
                        {
                            continue;
                        }
                        else
                        {
                            choice = 0;
                        }
                        break;
                    case 3:
                        if (_vLeagueController.UpdateTeam())
                        {
                            continue;
                        }
                        else
                        {
                            choice = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai quay trở lại menu chính ");
                        choice = 0;
                        break;
                }

                if (choice == 0 )
                {
                    break;
                }
                Console.WriteLine("\n-->Enter to continue!");
                Console.ReadLine();
            }
        }
        public void ScheduleMenu()
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("--Quản lý lịch thi đấu-----");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Xem lịch thi đấu");
                Console.WriteLine("2. Cập nhật cập nhật lịch thi đấu");
                Console.WriteLine("0. Trờ về menu chính.");
                Console.Write("\n Your choice is :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("0. Trờ về menu chính.");
                        break;
                    case 1:
                        _vLeagueController.ListSchedule();
                        break;
                    case 2:
                        if (_vLeagueController.CreateSchedule()==false)
                        {
                            choice = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai quay trở lại menu chính ");
                        choice = 0;
                        break;
                }
                Console.WriteLine("\n-->Enter to continue!");
                Console.ReadLine();
            }
        }

        public void ResultMenu()
        {
_vLeagueController.EditResult();
        }
    }
}
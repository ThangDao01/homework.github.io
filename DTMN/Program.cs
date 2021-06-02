using System;
using System.Collections.Generic;
using System.Text;
using DTMN.VLeague.entity;
using VLeague.view;

namespace DTMN
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("| Mã đội |     Tên đội          | Huân luyện viên     |Trận  | Thắng | Hòa  | Thua | Điểm ");
            Console.WriteLine("| a      | b                    | c                   | d    | e     | f    | g    |     h");
            Console.WriteLine("| {0,-6} | {1,-20} | {2,-20}| {3,-5}| {4,-6}| {5,-5}| {6,-5}| {7,5}","a","b","c","d","e","f","g","h");   

            // ApplicationMenu applicationMenu = new ApplicationMenu();
            // applicationMenu.MainMenu();
            Console.WriteLine("Chúc các đội giải V-League thành công!");
        }
    }
}
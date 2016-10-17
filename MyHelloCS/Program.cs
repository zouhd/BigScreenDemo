using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyHelloCS
{
    class Program
    {
        public static DateTime s1;
        public static void ThreadCallback(object data)
        {
            DateTime s2 = DateTime.Now;
            TimeSpan span1 = new TimeSpan(s1.Ticks);
            TimeSpan span2 = new TimeSpan(s2.Ticks);
            double inteval = span2.TotalMilliseconds - span1.TotalMilliseconds;

            s1 = s2;

            Console.WriteLine("{0}, {1}ms", data, inteval);


        }

        static void Main(string[] args)
        {
            Player zhd = new Player("zhd", 7);
            zhd.Shoot(2, true);
            zhd.Shoot(3, false);
            zhd.Shoot(1, true);
            zhd.Foul();
            zhd.Rebound();
            zhd.Assist();
            zhd.Foul();
            zhd.Foul();
            zhd.Foul();

            zhd.DisplayPlayer();
            Console.WriteLine("====================");


            Team xt_team = new Team("信通公司篮球俱乐部");
            xt_team.AddPlayer(zhd);
            xt_team.SetTeamCaptain(zhd);
            xt_team.DisplayTeam();
            Console.WriteLine("====================");



            s1 = DateTime.Now;


            Game g1 = new Game("省信通篮球比赛", "南师大", xt_team, xt_team);
            //g1.SetGameTime(0, 3);
            g1.StartGame();


            Console.ReadLine();
            //g1.StartGame();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MyHelloCS
{
    /// <summary>
    /// Game类是引擎类，属于业务层。
    /// 1、
    /// </summary>
    public class Game
    {
        private String m_strName;//比赛名称
        private String m_strLoc;//比赛地点

        private Team m_team1;//队伍1
        private Team m_team2;//队伍2

        private int m_quarter_num;//比赛共几节
        private int m_current_quarter;//当前第几节
        private int m_quarter_min;//比赛单节时长
        private bool m_is_over;//比赛是否结束，根据时间或者场外因素
        private bool m_is_pause;//比赛暂停

        private GameTimer m_game_timer;//比赛计时器


        public Game(String name, String loc, Team team1, Team team2)
        {
            this.m_strName = name;
            this.m_strLoc = loc;
            this.m_team1 = team1;
            this.m_team2 = team2;

            //比赛默认4节，每节12分钟
            this.m_current_quarter = 1;
            this.m_quarter_num = 4;
            this.m_quarter_min = 12;

            this.m_is_over = false;
            this.m_is_pause = false;

            //测试
            m_game_timer = new GameTimer();
            m_game_timer.SetTimer(0, 3);

            m_game_timer.GameTimerHandle = QuarterHandle;

        }

        /// <summary>
        /// 设置比赛时长，总共几节，每节多少分钟
        /// </summary>
        /// <param name="time"></param>
        public void SetGameTime(int quarter_num, int quarter_min)
        {
            m_quarter_num = quarter_num;
            m_quarter_min = quarter_min;
            m_current_quarter = 1;

            m_game_timer.SetTimer(m_quarter_min, 0);
            m_game_timer.Set24sTimer(24.0);

        }

        //TODO:启动比赛引擎
        public void StartGame()
        {
            m_is_over = false;
            m_is_pause = false;
            
            m_game_timer.StartTimer();
            
        }

        public void PauseGame()
        {
            m_is_pause = true;
            m_is_over = false;
            m_game_timer.PauseTimer();
        }

        public void ResumeGame()
        {
            m_is_pause = false;
            m_is_over = false;
            m_game_timer.ResumeTimer();
        }

        public void StopGame()
        {
            m_is_pause = true;
            m_is_over = true;
            m_game_timer.StopTimer();
        }

        /// <summary>
        /// 一节比赛结束，是个delegate，需要处理：
        /// 1、设置比赛第几节, quarter++
        /// 2、重新设置一节比赛计时器
        /// 3、将比赛状态设为暂停,pause；如果比赛全部结束，将比赛状态设为结束,over
        /// </summary>
        public void QuarterHandle()
        {
            if (m_current_quarter < m_quarter_num)//前三节
            {
                Console.WriteLine("第{0}节比赛结束，...", m_current_quarter);

                m_is_over = false;
                m_is_pause = true;

                m_current_quarter++;
                Thread.Sleep(2000);
                //TODO:设置一节比赛时间，SetTimer(m_quarter_min, 0);
                m_game_timer.SetTimer(0, 3);
                //TODO:删除该行
                m_game_timer.StartTimer();
            }
            else if (m_current_quarter == m_quarter_num)//最后一节
            {
                m_is_over = true;
                m_is_pause = true;

                Console.WriteLine("第{0}节比赛结束，...", m_current_quarter);
                Console.WriteLine("全场比赛结束...");
            }
            
        }

    }
}

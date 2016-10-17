using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Timers;

/***
 * GameTimer：比赛计时器类
 * 实现篮球比赛的及时功能
 * 1、比赛计时，1节12分钟或者10分钟，倒计时
 * 2、24秒计时，1次进攻计时
 * 
 ***/

namespace MyHelloCS
{
    class GameTimer
    {
        private int m_min;//分钟，当前计时器还剩多少分
        private double m_sec;/*秒钟，当前计时器还剩多少秒。 
                             参考了NBA比赛，最后时刻要显示0.X秒*/
        private double m_left_time;//剩余时间，以s为单位
        private double m_24s_time;//24s进攻时间

        private bool m_is_timeout;//比赛时间到？
        private bool m_is_24s_timeout;//24s时间到？
        private System.Timers.Timer m_timer;//计时器类，是实现GameTimer的核心成员。
        private System.Timers.Timer m_24s_timer;//24秒计时器

        public delegate void DelegateGameTimer();
        public DelegateGameTimer GameTimerHandle;//单节结束后的处理

        public GameTimer()
        {
            m_min = 12;
            m_sec = 0.0;
            m_left_time = 60 * m_min + m_sec;
            m_24s_time = 24.0;

            m_is_timeout = false;
            m_is_24s_timeout = false;

            m_timer = new System.Timers.Timer();
            m_timer.Interval = 1000;
            m_timer.Elapsed += new ElapsedEventHandler(m_timer_Elapsed);
            m_timer.Disposed += new EventHandler(m_timer_Disposed);

            m_24s_timer = new System.Timers.Timer();
            m_24s_timer.Interval = 1000;
            m_24s_timer.Elapsed += new ElapsedEventHandler(m_24s_timer_Elapsed);
            m_24s_timer.Disposed += new EventHandler(m_24s_timer_Disposed);
            
            
        }

        /// <summary>
        /// 计时器回调函数，即计时器Tick事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Thread.CurrentThread.IsBackground = true;
            if (m_left_time > 0.1)
            {
                Console.WriteLine("Left time： {0}", GameTimerToString());

                m_left_time--;
                m_min = (int)m_left_time / 60;
                m_sec = m_left_time % 60;

            }
            else
            {
                m_is_timeout = true;
                PauseTimer();

                GameTimerHandle.Invoke();
            }

        }

        /// <summary>
        /// 计时器dispose的回调函数，释放计时器资源，同时设置m_timer=null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_timer_Disposed(object sender, EventArgs e)
        {
            m_timer = null;
        }

        /// <summary>
        /// 设置计时器的时间
        /// </summary>
        /// <param name="minute">计时器的分钟数</param>
        /// <param name="second">计时器的秒数</param>
        public void SetTimer(int minute, double second)
        {
            m_min = minute;
            m_sec = second;

            m_left_time = m_min * 60 + m_sec;

        }


        /// <summary>
        /// 作者：zhd
        /// 时间:14.10.27
        /// 作用：开始计时
        /// </summary>
        public void StartTimer()
        {
            if (m_timer != null)
                m_timer.Start();
        }

        /// <summary>
        /// 作者：zhd
        /// 时间:14.10.27
        /// 作用：暂停计时器
        /// </summary>
        public void PauseTimer()
        {
            if (m_timer != null)
                m_timer.Stop();
        }

        public void ResumeTimer()
        {
            if (m_timer != null)
                m_timer.Start();
        }

        public void StopTimer()
        {
            m_timer.Stop();
            m_timer.Dispose();

            if (m_timer == null)
                Console.WriteLine("timer is disposed...");
        }

        /// <summary>
        /// 判断计时器是否到时间
        /// </summary>
        /// <returns></returns>
        public bool IsTimeout()
        {
            if (m_min > 0 || m_sec > 0.01)
                m_is_timeout = false;
            else
                m_is_timeout = true;

            return m_is_timeout;
        }

        public String GameTimerToString()
        {
            String str_game_timer;
            str_game_timer = String.Format("{0:00}:{1:00}", m_min, m_sec);

            return str_game_timer;
        }

        /// <summary>
        /// 24s计时器 tick事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_24s_timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("24s left time: {0}s", Timer24sToString());
            if (m_24s_time > 0.01)//由于m_24s_time是double类型，一般情况下，它的值不会等于0，只会约等于0
            {
                m_is_24s_timeout = false;
                if (m_24s_time > 10)
                    m_24s_time -= 1.0;
                else
                {
                    m_24s_timer.Interval = 0.1;
                    m_24s_time -= 0.1;
                }
            }
            else
            {
                m_is_24s_timeout = true;
                m_24s_time = 24.0;

                Stop24sTimer();
                m_24s_timer.Interval = 1000;
            }
        }

        /// <summary>
        /// 24s计时器 Dispose事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_24s_timer_Disposed(object sender, EventArgs e)
        {
            m_24s_timer = null;
        }


        /// <summary>
        /// 作者：zhd
        /// 时间:14.10.28
        /// 作用：开始计时
        /// </summary>
        public void Start24sTimer()
        {
            if (m_24s_timer != null)
                m_24s_timer.Start();
        }

        /// <summary>
        /// 作者：zhd
        /// 时间:14.10.27
        /// 作用：暂停计时器
        /// </summary>
        public void Pause24sTimer()
        {
            if (m_24s_timer != null)
                m_24s_timer.Stop();
        }

        public void Resume24sTimer()
        {
            if (m_24s_timer != null)
                m_24s_timer.Start();
        }

        public void Stop24sTimer()
        {
            m_24s_timer.Stop();
            m_24s_timer.Dispose();

            if (m_24s_timer == null)
                Console.WriteLine("timer is disposed...");
        }

        /// <summary>
        /// 设置24s计时器时间
        /// </summary>
        /// <param name="second"></param>
        public void Set24sTimer(double second)
        {
            m_24s_time = second;
        }

        /// <summary>
        /// 判断是否24s为例
        /// </summary>
        /// <returns></returns>
        public bool Is24sTimeout()
        {
            if (m_24s_time > 0.01)
                m_is_24s_timeout = false;
            else
                m_is_24s_timeout = true;

            return m_is_24s_timeout;
        }

        /// <summary>
        /// 24s计时器时间的格式化输出
        /// </summary>
        /// <returns></returns>
        public String Timer24sToString()
        {
            String str_24s_timer;

            if (m_24s_time > 9.9)
            {
                str_24s_timer = String.Format("{0:00}", m_24s_time);
            }
            else
                str_24s_timer = String.Format("{0:0.0}", m_24s_time);
            
            return str_24s_timer;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace MyHelloCS
{
    public class Team
    {
        private String m_tname;//球队名称
        private int m_team_points;//球队总分
        private int m_player_count;//球队人数
        private Player m_cap;//队长
        private int m_team_fouls;//球队犯规
        private int m_timeout;//球队暂停
        private ArrayList m_player_arr;//球队球员
     

        public Team(String name)
        {
            this.m_tname = name;
            this.m_team_points = 0;
            this.m_player_count = 0;
            this.m_team_fouls = 0;
            this.m_timeout = 0;
            this.m_player_arr = new ArrayList();
            this.m_player_arr.Clear();

        }

        public int TeamPoints
        {
            get 
            { 
                m_team_points = 0;//计算之前清零
                foreach (Player player in m_player_arr)
                {
                    m_team_points += player.POINTS;
                }
                return m_team_points; 
            }

            set
            {
                m_team_points = value;
            }
        }
        /// <summary>
        /// 队伍添加一名球员
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            m_player_arr.Add(player);
            m_player_count = m_player_arr.Count;
        }

        /// <summary>
        /// 设置队长
        /// </summary>
        /// <param name="cap"></param>
        public void SetTeamCaptain(Player cap_player)
        {
            m_cap = cap_player;
            cap_player.SetCaptain();//
        }

        /// <summary>
        /// 重置队长
        /// </summary>
        public void ResetTeamCaptain()
        {
            m_cap.ResetCaptain();
            m_cap = null;

        }

        /// <summary>
        /// 更新球队得分
        /// </summary>
        public void UPdateTeamPoints()
        {
            m_team_points = 0;
            foreach (Player player in m_player_arr)
            {
                m_team_points += player.POINTS;
            }
        }

        /// <summary>
        /// 更新球队犯规
        /// </summary>
        /// <returns></returns>
        public int UPdateTeamFouls()
        {
            m_team_fouls = 0;
            foreach (Player player in m_player_arr)
            {
                m_team_fouls += player.FOUL;
            }
            return m_team_fouls;
        }

        public void DisplayTeam()
        {
            UPdateTeamPoints();

            Console.WriteLine("球队名称:" + m_tname);
            Console.WriteLine("球队队长:" + m_cap.Name);
            Console.WriteLine("球队得分:" + m_team_points);
            Console.WriteLine("球队犯规:" + m_team_fouls);
        }
        
    }
}

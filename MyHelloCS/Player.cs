using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHelloCS
{
    /// <summary>
    /// Player类是Model类，数据类。保存球员所有基本信息
    /// 
    /// </summary>
    public class Player
    {
        private String m_strName;//球员名称
        private int m_num;//球员号码
        private int m_foul;//个人犯规
        private int m_rebound;//个人篮板
        private int m_assist;//个人助攻
        private int m_point;//个人得分
        private int m_1pt;//罚中1分次数
        private int m_2pt;//投中2分次数
        private int m_3pt;//投中3分次数
        private int m_1pt_shoot;//罚篮次数
        private int m_2pt_shoot;//2分投篮次数
        private int m_3pt_shoot;//3分投篮次数
        
        private bool m_cap;//是否队长

        public Player()
        {
            this.m_strName = "巨星";
            this.m_num = 0;
            this.m_foul = 0;
            this.m_rebound = 0;
            this.m_assist = 0;
            this.m_point = 0;
            this.m_1pt = 0;
            this.m_2pt = 0;
            this.m_3pt = 0;
            this.m_1pt_shoot = 0;
            this.m_2pt_shoot = 0;
            this.m_3pt_shoot = 0;
            this.m_cap = false;

        }

        public Player(String name, int num)
        {
            this.m_strName = name;
            this.m_num = num;
            this.m_foul = 0;
            this.m_rebound = 0;
            this.m_assist = 0;
            this.m_point = 0;
            this.m_1pt = 0;
            this.m_2pt = 0;
            this.m_3pt = 0;
            this.m_1pt_shoot = 0;
            this.m_2pt_shoot = 0;
            this.m_3pt_shoot = 0;
            this.m_cap = false;

        }

        /// <summary>
        /// 球员名称
        /// </summary>
        public String Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }
        /// <summary>
        /// 犯规
        /// </summary>
        public int FOUL
        {
            get { return m_foul; }
            set { m_foul = value; }
        }

        /// <summary>
        /// 篮板
        /// </summary>
        public int REBOUND
        {
            get { return m_rebound; }
            set { m_rebound = value; }
        }

        /// <summary>
        /// 助攻
        /// </summary>
        /// <returns></returns>
        public int ASSIST
        {
            get { return m_assist; }
            set { m_assist = value; }
        }

        /// <summary>
        /// 得分
        /// </summary>
        public int POINTS
        {
            get { return m_point; }
            set { m_point = value; }
        }


        /// <summary>
        /// 球员投篮，数据统计
        /// </summary>
        /// <param name="point"></param>
        /// <param name="isHit"></param>
        public void Shoot(int point, bool isHit)
        {
            if (isHit)
            {
                switch (point)
                {
                    case 1:
                        m_1pt++;//罚中次数加1
                        m_1pt_shoot++;//罚篮次数加1
                        break;
                    case 2:
                        m_2pt++;
                        m_2pt_shoot++;//射中次数加1
                        break;
                    case 3:
                        m_3pt++;
                        m_3pt_shoot++;//射中次数加1
                        break;
                    default:
                        break;

                }
            }
            else
            {
                switch (point)
                {
                    case 1:
                        m_1pt_shoot++;//罚篮次数加1
                        break;
                    case 2:
                        m_2pt_shoot++;//射中次数加1
                        break;
                    case 3:
                        m_3pt_shoot++;//射中次数加1
                        break;
                    default:
                        break;

                }
            }

            //不管是否投中，计算一次得分
            m_point = m_1pt + m_2pt * 2 + m_3pt * 3;
        }

        /// <summary>
        /// 设为队长
        /// </summary>
        public void SetCaptain()
        {
            m_cap = true;
        }

        /// <summary>
        /// 取消队长
        /// </summary>
        public void ResetCaptain()
        {
            m_cap = false;
        }

        /// <summary>
        /// 球员犯规
        /// </summary>
        public void Foul()
        {
            if (m_foul < 6) m_foul++;  //6犯以下，累计犯规。
   
        }

        /// <summary>
        /// 判断是否已经6犯离场
        /// 提升点：读取比赛配置文件
        /// </summary>
        /// <returns></returns>
        public bool IsFoutOut()
        {
            if (m_foul >= 6) return true;
            else return false;
        }


        /// <summary>
        /// 助攻
        /// </summary>
        public void Assist()
        {
            m_assist++;
        }

        /// <summary>
        /// 篮板
        /// </summary>
        public void Rebound()
        {
            m_rebound++;
        }

        public double Calculate1ptRatio()
        {
            if (m_1pt_shoot == 0) return 1.0;
            else return (double)m_1pt / m_1pt_shoot;
        }

        public double Calculate2ptRatio()
        {
            if (m_2pt_shoot == 0) return 1.0;
            else return (double)m_2pt / m_2pt_shoot;
        }

        public double Calculate3ptRatio()
        {
            if (m_3pt_shoot == 0) return 1.0;
            else return (double)m_3pt / m_3pt_shoot;
        }


        public void DisplayPlayer()
        {
            Console.WriteLine("姓名:" + m_strName);
            Console.WriteLine("号码:" + m_num);
            Console.WriteLine("队长:" + m_cap);
            Console.WriteLine("得分:" + m_point);
            Console.WriteLine("篮板:" + m_rebound);
            Console.WriteLine("助攻:" + m_assist);
            Console.WriteLine("犯规:" + m_foul);
            Console.WriteLine("罚篮命中率:" + Calculate1ptRatio());
            Console.WriteLine("2分命中率:" + Calculate2ptRatio());
            Console.WriteLine("3分命中率:" + Calculate3ptRatio());
        }
    }
}

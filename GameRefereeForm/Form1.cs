using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameRefereeForm
{
    public partial class GameRefereeController : Form
    {
        public GameRefereeController()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加球队1球员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add1_Click(object sender, EventArgs e)
        {
            listBox_team1.Items.Add("邹昊东");
        }

        private void GameRefereeController_Load(object sender, EventArgs e)
        {

        }
    }
}

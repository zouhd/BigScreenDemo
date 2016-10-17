using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FenXingFormDemo
{
    public partial class ConsoleScreen : Form
    {
        private BigScreen m_big_screen;//大屏程序

        public ConsoleScreen()
        {
            InitializeComponent();

            m_big_screen = new BigScreen();
        }

        /***
         * 
         * 关闭窗口程序
         * 
         * */
        private void button_bigscreen_Click(object sender, EventArgs e)
        {

            m_big_screen.Show();
        }


    }
}

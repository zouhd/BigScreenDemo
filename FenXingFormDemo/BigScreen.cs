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
    public partial class BigScreen : Form
    {
        private int m_page_num;//当前显示第几页

        public BigScreen(int page_num = 1)
        {
            InitializeComponent();
            m_page_num = page_num;//默认第一页
            label_page.Text = m_page_num.ToString();

            if (m_page_num == 1)
                button_pre.Enabled = false;
        }

        /**
         * 上一页按钮
         */
        private void button_pre_Click(object sender, EventArgs e)
        {
            m_page_num--;
            if (m_page_num == 1)
            {
                button_pre.Enabled = false;

            }
            else
            {
                button_pre.Enabled = true;
            }

            button_next.Enabled = true;

            label_page.Text = m_page_num.ToString();
        }

        /**
         * 下一页按钮，默认共10页
         */
        private void button_next_Click(object sender, EventArgs e)
        {
            m_page_num++;
            if (m_page_num == 10)
            {
                button_next.Enabled = false;
            }
            else
            {
                button_next.Enabled = true;
            }

            button_pre.Enabled = true;
            label_page.Text = m_page_num.ToString();
        }

        /***
         * 窗口关闭事件处理，隐藏不关闭
         * */
        private void BigScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FenXingFormDemo
{
    public partial class BigScreen : Form
    {
        private int m_page_num;//当前显示第几页
        private String m_pic_dir;//存放图片的路径
        private List<PictureBox> m_pic_list;//大屏显示屏中的图片框列表，设计成4*5


        public BigScreen(int page_num = 1, String pic_dir = "..\\..\\pic\\")
        {
            InitializeComponent();
            m_page_num = page_num;//默认第一页
            m_pic_dir = pic_dir;//设置存放图片的路径

            m_pic_list = new List<PictureBox>();
            m_pic_list.Add(pictureBox1);
            m_pic_list.Add(pictureBox2);
            m_pic_list.Add(pictureBox3);
            m_pic_list.Add(pictureBox4);
            m_pic_list.Add(pictureBox5);
            

            label_page.Text = m_page_num.ToString();

            if (m_page_num == 1)
                button_pre.Enabled = false;
            LoadPic(m_page_num);
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

            LoadPic(m_page_num);

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

            LoadPic(m_page_num);
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

        /**
         * 载入图片，根据页面调整图片，每页20张图片，起始页图片编号001-020，第二页 021-040，依次类推
         * 每页图片编号开始001+ (page_num-1)*20，结尾page_num * 20
         * */
        public void LoadPic(int page_num)
        {
            
            String pic1_name = String.Format("{0}{1}{2}", m_pic_dir, page_num.ToString("D3"), ".jpg");
            pictureBox1.Load(pic1_name);
            //pictureBox1.Load(m_pic_dir + "001.jpg");
            pictureBox1.Show();

            pictureBox2.Load(m_pic_dir + "002.jpg");
            pictureBox2.Show();

            pictureBox3.Load(m_pic_dir + "003.jpg");
            pictureBox3.Show();


            pictureBox4.Load(m_pic_dir + "004.jpg");
            pictureBox4.Show();

            pictureBox5.Load(m_pic_dir + "005.jpg");
            pictureBox5.Show();

            
        }

        /***
         * 选中题目后改颜色
         */
        private void button_select_Click(object sender, EventArgs e)
        {
            int pic_num =  Int32.Parse(textBox_pic_num.Text);

            m_pic_list[pic_num - 1].BackColor = Color.Green;

        }

    }
}

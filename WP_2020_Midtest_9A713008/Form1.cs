using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_Midtest_9A713008.Properties;

namespace WP_2020_Midtest_9A713008
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Random a = new Random();//亂數種子
            int i = a.Next(1, 14);
            pB1.Image = list[i];
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Random a = new Random();//亂數種子
            int i = a.Next(1, 14);
            pB2.Image = list[i];
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            pB1.Image = Resources.P0;
            pB2.Image = Resources.P0;
        }

        #region 生命週期

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 撲克牌
            
            list.Add(Resources.P0);//背面
            list.Add(Resources.P1);//1
            list.Add(Resources.P5);//2
            list.Add(Resources.P9);//3
            list.Add(Resources.P13);//4
            list.Add(Resources.P17);//5
            list.Add(Resources.P21);//6
            list.Add(Resources.P25);//7
            list.Add(Resources.P29);//8
            list.Add(Resources.P33);//9
            list.Add(Resources.P37);//10
            list.Add(Resources.P41);//11
            list.Add(Resources.P45);//12
            list.Add(Resources.P49);//13
            #endregion
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        #endregion

        private void lab1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

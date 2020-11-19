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

        }
        #region 生命週期
        
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources.P0);
            list.Add(Resources.P1);
            list.Add(Resources.P5);
            list.Add(Resources.P9);
            list.Add(Resources.P13);
            list.Add(Resources.P17);
            list.Add(Resources.P21);
            list.Add(Resources.P25);
            list.Add(Resources.P29);
            list.Add(Resources.P33);
            list.Add(Resources.P37);
            list.Add(Resources.P41);
            list.Add(Resources.P45);
            list.Add(Resources.P49);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
         #endregion
    }
}

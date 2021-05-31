using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InfoChange info = new InfoChange();
             int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度

            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度然后定义窗口位置，以主窗体为例

            info.Location = new Point(xWidth / 2, yHeight / 2);//这里需要再减去窗体本身的宽度和高度的一半

            info.Show();
            this.Hide();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            Company company = new Company();
            this.Hide();
            company.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Message mes = new Message();
            
            this.Hide();
            mes.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Class1.userID == 1)
            {
                MessageBox.Show("您没有权限");

            }
            else if (Class1.userID == 0)
            {
                Other oth = new Other();
                this.Close();
                oth.Show();

            }
            else
            {
                MessageBox.Show("error");

            }
        }



        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

    }
}

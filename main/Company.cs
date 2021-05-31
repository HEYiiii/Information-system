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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        
        }
        private void formLoad(object sender, EventArgs e)
        {

            setListView();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InfoChange info = new InfoChange();
            this.Close();
            info.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            Company company = new Company();
            this.Close();
            company.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Message mes = new Message();
            this.Close();
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
            this.Close();
            form2.Show();
        }
        void setListView()
        {
            string strSQL = "select * from Company order by id desc";
            DataTable dt = new DataTable();
            dt = DBUtil.ExecuteDataSet(strSQL);
            if (dt.Rows.Count > 0)
            {
                listView1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = dt.Rows[i][0].ToString();
                    item.SubItems.Add(dt.Rows[i][1].ToString());
                    item.SubItems.Add(dt.Rows[i][2].ToString());
                    item.SubItems.Add(dt.Rows[i][3].ToString());
                    item.SubItems.Add(dt.Rows[i][4].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

    }
}

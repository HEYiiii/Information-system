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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }
        private void formLoad(object sender, EventArgs e)
        {

            setListView();
        }
        void setListView()
        {
            string strSQL = "select name,number,companyName from Student";
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
                    listView1.Items.Add(item);
                }
            }
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

        private void selectbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string str = "select name,number,companyName from Student ";
            string con = "";
            if (sno.Text != "")
            {
                con = con + "number='" + sno.Text + "'";
            }
            if (sname.Text != "")
            {
                if (con != "")
                {
                    con = con + "and name='" + sname.Text + "'";
                }
                else
                {
                    con = "name='" + sname.Text + "'";
                }
            }
            if (company.Text != "")
            {
                if (con != "")
                {
                    con = con + "and companyName='" + company.Text + "'";
                }
                else
                {
                    con = "companyName='" + company.Text + "'";
                }
            }
            if (con != "")
            {
                str = str + " where " + con;
            }
            dt = DBUtil.ExecuteDataSet(str);
            if (dt.Rows.Count > 0)
            {
                listView1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = dt.Rows[i][0].ToString();
                    item.SubItems.Add(dt.Rows[i][1].ToString());
                    item.SubItems.Add(dt.Rows[i][2].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        
        private void reset_Click(object sender, EventArgs e)
        {
            sno.Text = "";
            sname.Text = "";
            company.Text = "";
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            string str = "delete from  Student where number='" + sno.Text + "'";
            try
            {
                DBUtil.ExecuteSql(str);
                setListView();
                delStudentNum();
                MessageBox.Show("操作成功！");
            }
            catch (Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }
        private void delStudentNum()
        {
            DataTable dt1 = new DataTable();
            string strSql = "select StudentNum from Company where Name='" + company.Text + "'";
            dt1 = DBUtil.ExecuteDataSet(strSql);
            int num = Convert.ToInt32(dt1.Rows[0]["StudentNum"].ToString());
            if (num > 1)
            {
                num -= 1;
                string strSql1 = "update Company set StudentNum='" + num + "' where Name='" + company.Text + "'";
                try
                {
                    int intCount = DBUtil.ExecuteSql(strSql1);

                    if (intCount > 0)
                    {
                        //MessageBox.Show("num操作成功！");
                    }
                }
                catch (Exception eX)
                {
                    MessageBox.Show("操作失败！" + eX.ToString());
                }

            }
            else
            {
                string str = "delete from  Company where Name='" + company.Text + "'";
                
                    DBUtil.ExecuteSql(str);
                
            }
            //strSql = "select StudentNum from Company where Name='" + company.Text + "'";
            //dt1 = DBUtil.ExecuteDataSet(strSql);
            //num = Convert.ToInt32(dt1.Rows[0]["StudentNum"].ToString());
            //MessageBox.Show("numnew:" + num);

        }

        private void listView1_ItemClick(object sender, ItemCheckEventArgs e)
        {
            if (!listView1.Items[e.Index].Checked)
            {
                foreach (ListViewItem lv in listView1.Items)
                {
                    if (lv.Checked)
                    {
                        lv.Checked = false;
                        lv.Selected = false;
                    }
                }
                listView1.Items[e.Index].Selected = true;
            }
        }
        string name;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (listView1.SelectedItems.Count == 0) return;
            else
            {
                string username1 = listView1.SelectedItems[0].SubItems[0].Text;
                name = username1;
                string strSql = "select * from Student where name='" + username1 + "'";
                dt = DBUtil.ExecuteDataSet(strSql);
                this.sname.Text = dt.Rows[0]["name"].ToString();
                this.sno.Text = dt.Rows[0]["number"].ToString();
                this.company.Text = dt.Rows[0]["companyName"].ToString();

            }

        }

    }
}

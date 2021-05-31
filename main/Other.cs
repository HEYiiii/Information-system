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
    public partial class Other : Form
    {
        string userName = "";

        public Other()
        {
            InitializeComponent();
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






        //预加载数据
        private void formLoad(object sender, EventArgs e)
        {

            setListView();
        }
        void setListView()
        {
            string strSQL = "select * from tb_users";
            DataTable dt = new DataTable();
            dt = DBUtil.ExecuteDataSet(strSQL);
            if (dt.Rows.Count > 0)
            {
                listView1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = dt.Rows[i][0].ToString();
                    item.SubItems.Add(dt.Rows[i][2].ToString());
                    item.SubItems.Add(dt.Rows[i][3].ToString());
                    listView1.Items.Add(item);
                }
            }
        }




        private void insertbtn_Click(object sender, EventArgs e)
        {
            string str = "insert into tb_users(username,password,limit,email) ";
            str = str + " values ( '" + user.Text + "','";
            str = str + pwd.Text + "','";
            str = str + limit.Text + "','";
            str = str + email.Text + "')";
            try
            {
                int intCount = DBUtil.ExecuteSql(str);
                if (intCount > 0)
                {
                    setListView();
                    MessageBox.Show("操作成功！");
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string str = "delete from  tb_users where username='" + user.Text + "'";
            try
            {
                DBUtil.ExecuteSql(str);
                setListView();
                MessageBox.Show("操作成功！");
            }
            catch (Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }

        private void changectn_Click(object sender, EventArgs e)
        {
            {
                string str = user.Text;
                if (str == "")
                {
                    return;
                }
                if (userName == "")
                {
                    return;
                }
                if (userName != user.Text)
                {

                }
                string strSql = "update tb_users set username='";
                strSql += this.user.Text + "',password='";
                strSql += pwd.Text + "',limit='";
                strSql += limit.Text + "',email='";
                strSql += email.Text + "'";
                strSql += " where username='" + userName + "'";
                int intCount = DBUtil.ExecuteSql(strSql);
                if (intCount > 0)
                {
                    MessageBox.Show("操作成功!");
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }
                setListView();


            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string str = "select * from tb_users ";
            string con = "";
            if (user.Text != "")
            {
                con = con + "username='" + user.Text + "'";
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
                    item.SubItems.Add(dt.Rows[i][2].ToString());
                    item.SubItems.Add(dt.Rows[i][3].ToString());
                    listView1.Items.Add(item);
                }
            }
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
        private void reset_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pwd.Text = "";
            pwd2.Text = "";
            limit.Text = "";
            email.Text = "";
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (listView1.SelectedItems.Count == 0) return;
            else
            {
                string username1 = listView1.SelectedItems[0].SubItems[0].Text;
                userName = username1;
                string strSql = "select * from tb_users where username='" + username1 + "'";
                dt = DBUtil.ExecuteDataSet(strSql);
                this.user.Text = dt.Rows[0]["username"].ToString();
                this.pwd.Text ="";
                this.pwd2.Text = "";
                this.limit.Text = dt.Rows[0]["limit"].ToString();
                this.email.Text = dt.Rows[0]["email"].ToString();

            }

        }
    }
}

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
    public partial class 学生信息管理系统 : Form
    {
        string strNo = "";
        public 学生信息管理系统()
        {
            InitializeComponent();
        }


        private void formLoad(object sender, EventArgs e)
        {

            setListView();
        } 
        void setListView()
            {
                string strSQL = "select * from tb_studentinfo";
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

       

        private void insertbtn_Click(object sender, EventArgs e)
        {
            string str = "insert into tb_studentinfo(sno,sname,politics,birthday,address) ";
            str=str+" values ( '"+ sno.Text + "','";
            str=str+ sname.Text + "','";
            str = str +politics.Text + "','";
            str = str + birthday.Text + "','";
            str = str + address.Text + "')";
            try
            {
                int intCount = DBUtil.ExecuteSql(str);
                if (intCount > 0)
                {
                    setListView();
                    MessageBox.Show("操作成功！");
                }
            }catch(Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string str = "delete from  tb_studentinfo where sno='" + sno.Text + "'";
            try
            {
                DBUtil.ExecuteSql(str);
                setListView();
                MessageBox.Show("操作成功！");
            }
            catch(Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }

        private void changectn_Click(object sender, EventArgs e)
        {
            {
                string strsno = sno.Text;
                if (strsno == "")
                {
                    return;
                }
                if (strNo == "")
                {
                    return;
                }
                if (strNo != sno.Text)
                {

                }
                string strSql = "update tb_studentinfo set sno='";
                strSql += this.sno.Text + "',sname='";
                strSql += sname.Text + "',politics='";
                strSql += politics.Text + "',birthday='";
                strSql += birthday.Text + "',address='";
                strSql += address.Text + "'";
                strSql += " where sno='" + strNo + "'";
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

                /*        string strSno = sno.Text;
                        string str = "update tb_studentinfo set sno='";
                        str += sname.Text + "',politics='";
                        str += politics.Text + "',birthday='";
                        str += birthday.Text + "',address='";
                        str += address.Text + "' where sno='" + strNo+"'";
                        try
                        {
                            int intCount = DBUtil.ExecuteSql(str);
                            if (intCount > 0)
                            {
                                setListView();
                                MessageBox.Show("操作成功！" );
                            }
                        }
                        catch (Exception eX)
                        {
                            MessageBox.Show("操作失败！" + eX.ToString());
                        }
                */


            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string str = "select * from tb_studentinfo ";
            string con = "";
            if (sno.Text != "")
            {
                con = con + "sno='" + sno.Text + "'";
            }
            if (sname.Text != "")
            {
                if (con != "")
                {
                    con = con + "and sname='" + sname.Text + "'";
                }
                else
                {
                    con = "sname='" + sname.Text + "'";
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
                for(int i = 0; i < dt.Rows.Count; i++)
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

        private void listView1_ItemClick(object sender, ItemCheckEventArgs e)
        {
            if (!listView1.Items[e.Index].Checked)
            {
                foreach(ListViewItem lv in listView1.Items)
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
            sno.Text = "";
            sname.Text = "";
            politics.Text = "";
            birthday.Text = "";
            address.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            if (listView1.SelectedItems.Count == 0) return;
            else { 
                string strsno = listView1.SelectedItems[0].SubItems[0].Text;
                strNo = strsno;
                string strSql = "select * from tb_studentinfo where sno='" + strsno + "'";
                dt = DBUtil.ExecuteDataSet(strSql);
                this.sno.Text = dt.Rows[0]["sno"].ToString();
                this.sname.Text = dt.Rows[0]["sname"].ToString();
                this.politics.Text = dt.Rows[0]["politics"].ToString();
                this.birthday.Text = dt.Rows[0]["birthday"].ToString();
                this.address.Text = dt.Rows[0]["address"].ToString();

            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

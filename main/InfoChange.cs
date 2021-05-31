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
    public partial class InfoChange : Form
    {
       //  private Form2 returnForm = null;
        public InfoChange()
        {
            InitializeComponent();
            //this.returnForm = F2;
        }
        private void InfoChange_FormClosing()
        {
         //   this.returnForm.Visible = true;
        }

      
        private void selectbtn_Click(object sender, EventArgs e)
        {
            
        }
        string str1 = "0";
        private void insertCompany()
        {
            string strJudge = "select count(*) from Company where Name='" + companyName.Text + "'";
            DataTable dtCount = DBUtil.ExecuteDataSet(strJudge);
            int cnt = int.Parse(dtCount.Rows[0][0].ToString());
            MessageBox.Show("+" + cnt);
            if (cnt == 1)
            {
                //MessageBox.Show("existed");
                addStudentNum();
            }
            else
            {

            string companystr;
            companystr = "insert into Company(Name,Address,Postcode,StudentNum) ";
            companystr = companystr + " values ( '" + companyName.Text + "','";
            companystr = companystr + companyAddr.Text + "','";
            companystr = companystr + companyPostcode.Text + "','1')";

            try
            {
                int intCount = DBUtil.ExecuteSql(companystr);
                if (intCount > 0)
                {
                    MessageBox.Show("操作成功！");
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
            }




        }
        private void addStudentNum()
        {
            DataTable dt1 = new DataTable();
            string strSql = "select StudentNum from Company where Name='" + companyName.Text + "'";
            dt1 = DBUtil.ExecuteDataSet(strSql);
            int num = Convert.ToInt32(dt1.Rows[0]["StudentNum"].ToString());
            //MessageBox.Show("numold:" + num);

            num += 1;
            //MessageBox.Show("num:" + num);
            string strSql1 = "update Company set StudentNum='" + num + "' where Name='" + companyName.Text + "'";
            //update Company set StudentNum = '3' where Name = '11'
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

            strSql = "select StudentNum from Company where Name='" + companyName.Text + "'";
            dt1 = DBUtil.ExecuteDataSet(strSql);
            num = Convert.ToInt32(dt1.Rows[0]["StudentNum"].ToString());
            //MessageBox.Show("numnew:" + num);

        }
        private void insertbtn_Click(object sender, EventArgs e)
        {
            string selectstr;
            DataTable dt = new DataTable();
            if (Employed.Checked){
                str1 = "0";
            }
            else
            {
                str1 = "1";
                insertCompany();

            }
            string str2;
            if (str1 == "0")
            {
                 str2= "','' ,'' ,'','";
            }
            else
            {
                str2= companyName.Text + "','";
                str2 = str2 + companyAddr.Text + "','";
                str2 = str2 + companyPostcode.Text + "','";
                str2 = str2 + station.Text + "','";
                str2 = str2 + salary.Text ;

            }
            string str = "insert into Student(name,number,sex,IdentityNumber,Birthplace,nation,politic,phone,birthday,InDay,OutDay,xueyuan,zhuanye,teacher,education,Employed,companyName,companyAddr,companyPostcode,station,salary) ";
            str = str + " values ( '" + name.Text + "','";
            str = str + number.Text + "','";
            str = str + sex.Text + "','";
            str = str + IdentityNumber.Text + "','";
            str = str + Birthplace.Text + "','";
            str = str + nation.Text + "','";
            str = str + politic.Text + "','";
            str = str + phone.Text + "','";
            str = str + birthday.Text + "','";
            str = str + InDay.Text + "','";
            str = str + OutDay.Text + "','";
            str = str + xueyuan.Text + "','";
            str = str + zhuanye.Text + "','";
            str = str + teacher.Text + "','";
            str = str + education.Text + "','";
            str = str + str1 + "','";
            str = str + str2  +"')";
            //MessageBox.Show(str);
          try
            {
                int intCount = DBUtil.ExecuteSql(str);
                if (intCount > 0)
                {
                    MessageBox.Show("操作成功！");
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show("操作失败！" + eX.ToString());
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = "";
            number.Text = "";
            sex.Text = "";
            IdentityNumber.Text = "";
            Birthplace.Text = "";
            nation.Text = "";
            politic.Text = "";
            phone.Text = "";
            birthday.Text = "";
            InDay.Text = "";
            OutDay.Text = "";
            xueyuan.Text = "";
            zhuanye.Text = "";
            teacher.Text = "";
            education.Text = "";
            Employed.Text = "";
            companyName.Text = "";
            companyAddr.Text = "";
            companyPostcode.Text = "";
            station.Text = "";
            salary.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InfoChange info = new InfoChange();
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度

            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度然后定义窗口位置，以主窗体为例

            info.Location = new Point(xWidth / 2, yHeight / 2);//这里需要再减去窗体本身的宽度和高度的一半

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
    }
}

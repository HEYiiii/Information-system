using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace main
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string pwd = textBox2.Text; 
            //connection数据连接对象
            string strCon = "Data Source=DESKTOP-DMOU63U;Initial Catalog=c#;User Id=wmg;Password=wu000414mg";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            //command数据库命令对象
            SqlCommand cmd = new SqlCommand("select * from tb_users where username='" + name + "' and password='" + pwd + "'", con);
            //建立DataAdapter(数据适配器)和DataSet(数据集对象)
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            int n = da.Fill(ds, "register");
            if (n != 0)
            {

                DataTable dt = new DataTable();

                string strSql = "select * from tb_users where username='" + name + "'";
                dt = DBUtil.ExecuteDataSet(strSql);
                Class1.userID = Convert.ToInt32( dt.Rows[0]["limit"].ToString());

                int i = Class1.userID;
                MessageBox.Show("登录成功！" , "提示");

                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
            }
            con.Close();
        }
    }
}

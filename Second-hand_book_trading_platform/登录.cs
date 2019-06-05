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
using System.IO;

namespace Second_hand_book_trading_platform
{
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
        }
        public Form1 form = null;
        public void getForm (Form1 theForm)
        {
            form = theForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 登录_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                label3.Text = "请输入用户名";
            }
            else if (textBox2.Text.Trim() == "")
            {
                label3.Text = "请输入密码";
            }
            else
            {
                SqlConnection con = new SqlConnection(common.strcon);
                string cmdString = "select count(*) from TUser where Username = '"+ textBox1.Text.Trim() + "' and Password = '"+ textBox2.Text.Trim() + "'; ";
                SqlCommand cmd = new SqlCommand(cmdString, con);
                try
                {
                    con.Open();
                    DataTable dt=new DataTable();
                    SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    int x = (int)dt.Rows[0][0];
                    if (x == 0)
                    {
                        label3.Text = "用户名或密码错误";
                    }
                    else
                    {
                        cmdString = "select Admin from TUser where Username = '" + textBox1.Text.Trim() + "';";
                        cmd = new SqlCommand(cmdString, con);
                        adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                        adp.Fill(dt);
                        x = (int)dt.Rows[0][0];
                        //MessageBox.Show(x.ToString());
                        cmdString = "insert into TOnline (Username,Admin) values ('"+ textBox1.Text.Trim() + "','"+x.ToString()+"');";
                        cmd = new SqlCommand(cmdString, con);
                        cmd.ExecuteNonQuery();
                        form.label1.Text = textBox1.Text.Trim();
                        common.Username= textBox1.Text.Trim();
                        common.Admin = x;
                        if (x == 1) form.管理中心ToolStripMenuItem.Visible = true;
                        else form.管理中心ToolStripMenuItem.Visible = false;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出错！" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            注册 register = new 注册();
            register.Show();
        }
    }
}

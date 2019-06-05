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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = common.strcon;
        private void label1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strcon);
            string cmdString = "select * from TOnline;";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
            try
            {
                adp.Fill(dt);
                if(dt.Rows.Count!=0)
                {
                    DialogResult ret = MessageBox.Show("确定退出当前账户吗？", "退出账户", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(ret==DialogResult.Yes)
                    {
                        cmdString = "delete from TOnline";
                        cmd = new SqlCommand(cmdString, con);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            common.Username = "";
                            common.Admin = 0;
                            label1.Text = "登录";
                            this.管理中心ToolStripMenuItem.Visible = false;
                            MessageBox.Show("退出成功！");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("出错！" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    登录 login = new 登录();
                    login.getForm(this);
                    login.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("出错！" + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            common.Username = "";
            common.Admin = 0;
            SqlConnection con = new SqlConnection(strcon);
            string cmdString = "delete from TOnline;";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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

        private void 个人中心ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(label1.Text!="登录")
            {
                个人中心 form = new 个人中心();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先登录");
            }
        }

        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            公告 form = new 公告();
            form.Show();
        }

        private void 浏览图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            浏览图书 form = new 浏览图书();
            form.Show();
        }

        private void 管理中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户管理中心 form = new 用户管理中心();
            form.ShowDialog();
        }
    }
}

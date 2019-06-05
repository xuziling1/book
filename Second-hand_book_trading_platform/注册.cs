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
    public partial class 注册 : Form
    {
        public 注册()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                label6.Text = "请输入用户名";
            }
            else if (textBox2.Text.Trim() == "")
            {
                label6.Text = "请输入密码";
            }
            else if (textBox4.Text.Trim() == "")
            {
                label6.Text = "请输入联系电话";
            }
            else if (textBox2.Text.Trim() != textBox5.Text.Trim())
            {
                label6.Text = "两次密码不一致";
            }
            else
            {
                SqlConnection con = new SqlConnection(common.strcon);
                string cmdString = "select count(*) from TUser where Username = '" + textBox1.Text.Trim();
                SqlCommand cmd = new SqlCommand(cmdString, con);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                adp.Fill(dt);
                int x = (int)dt.Rows[0][0];
                if (x == 0)
                {
                    cmdString = "insert into TUser (Username,Password,Tel,Admin) values ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox4.Text.Trim() + "','0');";
                    cmd = new SqlCommand(cmdString, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("注册成功");
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
                else
                {
                    label6.Text = "用户名已存在";
                }
            }
        }
    }
}

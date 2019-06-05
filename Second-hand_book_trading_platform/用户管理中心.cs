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
    public partial class 用户管理中心 : Form
    {
        public 用户管理中心()
        {
            InitializeComponent();
        }
        string selected_admin = "";
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(common.strcon);
            string cmdString = "select [Username],[QQ],[Tel],[Photo],[Email],[Admin] from [TUser];";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdString, con);
                DataSet dtset = new DataSet();
                adapter.Fill(dtset, "testTable");
                dataGridView1.DataSource = dtset.Tables["testTable"];
                dataGridView1.Show();
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

        private void 用户管理中心_Load(object sender, EventArgs e)
        {
            button4_Click(null,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                selected_admin = dataGridView1.Rows[e.RowIndex].Cells["Admin"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdString ;
            if (textBox1.Text.Trim()=="")
            {
                cmdString = "select [Username],[QQ],[Tel],[Photo],[Email],[Admin] from [TUser];";
            }
            else
            {
                cmdString = "select [Username],[QQ],[Tel],[Photo],[Email],[Admin] from [TUser] where [Username]='"+ textBox1.Text.Trim() + "';";
            }
            SqlConnection con = new SqlConnection(common.strcon);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmdString, con);
                DataSet datable = new DataSet();
                adapter.Fill(datable, "testTable");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = datable.Tables["testTable"];
                dataGridView1.Show();
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

        private void 重置密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("请选中用户！");
                return;
            }
            string cmdString = "update [TUser] set";
            cmdString += "[Password]='" + "123456" + "' ";
            cmdString += "where Username = '" + textBox1.Text.Trim() + "'; ";
            SqlConnection con = new SqlConnection(common.strcon);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                { MessageBox.Show("请确认已选中想要操作的对象！"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show( cmdString+" 出错！" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void 删除该用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == common.Username)
            {
                MessageBox.Show("禁止对自己进行此操作！");
                return;
            }
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请选中用户！");
                return;
            }
            string cmdString = "delete from Tuser where  Username = '"+ textBox1.Text.Trim() + "';";
            SqlConnection con = new SqlConnection(common.strcon);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("删除成功！");
                    button4_Click(null, null);
                }
                else
                { MessageBox.Show("请确认已选中想要操作的对象！"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" 出错！" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void 设为管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请选中用户！");
                return;
            }
            if (selected_admin=="1")
            {
                MessageBox.Show("该用户已拥有管理员权限！");
                return;
            }
            string cmdString = "update [TUser] set";
            cmdString += "[Admin]='" + "1" + "' ";
            cmdString += "where Username = '" + textBox1.Text.Trim() + "'; ";
            SqlConnection con = new SqlConnection(common.strcon);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("修改成功！");
                    button4_Click(null, null);
                }
                else
                { MessageBox.Show("请确认已选中想要操作的对象！"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" 出错！" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void 删除管理员权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请选中用户！");
                return;
            }
            if (selected_admin == "0")
            {
                MessageBox.Show("该用户没有管理员权限！");
                return;
            }
            if (textBox1.Text.Trim() == common.Username)
            {
                MessageBox.Show("禁止对自己进行此操作！");
                return;
            }
            string cmdString = "update [TUser] set";
            cmdString += "[Admin]='" + "0" + "' ";
            cmdString += "where Username = '" + textBox1.Text.Trim() + "'; ";
            SqlConnection con = new SqlConnection(common.strcon);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("修改成功！");
                    button4_Click(null, null);
                }
                else
                { MessageBox.Show("请确认已选中想要操作的对象！"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" 出错！" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

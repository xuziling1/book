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
    public partial class 个人中心 : Form
    {
        public 个人中心()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void 个人中心_Load(object sender, EventArgs e)
        {
            updateDB();
        }
        private void updateDB()
        {
            label1.Text = "用户名：" + common.Username;
            SqlConnection con = new SqlConnection(common.strcon);
            string cmdString = "select * from TUser where Username = '" + common.Username + "'; ";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                label3.Text = "邮箱：" + dt.Rows[0]["Email"];
                label9.Text = "QQ：" + dt.Rows[0]["QQ"];
                label4.Text = "联系电话：" + dt.Rows[0]["Tel"];
                if (dt.Rows[0]["Photo"] != System.DBNull.Value)
                {
                    
                    byte[] mybyte = null;
                    //读取数据保存到数组中  
                    mybyte = (byte[])dt.Rows[0]["Photo"];
                    Image image;
                    //读取数组数据成为文件流  
                    MemoryStream mymemorystream = new MemoryStream(mybyte);
                    //转换成为图片格式。  
                    image = Image.FromStream(mymemorystream, true);
                    this.pictureBox1.Image = image;
                    mymemorystream.Close();  //关闭流  
                }
                    
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
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button2.Visible = true;
            textBox1.Text = label3.Text.Substring(3);
            textBox2.Text = label9.Text.Substring(3);
            textBox3.Text = label4.Text.Substring(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdString = "update [TUser] set";
            cmdString += "[Email]='" + textBox1.Text.Trim() + "',";
            cmdString += "[QQ]='" + textBox2.Text.Trim() + "',";
            cmdString += "[Tel]='" + textBox3.Text.Trim() + "' ";
            cmdString += "where Username = '" + common.Username + "'; ";
            SqlConnection con = new SqlConnection(common.strcon);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            try
            {
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("修改成功！");
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    button2.Visible = false;
                }
                else
                { MessageBox.Show("修改失败！"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(cmdString + " 出错！" + ex.Message);
            }
            finally
            {
                con.Close();
                updateDB();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();       //实例化打开文件对话框
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "jpg图片|*.jpg|gif图片|*.gif|所有文件(*.*)|*.*";//设置打开文件类型
            SqlConnection con = new SqlConnection(common.strcon);
            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;
            string FileNamePath = openFileDialog.FileName;         //获取文件路径
            //更新数据库图片
            try
            {
                con.Open();
                string path = FileNamePath;//文件路径                    
                //创建文件流，path参数是文件路径  
                FileStream fs = new FileStream(path, FileMode.Open);
                int streamLength = (int)fs.Length;  //获取文件流的长度。  
                byte[] image = new byte[streamLength];    //声明字节数组，用于保存图片文件  
                fs.Read(image, 0, streamLength);    //把图片文件转换成为字节数组保存  
                fs.Close();
                //插入Sql语句，@img是Sql语句参数。  
                string sql = string.Format("update [TUser] set [Photo]=@img where Username = '" + common.Username + "'; ", image);
                SqlCommand com = new SqlCommand(sql, con); //con是一个有效的连接对象  
                                                               //为命令对象添加参数，注意参数的类型  
                com.Parameters.Add(new SqlParameter("img", SqlDbType.Binary, image.Length,
                ParameterDirection.Input, true, 0, 0, null, DataRowVersion.Default, image));
                com.ExecuteNonQuery();   //执行  
                MessageBox.Show("插入成功");
                pictureBox1.Image = Image.FromFile(FileNamePath);//将图片显示在pictureBox中
            }
            catch (Exception ex)
            {
                MessageBox.Show( "插入图片不成功" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

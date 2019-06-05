namespace Second_hand_book_trading_platform
{
    partial class 用户管理中心
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sECOND_BOOKDataSet = new Second_hand_book_trading_platform.SECOND_BOOKDataSet();
            this.sECONDBOOKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重置密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除该用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设为管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除管理员权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECOND_BOOKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECONDBOOKDataSetBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 56);
            this.panel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "所有用户";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 25);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::Second_hand_book_trading_platform.Properties.Resources.find;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(355, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.QQ,
            this.Tel,
            this.Email,
            this.Admin});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.sECONDBOOKDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(721, 275);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sECOND_BOOKDataSet
            // 
            this.sECOND_BOOKDataSet.DataSetName = "SECOND_BOOKDataSet";
            this.sECOND_BOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sECONDBOOKDataSetBindingSource
            // 
            this.sECONDBOOKDataSetBindingSource.DataSource = this.sECOND_BOOKDataSet;
            this.sECONDBOOKDataSetBindingSource.Position = 0;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            // 
            // QQ
            // 
            this.QQ.DataPropertyName = "QQ";
            this.QQ.HeaderText = "QQ";
            this.QQ.Name = "QQ";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "联系电话";
            this.Tel.Name = "Tel";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "管理员权限";
            this.Admin.Name = "Admin";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重置密码ToolStripMenuItem,
            this.删除该用户ToolStripMenuItem,
            this.设为管理员ToolStripMenuItem,
            this.删除管理员权限ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 100);
            // 
            // 重置密码ToolStripMenuItem
            // 
            this.重置密码ToolStripMenuItem.Name = "重置密码ToolStripMenuItem";
            this.重置密码ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.重置密码ToolStripMenuItem.Text = "重置密码";
            this.重置密码ToolStripMenuItem.Click += new System.EventHandler(this.重置密码ToolStripMenuItem_Click);
            // 
            // 删除该用户ToolStripMenuItem
            // 
            this.删除该用户ToolStripMenuItem.Name = "删除该用户ToolStripMenuItem";
            this.删除该用户ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.删除该用户ToolStripMenuItem.Text = "删除该用户";
            this.删除该用户ToolStripMenuItem.Click += new System.EventHandler(this.删除该用户ToolStripMenuItem_Click);
            // 
            // 设为管理员ToolStripMenuItem
            // 
            this.设为管理员ToolStripMenuItem.Name = "设为管理员ToolStripMenuItem";
            this.设为管理员ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.设为管理员ToolStripMenuItem.Text = "设为管理员";
            this.设为管理员ToolStripMenuItem.Click += new System.EventHandler(this.设为管理员ToolStripMenuItem_Click);
            // 
            // 删除管理员权限ToolStripMenuItem
            // 
            this.删除管理员权限ToolStripMenuItem.Name = "删除管理员权限ToolStripMenuItem";
            this.删除管理员权限ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.删除管理员权限ToolStripMenuItem.Text = "删除管理员权限";
            this.删除管理员权限ToolStripMenuItem.Click += new System.EventHandler(this.删除管理员权限ToolStripMenuItem_Click);
            // 
            // 用户管理中心
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "用户管理中心";
            this.Text = "用户管理中心";
            this.Load += new System.EventHandler(this.用户管理中心_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECOND_BOOKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECONDBOOKDataSetBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sECONDBOOKDataSetBindingSource;
        private SECOND_BOOKDataSet sECOND_BOOKDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重置密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除该用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设为管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除管理员权限ToolStripMenuItem;
    }
}
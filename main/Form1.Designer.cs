namespace main
{
    partial class 学生信息管理系统
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sno = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.politics = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.学生学号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.学生姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.政治面貌 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.出生日期 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.家庭住址 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.changectn = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birthday = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生学号";
            // 
            // sno
            // 
            this.sno.Location = new System.Drawing.Point(216, 52);
            this.sno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(151, 25);
            this.sno.TabIndex = 1;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(503, 52);
            this.sname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(151, 25);
            this.sname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(413, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "学生姓名";
            // 
            // politics
            // 
            this.politics.Location = new System.Drawing.Point(216, 99);
            this.politics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.politics.Name = "politics";
            this.politics.Size = new System.Drawing.Size(151, 25);
            this.politics.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(117, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "政治面貌";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(413, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生日期";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(216, 146);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(439, 25);
            this.address.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(117, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "家庭住址";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.学生学号,
            this.学生姓名,
            this.政治面貌,
            this.出生日期,
            this.家庭住址});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 41);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(920, 302);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // 学生学号
            // 
            this.学生学号.Text = "学生学号";
            this.学生学号.Width = 100;
            // 
            // 学生姓名
            // 
            this.学生姓名.Text = "学生姓名";
            this.学生姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.学生姓名.Width = 100;
            // 
            // 政治面貌
            // 
            this.政治面貌.Text = "政治面貌";
            this.政治面貌.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.政治面貌.Width = 100;
            // 
            // 出生日期
            // 
            this.出生日期.Text = "出生日期";
            this.出生日期.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.出生日期.Width = 100;
            // 
            // 家庭住址
            // 
            this.家庭住址.Text = "家庭住址";
            this.家庭住址.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.家庭住址.Width = 300;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(1037, 109);
            this.insertbtn.Margin = new System.Windows.Forms.Padding(4);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(100, 29);
            this.insertbtn.TabIndex = 12;
            this.insertbtn.Text = "新增";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(1037, 157);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 29);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "删除";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // changectn
            // 
            this.changectn.Location = new System.Drawing.Point(1037, 205);
            this.changectn.Margin = new System.Windows.Forms.Padding(4);
            this.changectn.Name = "changectn";
            this.changectn.Size = new System.Drawing.Size(100, 29);
            this.changectn.TabIndex = 14;
            this.changectn.Text = "修改";
            this.changectn.UseVisualStyleBackColor = true;
            this.changectn.Click += new System.EventHandler(this.changectn_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(1037, 253);
            this.selectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(100, 29);
            this.selectbtn.TabIndex = 15;
            this.selectbtn.Text = "查询";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.birthday);
            this.groupBox1.Controls.Add(this.politics);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(219, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(761, 212);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生基本信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(504, 99);
            this.birthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(151, 25);
            this.birthday.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(186, 349);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(981, 358);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(1037, 299);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 29);
            this.reset.TabIndex = 19;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // 学生信息管理系统
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1237, 775);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.changectn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insertbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "学生信息管理系统";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.formLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sno;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox politics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button changectn;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader 学生学号;
        private System.Windows.Forms.ColumnHeader 学生姓名;
        private System.Windows.Forms.ColumnHeader 出生日期;
        private System.Windows.Forms.ColumnHeader 家庭住址;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.ColumnHeader 政治面貌;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.Button reset;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}


﻿namespace PTUDTM
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.userList1 = new PTUDTM.component.UserList();
            this.userList2 = new PTUDTM.component.UserList();
            this.userList3 = new PTUDTM.component.UserList();
            this.widgetNumber4 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber3 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber2 = new PTUDTM.component.WidgetNumber();
            this.widgetNumber1 = new PTUDTM.component.WidgetNumber();
            this.storyList1 = new PTUDTM.component.StoryList();
            this.storyList2 = new PTUDTM.component.StoryList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.widgetNumber4);
            this.panel1.Controls.Add(this.widgetNumber3);
            this.panel1.Controls.Add(this.widgetNumber2);
            this.panel1.Controls.Add(this.widgetNumber1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 171);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 855);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userList1);
            this.flowLayoutPanel1.Controls.Add(this.userList2);
            this.flowLayoutPanel1.Controls.Add(this.userList3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 755);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách người dùng";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(570, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 855);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.storyList1);
            this.flowLayoutPanel2.Controls.Add(this.storyList2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 97);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(909, 758);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách truyện mới nhất";
            // 
            // userList1
            // 
            this.userList1.Avatar = global::PTUDTM.Properties.Resources._51376355_554018558417057_2054804331131043840_n;
            this.userList1.Location = new System.Drawing.Point(3, 3);
            this.userList1.Name = "userList1";
            this.userList1.NameUser = "Diệp Hạ Nhi";
            this.userList1.Role = "Member";
            this.userList1.Size = new System.Drawing.Size(450, 150);
            this.userList1.TabIndex = 0;
            // 
            // userList2
            // 
            this.userList2.Avatar = ((System.Drawing.Image)(resources.GetObject("userList2.Avatar")));
            this.userList2.Location = new System.Drawing.Point(3, 159);
            this.userList2.Name = "userList2";
            this.userList2.NameUser = "Diệp Hạ Nhi";
            this.userList2.Role = "Member";
            this.userList2.Size = new System.Drawing.Size(450, 150);
            this.userList2.TabIndex = 1;
            // 
            // userList3
            // 
            this.userList3.Avatar = ((System.Drawing.Image)(resources.GetObject("userList3.Avatar")));
            this.userList3.Location = new System.Drawing.Point(3, 315);
            this.userList3.Name = "userList3";
            this.userList3.NameUser = "Duy khùng";
            this.userList3.Role = "Member";
            this.userList3.Size = new System.Drawing.Size(450, 150);
            this.userList3.TabIndex = 2;
            // 
            // widgetNumber4
            // 
            this.widgetNumber4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.widgetNumber4.Location = new System.Drawing.Point(1146, 21);
            this.widgetNumber4.Name = "widgetNumber4";
            this.widgetNumber4.Number = "0";
            this.widgetNumber4.Size = new System.Drawing.Size(344, 131);
            this.widgetNumber4.TabIndex = 3;
            this.widgetNumber4.Title = "Tổng thành viên";
            // 
            // widgetNumber3
            // 
            this.widgetNumber3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.widgetNumber3.Location = new System.Drawing.Point(777, 21);
            this.widgetNumber3.Name = "widgetNumber3";
            this.widgetNumber3.Number = "0";
            this.widgetNumber3.Size = new System.Drawing.Size(344, 131);
            this.widgetNumber3.TabIndex = 2;
            this.widgetNumber3.Title = "Tổng lượt xem";
            // 
            // widgetNumber2
            // 
            this.widgetNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.widgetNumber2.Location = new System.Drawing.Point(401, 21);
            this.widgetNumber2.Name = "widgetNumber2";
            this.widgetNumber2.Number = "0";
            this.widgetNumber2.Size = new System.Drawing.Size(344, 131);
            this.widgetNumber2.TabIndex = 1;
            this.widgetNumber2.Title = "Sách chưa kiểm duyệt";
            // 
            // widgetNumber1
            // 
            this.widgetNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.widgetNumber1.Location = new System.Drawing.Point(26, 21);
            this.widgetNumber1.Name = "widgetNumber1";
            this.widgetNumber1.Number = "35";
            this.widgetNumber1.Size = new System.Drawing.Size(344, 131);
            this.widgetNumber1.TabIndex = 0;
            this.widgetNumber1.Title = "Tổng số sách ";
            // 
            // storyList1
            // 
            this.storyList1.Author = "Tác giả:";
            this.storyList1.AuthorName = "Nguyễn Nhật Ánh";
            this.storyList1.Category = "Thể loại:";
            this.storyList1.CategoryName = "Truyện chữ";
            this.storyList1.DatePost = "Ngày đăng:";
            this.storyList1.Location = new System.Drawing.Point(3, 3);
            this.storyList1.Name = "storyList1";
            this.storyList1.Poster = ((System.Drawing.Image)(resources.GetObject("storyList1.Poster")));
            this.storyList1.Size = new System.Drawing.Size(868, 387);
            this.storyList1.TabIndex = 0;
            this.storyList1.Time = "16/07/2021";
            this.storyList1.Title = "MẮT BIẾC";
            this.storyList1.View = "Lượt xem:";
            this.storyList1.ViewNumber = "100";
            // 
            // storyList2
            // 
            this.storyList2.Author = "Tác giả:";
            this.storyList2.AuthorName = "Nguyễn Nhật Ánh";
            this.storyList2.Category = "Thể loại:";
            this.storyList2.CategoryName = "Truyện chữ";
            this.storyList2.DatePost = "Ngày đăng:";
            this.storyList2.Location = new System.Drawing.Point(3, 396);
            this.storyList2.Name = "storyList2";
            this.storyList2.Poster = ((System.Drawing.Image)(resources.GetObject("storyList2.Poster")));
            this.storyList2.Size = new System.Drawing.Size(868, 387);
            this.storyList2.TabIndex = 1;
            this.storyList2.Time = "16/07/2021";
            this.storyList2.Title = "MẮT BIẾC";
            this.storyList2.View = "Lượt xem:";
            this.storyList2.ViewNumber = "100";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 1037);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private component.WidgetNumber widgetNumber1;
        private component.WidgetNumber widgetNumber4;
        private component.WidgetNumber widgetNumber3;
        private component.WidgetNumber widgetNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.UserList userList1;
        private component.UserList userList2;
        private component.UserList userList3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private component.StoryList storyList1;
        private component.StoryList storyList2;
    }
}
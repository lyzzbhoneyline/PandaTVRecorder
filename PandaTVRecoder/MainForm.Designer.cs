/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/9/7
 * Time: 13:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PandaTVRecoder
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_first;
		private System.Windows.Forms.Panel panel_save;
		private System.Windows.Forms.Button btn_browser;
		private System.Windows.Forms.TextBox textBox_savepath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Panel panel_info;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel_all;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label_roomname;
		private System.Windows.Forms.Label label_playername;
		private System.Windows.Forms.Label label_isonline;
		private System.Windows.Forms.TextBox textBox_roomNum;
		private System.Windows.Forms.Button button_check;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox_line;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton r_openfile;
		private System.Windows.Forms.RadioButton r_opendir;
		private System.Windows.Forms.RadioButton r_nothing;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label_type;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel_loading;
		private System.Windows.Forms.PictureBox pictureBox_loading;
		private System.Windows.Forms.Label label10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		protected void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_start = new System.Windows.Forms.Button();
			this.panel_all = new System.Windows.Forms.Panel();
			this.panel_first = new System.Windows.Forms.Panel();
			this.button_check = new System.Windows.Forms.Button();
			this.textBox_roomNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_info = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label_type = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label_isonline = new System.Windows.Forms.Label();
			this.label_playername = new System.Windows.Forms.Label();
			this.label_roomname = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel_save = new System.Windows.Forms.Panel();
			this.r_nothing = new System.Windows.Forms.RadioButton();
			this.r_opendir = new System.Windows.Forms.RadioButton();
			this.r_openfile = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox_line = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_browser = new System.Windows.Forms.Button();
			this.textBox_savepath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel_loading = new System.Windows.Forms.Panel();
			this.pictureBox_loading = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel_all.SuspendLayout();
			this.panel_first.SuspendLayout();
			this.panel_info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel_save.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel_loading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_start
			// 
			this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_start.Enabled = false;
			this.btn_start.Location = new System.Drawing.Point(108, 231);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(128, 38);
			this.btn_start.TabIndex = 6;
			this.btn_start.Text = "开始录制";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// panel_all
			// 
			this.panel_all.Controls.Add(this.panel_first);
			this.panel_all.Controls.Add(this.panel_info);
			this.panel_all.Controls.Add(this.panel_save);
			this.panel_all.Location = new System.Drawing.Point(0, 0);
			this.panel_all.Name = "panel_all";
			this.panel_all.Size = new System.Drawing.Size(365, 228);
			this.panel_all.TabIndex = 7;
			// 
			// panel_first
			// 
			this.panel_first.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel_first.Controls.Add(this.button_check);
			this.panel_first.Controls.Add(this.textBox_roomNum);
			this.panel_first.Controls.Add(this.label1);
			this.panel_first.Location = new System.Drawing.Point(1, 1);
			this.panel_first.Name = "panel_first";
			this.panel_first.Size = new System.Drawing.Size(361, 37);
			this.panel_first.TabIndex = 8;
			// 
			// button_check
			// 
			this.button_check.Location = new System.Drawing.Point(226, 6);
			this.button_check.Name = "button_check";
			this.button_check.Size = new System.Drawing.Size(75, 23);
			this.button_check.TabIndex = 10;
			this.button_check.Text = "确定";
			this.button_check.UseVisualStyleBackColor = true;
			this.button_check.Click += new System.EventHandler(this.Button_checkClick);
			// 
			// textBox_roomNum
			// 
			this.textBox_roomNum.Location = new System.Drawing.Point(103, 8);
			this.textBox_roomNum.Name = "textBox_roomNum";
			this.textBox_roomNum.Size = new System.Drawing.Size(117, 21);
			this.textBox_roomNum.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "房间号：";
			// 
			// panel_info
			// 
			this.panel_info.BackColor = System.Drawing.SystemColors.Control;
			this.panel_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_info.Controls.Add(this.label9);
			this.panel_info.Controls.Add(this.label_type);
			this.panel_info.Controls.Add(this.label8);
			this.panel_info.Controls.Add(this.label_isonline);
			this.panel_info.Controls.Add(this.label_playername);
			this.panel_info.Controls.Add(this.label_roomname);
			this.panel_info.Controls.Add(this.label5);
			this.panel_info.Controls.Add(this.label4);
			this.panel_info.Controls.Add(this.label3);
			this.panel_info.Controls.Add(this.pictureBox2);
			this.panel_info.Enabled = false;
			this.panel_info.Location = new System.Drawing.Point(1, 39);
			this.panel_info.Name = "panel_info";
			this.panel_info.Size = new System.Drawing.Size(361, 113);
			this.panel_info.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.Purple;
			this.label9.Location = new System.Drawing.Point(106, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(244, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Author:Jte QQ330993746  SharpDevleop5.1";
			// 
			// label_type
			// 
			this.label_type.Location = new System.Drawing.Point(150, 48);
			this.label_type.Name = "label_type";
			this.label_type.Size = new System.Drawing.Size(156, 13);
			this.label_type.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label8.Location = new System.Drawing.Point(106, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "分 类:";
			// 
			// label_isonline
			// 
			this.label_isonline.Location = new System.Drawing.Point(150, 69);
			this.label_isonline.Name = "label_isonline";
			this.label_isonline.Size = new System.Drawing.Size(137, 13);
			this.label_isonline.TabIndex = 6;
			// 
			// label_playername
			// 
			this.label_playername.Location = new System.Drawing.Point(150, 27);
			this.label_playername.Name = "label_playername";
			this.label_playername.Size = new System.Drawing.Size(223, 13);
			this.label_playername.TabIndex = 5;
			// 
			// label_roomname
			// 
			this.label_roomname.Location = new System.Drawing.Point(150, 6);
			this.label_roomname.Name = "label_roomname";
			this.label_roomname.Size = new System.Drawing.Size(210, 12);
			this.label_roomname.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(106, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "状 态:";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(106, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "主 播:";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(106, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "房 间:";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(4, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 104);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel_save
			// 
			this.panel_save.Controls.Add(this.r_nothing);
			this.panel_save.Controls.Add(this.r_opendir);
			this.panel_save.Controls.Add(this.r_openfile);
			this.panel_save.Controls.Add(this.label7);
			this.panel_save.Controls.Add(this.comboBox_line);
			this.panel_save.Controls.Add(this.label6);
			this.panel_save.Controls.Add(this.btn_browser);
			this.panel_save.Controls.Add(this.textBox_savepath);
			this.panel_save.Controls.Add(this.label2);
			this.panel_save.Enabled = false;
			this.panel_save.Location = new System.Drawing.Point(1, 152);
			this.panel_save.Name = "panel_save";
			this.panel_save.Size = new System.Drawing.Size(361, 82);
			this.panel_save.TabIndex = 9;
			// 
			// r_nothing
			// 
			this.r_nothing.Location = new System.Drawing.Point(241, 52);
			this.r_nothing.Name = "r_nothing";
			this.r_nothing.Size = new System.Drawing.Size(75, 24);
			this.r_nothing.TabIndex = 17;
			this.r_nothing.TabStop = true;
			this.r_nothing.Text = "啥也不干";
			this.r_nothing.UseVisualStyleBackColor = true;
			// 
			// r_opendir
			// 
			this.r_opendir.Checked = true;
			this.r_opendir.Location = new System.Drawing.Point(79, 52);
			this.r_opendir.Name = "r_opendir";
			this.r_opendir.Size = new System.Drawing.Size(75, 24);
			this.r_opendir.TabIndex = 16;
			this.r_opendir.TabStop = true;
			this.r_opendir.Text = "打开目录";
			this.r_opendir.UseVisualStyleBackColor = true;
			// 
			// r_openfile
			// 
			this.r_openfile.Location = new System.Drawing.Point(160, 52);
			this.r_openfile.Name = "r_openfile";
			this.r_openfile.Size = new System.Drawing.Size(75, 24);
			this.r_openfile.TabIndex = 15;
			this.r_openfile.TabStop = true;
			this.r_openfile.Text = "打开视频";
			this.r_openfile.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(3, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "停止录制后：";
			// 
			// comboBox_line
			// 
			this.comboBox_line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_line.FormattingEnabled = true;
			this.comboBox_line.Location = new System.Drawing.Point(62, 31);
			this.comboBox_line.Name = "comboBox_line";
			this.comboBox_line.Size = new System.Drawing.Size(121, 20);
			this.comboBox_line.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(3, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "选择线路：";
			// 
			// btn_browser
			// 
			this.btn_browser.Location = new System.Drawing.Point(317, 2);
			this.btn_browser.Name = "btn_browser";
			this.btn_browser.Size = new System.Drawing.Size(34, 23);
			this.btn_browser.TabIndex = 8;
			this.btn_browser.Text = "```";
			this.btn_browser.UseVisualStyleBackColor = true;
			this.btn_browser.Click += new System.EventHandler(this.Btn_browserClick);
			// 
			// textBox_savepath
			// 
			this.textBox_savepath.Location = new System.Drawing.Point(62, 4);
			this.textBox_savepath.Name = "textBox_savepath";
			this.textBox_savepath.ReadOnly = true;
			this.textBox_savepath.Size = new System.Drawing.Size(249, 21);
			this.textBox_savepath.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "保存位置：";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 275);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(363, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(350, 17);
			this.toolStripStatusLabel1.Text = "等待开始录制";
			// 
			// panel_loading
			// 
			this.panel_loading.Controls.Add(this.pictureBox_loading);
			this.panel_loading.Controls.Add(this.label10);
			this.panel_loading.Location = new System.Drawing.Point(3, 40);
			this.panel_loading.Name = "panel_loading";
			this.panel_loading.Size = new System.Drawing.Size(358, 111);
			this.panel_loading.TabIndex = 12;
			this.panel_loading.Visible = false;
			// 
			// pictureBox_loading
			// 
			this.pictureBox_loading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loading.Image")));
			this.pictureBox_loading.Location = new System.Drawing.Point(236, 40);
			this.pictureBox_loading.Name = "pictureBox_loading";
			this.pictureBox_loading.Size = new System.Drawing.Size(27, 28);
			this.pictureBox_loading.TabIndex = 0;
			this.pictureBox_loading.TabStop = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(78, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(179, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "正在读取主播信息，请稍等！";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(363, 297);
			this.Controls.Add(this.panel_loading);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel_all);
			this.Controls.Add(this.btn_start);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "熊猫TV录制小工具";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel_all.ResumeLayout(false);
			this.panel_first.ResumeLayout(false);
			this.panel_first.PerformLayout();
			this.panel_info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel_save.ResumeLayout(false);
			this.panel_save.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel_loading.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

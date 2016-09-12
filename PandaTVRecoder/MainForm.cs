/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/9/7
 * Time: 13:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using LitJson;
using System.IO;
using System.Collections.Generic;
namespace PandaTVRecoder
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		IniHelper ih;
		WebClient client;
		Wininet wininet;
		String roomKey="";
		String curFileName="";
		String username ="";
	//	const String LOADING = "R0lGODlhHgAdAPfmAPX19fr6+v7+/vT09Pv7+/f39/Ly8vz8/PPz8/39/fj4+Pn5+fb29u7u7vHx8e/v7/Dw8Ojo6Orq6u3t7ezs7KGhoZKSkoWFhXZ2dnV1dePj4+bm5tnZ2Y2NjY+Pj93d3eXl5aSkpIuLi3BwcJWVlWNjY5mZmevr625ubqWlpeDg4I6OjqioqIeHh2RkZJ6enpOTk7GxsYODg3FxcZ2dnT09Pdzc3KysrJCQkJeXl62trefn55aWlpubm35+fn9/f4iIiKKiomJiYkxMTGBgYL+/v1ZWVtfX1+Li4oyMjF1dXYSEhK6uroqKipqampGRkdPT09/f3319fWpqamdnZ1lZWbm5uYaGhlVVVVNTU97e3k9PT87OzpiYmNHR0aampqmpqbq6uoCAgMDAwHl5eV5eXq+vr+Hh4eTk5NbW1omJienp6ZycnMXFxXNzc6qqqnx8fIGBgXh4eHp6elhYWEtLS0ZGRqenp2tra6CgoLCwsLi4uJSUlNXV1UJCQrKyss/Pz7S0tF9fX83NzcrKylxcXGlpaXR0dGZmZtjY2E1NTbOzs29vb7e3t9DQ0GhoaNra2ra2try8vHd3d1BQUMPDw6Ojo8fHx05OTm1tbcnJyaurq1FRUTY2NnJycr29vXt7e9vb2zw8PLW1tTs7O5+fn4KCgsTExMzMzMjIyCsrK9LS0ru7u1RUVFtbW0VFRWxsbC0tLTIyMsHBwcLCwkpKSlpaWsbGxjAwMDg4ODc3N0BAQDU1NUhISERERBsbGzk5OVdXV2FhYUdHR0lJSSwsLBYWFjMzMykpKTo6OiUlJSgoKEFBQSMjI8vLyyQkJD4+Pi8vLzExMTQ0NNTU1CcnJ0NDQz8/Py4uLiEhIRcXFxwcHCoqKiIiIh8fH1JSUhUVFb6+vhgYGBoaGh4eHv///////wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH/C05FVFNDQVBFMi4wAwEAAAAh/wtYTVAgRGF0YVhNUDw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuNS1jMDE0IDc5LjE1MTQ4MSwgMjAxMy8wMy8xMy0xMjowOToxNSAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENDIChXaW5kb3dzKSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo0RDUwOUUwOTc2NTQxMUU2OEYzOEU4ODQzQjk0RDM1NiIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDo0RDUwOUUwQTc2NTQxMUU2OEYzOEU4ODQzQjk0RDM1NiI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjRENTA5RTA3NzY1NDExRTY4RjM4RTg4NDNCOTREMzU2IiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjRENTA5RTA4NzY1NDExRTY4RjM4RTg4NDNCOTREMzU2Ii8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+Af/+/fz7+vn49/b19PPy8fDv7u3s6+rp6Ofm5eTj4uHg397d3Nva2djX1tXU09LR0M/OzczLysnIx8bFxMPCwcC/vr28u7q5uLe2tbSzsrGwr66trKuqqainpqWko6KhoJ+enZybmpmYl5aVlJOSkZCPjo2Mi4qJiIeGhYSDgoGAf359fHt6eXh3dnV0c3JxcG9ubWxramloZ2ZlZGNiYWBfXl1cW1pZWFdWVVRTUlFQT05NTEtKSUhHRkVEQ0JBQD8+PTw7Ojk4NzY1NDMy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";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			ih = new IniHelper("config.ini");
			client = new WebClient();
			wininet = new Wininet();
			String savePath = ih.GetValue("common","savePath");
			String roomID = ih.GetValue("common","roomID");
			String ichecked = ih.GetValue("common","checked");
			if(ichecked.Equals("0")){
				r_openfile.Checked=true;
			}else if(ichecked.Equals("1") || ichecked.Equals("")){
				r_opendir.Checked=true;
			}else{
				r_nothing.Checked = true;
			}
			textBox_roomNum.Text = roomID;
			if(savePath.Trim().Equals(string.Empty)){
				textBox_savepath.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
			}else{
				textBox_savepath.Text = savePath;
			}
			//pictureBox_loading.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(LOADING)));
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(btn_start.Text.Equals("停止录制")){
				DialogResult dr = MessageBox.Show("正在录制确定退出吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if(dr==DialogResult.OK){
					//...
					ih.SetValue("common", "savePath", textBox_savepath.Text);
					ih.SetValue("common", "roomID", textBox_roomNum.Text);
					if(r_openfile.Checked){
						ih.SetValue("common", "checked", 0);
					}else if(r_opendir.Checked){
						ih.SetValue("common", "checked", 1);
					}else{
						ih.SetValue("common", "checked", 2);
					}
				}else{
					e.Cancel = true;
				}
			}else{
				ih.SetValue("common", "savePath", textBox_savepath.Text);
				ih.SetValue("common", "roomID", textBox_roomNum.Text);
				if(r_openfile.Checked){
					ih.SetValue("common", "checked", 0);
				}else if(r_opendir.Checked){
					ih.SetValue("common", "checked", 1);
				}else{
					ih.SetValue("common", "checked", 2);
				}
			}
		}
		void Btn_browserClick(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog()==DialogResult.OK){
				textBox_savepath.Text = folderBrowserDialog1.SelectedPath;
			}
		}
		void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			toolStripStatusLabel1.Text = string.Format("当前接收到{0}MB", ((float)e.BytesReceived/1024/1024).ToString("0.00"));
			//this.progressBar1.Value = e.ProgressPercentage;
		}

		void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				if(r_opendir.Checked){
					System.Diagnostics.Process.Start(textBox_savepath.Text);
				}else if(r_openfile.Checked){
					System.Diagnostics.Process.Start(string.Format("{0}/{1}.flv", textBox_savepath.Text, curFileName));
				}
				
			}
//			//	this.progressBar1.Value = 0;
//			MessageBox.Show("文件下载成功", "提示");
		}
		void Btn_startClick(object sender, EventArgs e)
		{
			if(btn_start.Text.Equals("开始录制")){
				btn_start.Text = "停止录制";
				panel_all.Enabled = false;
				String line = ((ComboBoxItem)comboBox_line.SelectedItem).value.Split('_')[1];
				
				//文件名
				curFileName = GetTimeByCSharp13();
				String fullFileName = string.Format("{0}/{1}-{2}/{3}.flv", textBox_savepath.Text, username,DateTime.Now.ToString("yyyy年MM月dd日"), curFileName);
				String fileDir = Directory.GetParent(fullFileName).FullName;
				if(!Directory.Exists(fileDir)){
					Directory.CreateDirectory(fileDir);
				}
				client.DownloadFileAsync(new Uri(string.Format("http://pl{0}.live.panda.tv/live_panda/{1}.flv",line, roomKey)),fullFileName);
				client.DownloadProgressChanged += client_DownloadProgressChanged;
				client.DownloadFileCompleted += client_DownloadFileCompleted;
			}else{
				client.CancelAsync();
				btn_start.Text = "开始录制";
				panel_all.Enabled = true;
			}
		}
		void Button_checkClick(object sender, EventArgs e)
		{
			//start a thread to read info
			//pictureBox_loading.Visible = true;
			button_check.Enabled = false;
			panel_loading.Visible = true;
			System.Threading.ThreadPool.QueueUserWorkItem((s) => checkInfo());
		}
		public void checkInfo(){
			if(textBox_roomNum.Text.Trim().Equals(string.Empty)){
				this.Invoke(new MethodInvoker(delegate{
				                              	MessageBox.Show("房间号不能为空,请自重！","鹅鹅鹅~",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				                              	textBox_roomNum.Text = string.Empty;
				                              }));
				return;
			}
			bool isOnLine = true;
			if(!isOnLine){
				return;
			}
			String roomID = textBox_roomNum.Text.Trim();
			using(WebClient web = new WebClient()){
				String str = System.Text.Encoding.UTF8.GetString(web.DownloadData(string.Format("http://www.panda.tv/api_room_v2?roomid={0}&pub_key=&_={1}",roomID, GetTimeByCSharp13())));
				JsonData jd = JsonMapper.ToObject(str);
				string errno = jd["errno"].ToString();
				if(!errno.Equals("0")){
					this.Invoke(new MethodInvoker(delegate{
					                              	panel_loading.Visible = false;
					                              	button_check.Enabled = true;
					                              	pictureBox2.Image = null;
					                              	label_roomname.Text=string.Empty;
					                              	label_playername.Text = string.Empty;
					                              	label_type.Text = string.Empty;
					                              	label_isonline.Text = string.Empty;
					                              	MessageBox.Show("房间号不存在！,先上熊猫官网看下吧！","鹅鹅鹅~",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					                              }));
					return;
				}
				//获取房主信息
				username = jd["data"]["hostinfo"]["name"].ToString();
				String avatar = jd["data"]["hostinfo"]["avatar"].ToString();
				String roomName = jd["data"]["roominfo"]["name"].ToString();
				String classification = jd["data"]["roominfo"]["classification"].ToString();
				roomKey = jd["data"]["videoinfo"]["room_key"].ToString();
				String status = jd["data"]["videoinfo"]["status"].ToString();
				String plflag = jd["data"]["videoinfo"]["plflag"].ToString();
				
				String SD = jd["data"]["videoinfo"]["stream_addr"]["SD"].ToString().Equals("1")?"true":"false";
				String HD = jd["data"]["videoinfo"]["stream_addr"]["HD"].ToString().Equals("1")?"true":"false";
				String OD = jd["data"]["videoinfo"]["stream_addr"]["OD"].ToString().Equals("1")?"true":"false";
				String ddd = string.Format("{0}|{1}|{2}", SD, HD, OD);
				
				int tmp1 = (Convert.ToInt32(plflag.Split('_')[0]) - 1);
				String tmp2 = plflag.Split('_')[1];
				if(tmp2.Equals("21")){
					tmp1=10;
					tmp2 = "4";
				}
				comboBox_line.Items.Clear();
				if(tmp1==1){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","2_3"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","4_7"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路2","5_9"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路3","6_14"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路4","12_24"));
				}else if(tmp1==2){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","3_5"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","2_4"));
				}else if(tmp1==3){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","4_8"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","2_4"));
				}else if(tmp1==4){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","5_10"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","2_4"));
				}else if(tmp1==5){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","6_13"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","2_4"));
				}else if(tmp1==6){
					comboBox_line.Items.Add(new ComboBoxItem("主线路","7_11"));
					comboBox_line.Items.Add(new ComboBoxItem("备用线路1","2_4"));
				}
				Image img = BytesToImage(web.DownloadData(avatar));
				this.Invoke(new MethodInvoker(delegate{
				                              	comboBox_line.SelectedIndex=0;
				                              	label_type.Text = classification;
				                              	label_roomname.Text = roomName;
				                              	label_playername.Text = username;
				                              	pictureBox2.Image = img;
				                              	button_check.Enabled = true;
				                              	panel_loading.Visible = false;
				                              }));
				if(!status.Equals("2")){
					this.Invoke(new MethodInvoker(delegate{
					                              	label_isonline.Text = "离线";
					                              	label_isonline.ForeColor = Color.Red;
					                              	panel_info.Enabled = false;
					                              	panel_save.Enabled = false;
					                              	btn_start.Enabled = false;
					                              	//pictureBox_loading.Visible = false;	
					                              	MessageBox.Show("主播不在线哦，试试其他主播的房间号吧！","阿西吧~",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					                              }));
					return;
				}
				this.Invoke(new MethodInvoker(delegate{
				                              	label_isonline.Text = "在线";
				                              	label_isonline.ForeColor = Color.Green;
				                              	panel_info.Enabled = true;
				                              	panel_save.Enabled = true;
				                              	btn_start.Enabled = true;
				                              	//pictureBox_loading.Visible = false;
				                              	MessageBox.Show("主播在线哦！点击开始录制尽情录制吧！","卡机嘛~",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				                              }));
			}
		}
		public string GetStringMid(string allStr, string firstStr, string lastStr)
		{
			//取出前面的位置
			int index1 = allStr.IndexOf(firstStr);
			//取出后面的位置
			int index2 = allStr.IndexOf(lastStr, index1 + firstStr.Length);

			if (index1 < 0 || index2 < 0)
			{
				return "";
			}
			//定位到前面的位置
			index1 = index1 + firstStr.Length;
			//判断要取的文本的长度
			index2 = index2 - index1;

			if (index1 < 0 || index2 < 0)
			{
				return "";
			}
			//取出文本
			return allStr.Substring(index1, index2);
		}
		
		
		
		//10位时间戳
        public string GetTimeByCSharp10()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        
        //13位时间戳
		public string GetTimeByCSharp13(int nAddSecond = 0)
		{
			return (DateTime.UtcNow.AddSeconds(nAddSecond) - DateTime.Parse("1970-01-01 0:0:0")).TotalMilliseconds.ToString("0");
		}
		public static Image BytesToImage(byte[] buffer)
		{
			using(MemoryStream ms = new MemoryStream(buffer)){
				Image image = System.Drawing.Image.FromStream(ms);
				return image;
			}
			
			
		}
	}
	class ComboBoxItem{
		public ComboBoxItem(String k, String v){
			key = k;
			value = v;
		}
		public String key;
		public String value;
		public override string ToString()
		{
			return key;
		}

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Claunia.PropertyList;
using LibUsbDotNet;
using LibUsbDotNet.DeviceNotify;
using Renci.SshNet;

// Token: 0x0200000D RID: 13
public partial class ByteM8 : Form
{
	// Token: 0x0600003D RID: 61 RVA: 0x00958440 File Offset: 0x00956640
	public ByteM8()
	{
		object obj = Activator.CreateInstance(typeof(Dictionary<string, string>));
		obj.Add("iPhone1,1", "iPhone 1");
		obj.Add("iPhone1,2", "iPhone 3G");
		obj.Add("iPhone2,1", "iPhone 3GS");
		obj.Add("iPhone3,1", "iPhone 4");
		obj.Add("iPhone3,2", "iPhone 4 (GSM)");
		obj.Add("iPhone3,3", "iPhone 4 (CDMA)");
		obj.Add("iPhone4,1", "iPhone 4s");
		obj.Add("iPhone5,1", "iPhone 5 (GSM+CDMA)");
		obj.Add("iPhone5,2", "iPhone 5 (GSM+CDMA)");
		obj.Add("iPhone5,3", "iPhone 5c (GSM+CDMA)");
		obj.Add("iPhone5,4", "iPhone 5c (GSM+CDMA)");
		obj.Add("iPhone6,1", "iPhone 5s CDMA)");
		obj.Add("iPhone6,2", "iPhone 5s (GSM+CDMA)");
		obj.Add("iPhone7,1", "iPhone 6 Plus");
		obj.Add("iPhone7,2", "iPhone 6");
		obj.Add("iPhone8,1", "iPhone 6s");
		obj.Add("iPhone8,2", "iPhone 6s Plus");
		obj.Add("iPhone8,4", "iPhone SE (1st generation)");
		obj.Add("iPhone9,1", "iPhone 7 (CDMA)");
		obj.Add("iPhone9,2", "iPhone 7 Plus (CDMA)");
		obj.Add("iPhone9,3", "iPhone 7 (GSM)");
		obj.Add("iPhone9,4", "iPhone 7 Plus (GSM)");
		obj.Add("iPhone10,1", "iPhone 8 (CDMA)");
		obj.Add("iPhone10,3", "iPhone X (CDMA)");
		obj.Add("iPhone10,4", "iPhone 8 (GSM)");
		obj.Add("iPhone10,2", "iPhone 8 Plus");
		obj.Add("iPhone10,5", "iPhone 8 Plus (GSM)");
		obj.Add("iPhone10,6", "iPhone X (GSM)");
		obj.Add("iPhone11,8", "iPhone XR");
		obj.Add("iPhone11,2", "iPhone XS");
		obj.Add("iPhone11,4", "iPhone XS Max");
		obj.Add("iPhone11,6", "iPhone XS Max");
		obj.Add("iPhone12,1", "iPhone 11");
		obj.Add("iPhone12,3", "iPhone 11 Pro");
		obj.Add("iPhone12,5", "iPhone 11 Pro Max");
		obj.Add("iPhone13,1", "iPhone 12 mini");
		obj.Add("iPhone13,2", "iPhone 12");
		obj.Add("iPhone13,3", "iPhone 12 Pro");
		obj.Add("iPhone13,4", "iPhone 12 Pro Max");
		obj.Add("iPhone14,4", "iPhone 13 mini");
		obj.Add("iPhone14,5", "iPhone 13");
		obj.Add("iPhone14,2", "iPhone 13 Pro");
		obj.Add("iPhone14,3", "iPhone 13 Pro Max");
		obj.Add("iPhone14,6", "iPhone SE (3rd generation)");
		obj.Add("iPhone14,7", "iPhone 14");
		obj.Add("iPhone14,8", "iPhone 14 Plus");
		obj.Add("iPhone15,2", "iPhone 14 Pro");
		obj.Add("iPhone15,3", "iPhone 14 Pro Max");
		obj.Add("iPad1,1", "iPad");
		obj.Add("iPad2,1", "iPad 2");
		obj.Add("iPad2,2", "iPad 2");
		obj.Add("iPad2,3", "iPad 2");
		obj.Add("iPad2,4", "iPad 2");
		obj.Add("iPad3,1", "iPad (3rd generation)");
		obj.Add("iPad3,2", "iPad (3rd generation)");
		obj.Add("iPad3,3", "iPad (3rd generation)");
		obj.Add("iPad3,4", "iPad (4th generation)");
		obj.Add("iPad3,5", "iPad (4th generation)");
		obj.Add("iPad3,6", "iPad (4th generation)");
		obj.Add("iPad6,11", "iPad (5th generation)");
		obj.Add("iPad6,12", "iPad (5th generation)");
		obj.Add("iPad7,5", "iPad (6th generation)");
		obj.Add("iPad7,6", "iPad (6th generation)");
		obj.Add("iPad7,11", "iPad (7th generation)");
		obj.Add("iPad7,12", "iPad (7th generation)");
		obj.Add("iPad11,6", "iPad (8th generation)");
		obj.Add("iPad11,7", "iPad (8th generation)");
		obj.Add("iPad12,1", "iPad (9th generation)");
		obj.Add("iPad12,2", "iPad (9th generation)");
		obj.Add("iPad4,1", "iPad Air");
		obj.Add("iPad4,2", "iPad Air");
		obj.Add("iPad4,3", "iPad Air");
		obj.Add("iPad5,3", "iPad Air 2");
		obj.Add("iPad5,4", "iPad Air 2");
		obj.Add("iPad11,3", "iPad Air (3rd generation)");
		obj.Add("iPad11,4", "iPad Air (3rd generation)");
		obj.Add("iPad13,1", "iPad Air (4th generation)");
		obj.Add("iPad13,2", "iPad Air (4th generation)");
		obj.Add("iPad2,5", "iPad mini");
		obj.Add("iPad2,6", "iPad mini");
		obj.Add("iPad2,7", "iPad mini");
		obj.Add("iPad4,4", "iPad mini 2");
		obj.Add("iPad4,5", "iPad mini 2");
		obj.Add("iPad4,6", "iPad mini 2");
		obj.Add("iPad4,7", "iPad mini 3");
		obj.Add("iPad4,8", "iPad mini 3");
		obj.Add("iPad4,9", "iPad mini 3");
		obj.Add("iPad5,1", "iPad mini 4");
		obj.Add("iPad5,2", "iPad mini 4");
		obj.Add("iPad11,1", "iPad mini (5th generation)");
		obj.Add("iPad11,2", "iPad mini (5th generation)");
		obj.Add("iPod1,1", "iPod touch");
		obj.Add("iPod2,1", "iPod touch (2nd generation)");
		obj.Add("iPod3,1", "iPod touch (3rd generation)");
		obj.Add("iPod4,1", "iPod touch (4th generation)");
		obj.Add("iPod5,1", "iPod touch (5th generation)");
		obj.Add("iPod7,1", "iPod touch (6th generation)");
		obj.Add("iPod9,1", "iPod touch (7th generation)");
		obj.Add("Watch1,1", "Apple Watch (1st generation) 38mm");
		obj.Add("Watch1,2", "Apple Watch (1st generation) 42mm");
		obj.Add("Watch2,6", "Apple Watch Series 1 38mm");
		obj.Add("Watch2,7", "Apple Watch Series 1 42mm");
		obj.Add("Watch2,3", "Apple Watch Series 2 38mm");
		obj.Add("Watch2,4", "Apple Watch Series 2 42mm");
		obj.Add("Watch3,1", "Apple Watch Series 3 (GPS) 38mm");
		obj.Add("Watch3,2", "Apple Watch Series 3 (GPS) 42mm");
		obj.Add("Watch3,3", "Apple Watch Series 3 (GPS + Cellular) 38mm");
		obj.Add("Watch3,4", "Apple Watch Series 3 (GPS + Cellular) 42mm");
		obj.Add("Watch4,1", "Apple Watch Series 4 (GPS) 40mm");
		obj.Add("Watch4,2", "Apple Watch Series 4 (GPS) 44mm");
		obj.Add("Watch4,3", "Apple Watch Series 4 (GPS + Cellular) 40mm");
		obj.Add("Watch4,4", "Apple Watch Series 4 (GPS + Cellular) 44mm");
		obj.Add("Watch5,1", "Apple Watch Series 5 (GPS) 40mm");
		obj.Add("Watch5,2", "Apple Watch Series 5 (GPS) 44mm");
		obj.Add("Watch5,3", "Apple Watch Series 5 (GPS + Cellular) 40mm");
		obj.Add("Watch5,4", "Apple Watch Series 5 (GPS + Cellular) 44mm");
		obj.Add("Watch6,1", "Apple Watch Series 6 (GPS) 40mm");
		obj.Add("Watch6,2", "Apple Watch Series 6 (GPS) 44mm");
		obj.Add("Watch6,3", "Apple Watch Series 6 (GPS + Cellular) 40mm");
		obj.Add("Watch6,4", "Apple Watch Series 6 (GPS + Cellular) 44mm");
		obj.Add("Watch7,1", "Apple Watch Series 7 (GPS) 41mm");
		obj.Add("Watch7,2", "Apple Watch Series 7 (GPS) 45mm");
		obj.Add("Watch7,3", "Apple Watch Series 7 (GPS + Cellular) 41mm");
		obj.Add("Watch7,4", "Apple Watch Series 7 (GPS + Cellular) 45mm");
		this.dictionary_0 = obj;
		this.icontainer_0 = null;
		base..ctor();
		if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count<Process>() > 1)
		{
			Process.GetCurrentProcess().Kill();
			base.Activate();
		}
		this.method_48<ComponentResourceManager, Container, Label, Panel, Button, BackgroundWorker, PictureBox, object, EventArgs, ProcessStartInfo, Image, Icon, DialogResult, bool, FormClosingEventArgs, List<string>, DeviceNotifyEventArgs>();
		this.backgroundWorker_0.DoWork += this.method_0<List<string>, object, DoWorkEventArgs>;
		this.timer_0.Tick += this.method_2<bool, object, EventArgs>;
		this.timer_0.Interval = 200;
		this.toolTip_0.SetToolTip(this.pictureBox7, "Help");
		this.toolTip_0.SetToolTip(this.pictureBox6, "Register Device");
		this.toolTip_0.SetToolTip(this.pictureBox8, "Join telegram group");
		this.toolTip_0.SetToolTip(this.pictureBox4, "Watch Tutorials");
		this.toolTip_0.SetToolTip(this.label11, "Message iOS Nemes1s on telegram");
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00958E1C File Offset: 0x0095701C
	private void method_0<T0, T1, T2>(T1 gparam_0, T2 gparam_1)
	{
		T0 t = gparam_1.Argument as List<string>;
		this.method_1<Task<bool>, T0>(t).Wait();
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00958E44 File Offset: 0x00957044
	[DebuggerStepThrough]
	public T0 method_1<T0, T1>(T1 gparam_0)
	{
		ByteM8.Class15 @class = new ByteM8.Class15();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.list_0 = gparam_0;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class15>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00958E90 File Offset: 0x00957090
	private void method_2<T0, T1, T2>(T1 gparam_0, T2 gparam_1)
	{
		T0 t = this.int_0 <= this.int_1;
		if (t != null)
		{
			this.label1.Text = this.string_1;
			this.string_1 += ".";
			this.int_0++;
		}
		else
		{
			this.string_1 = this.string_0;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00958EFC File Offset: 0x009570FC
	[DebuggerStepThrough]
	public T0 method_3<T0>()
	{
		ByteM8.Class9 @class = new ByteM8.Class9();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class9>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00958F40 File Offset: 0x00957140
	public T3 method_4<T0, T1, T2, T3, T4>(T4 gparam_0)
	{
		T3 t3;
		using (T0 t = ByteM8.smethod_2())
		{
			T1[] array = t.DownloadData(gparam_0);
			using (T2 t2 = new MemoryStream(array))
			{
				t3 = Image.FromStream(t2);
			}
		}
		return t3;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00958F9C File Offset: 0x0095719C
	public void method_5<T0, T1>()
	{
		this.sshClient_0 = new SshClient("127.0.0.1", 2222, "root", "alpine");
		this.scpClient_0 = new ScpClient("127.0.0.1", 2222, "root", "alpine");
		T0[] processesByName = Process.GetProcessesByName("iproxy");
		for (T1 t = 0; t < processesByName.Length; t++)
		{
			T0 t2 = processesByName[t];
			t2.Kill();
		}
		T0 t3 = ByteM8.smethod_3();
		t3.StartInfo.FileName = Environment.CurrentDirectory + "/ref/iproxy.exe";
		t3.StartInfo.Arguments = "2222 44";
		t3.StartInfo.UseShellExecute = false;
		t3.StartInfo.CreateNoWindow = true;
		t3.StartInfo.RedirectStandardError = true;
		t3.Start();
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00959068 File Offset: 0x00957268
	[DebuggerStepThrough]
	public T0 method_6<T0>()
	{
		ByteM8.Class10 @class = new ByteM8.Class10();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class10>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x009590AC File Offset: 0x009572AC
	public T2 method_7<T0, T1, T2>(T1 gparam_0, T1 gparam_1)
	{
		T0 allWinUsbDevices = UsbDevice.AllWinUsbDevices;
		for (T1 t = 0; t < allWinUsbDevices.Count; t++)
		{
			if (allWinUsbDevices[t].Vid == gparam_0 && allWinUsbDevices[t].Pid == gparam_1)
			{
				return 1;
			}
		}
		return 0;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00959104 File Offset: 0x00957304
	[DebuggerStepThrough]
	public T0 method_8<T0>()
	{
		ByteM8.Class12 @class = new ByteM8.Class12();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class12>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00959148 File Offset: 0x00957348
	[DebuggerStepThrough]
	public T0 method_9<T0>()
	{
		ByteM8.Class11 @class = new ByteM8.Class11();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class11>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0095918C File Offset: 0x0095738C
	public void method_10<T0>()
	{
		if (!this.string_3.Contains("CDMA") && !this.string_3.Contains("iPhone 6") && !this.string_3.Contains("iPhone SE") && !this.string_3.Contains("Global") && !this.string_3.Contains("iPod") && !this.string_3.Contains("iPad"))
		{
			T0 t = this.string_13 == "" || this.string_3.Contains("GSM");
			if (t != null)
			{
				this.bool_3 = true;
			}
		}
		else
		{
			this.bool_3 = false;
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00959244 File Offset: 0x00957444
	public async void method_11<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		string text = gparam_1.Device.IdProduct.ToString();
		string text2 = gparam_1.Device.IdVendor.ToString();
		if (gparam_1.EventType.ToString() == "DeviceArrival")
		{
			if (text2 == "1452" && (text == "4776" || text == "4779"))
			{
				this.timer_0.Start();
				TaskAwaiter<bool> taskAwaiter = this.method_3<Task<bool>>().GetAwaiter();
				TaskAwaiter<bool> taskAwaiter2;
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<bool>);
				}
				bool result = taskAwaiter.GetResult();
				if (result)
				{
					try
					{
						TaskAwaiter<bool> taskAwaiter3 = this.method_9<Task<bool>>().GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							taskAwaiter3 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<bool>);
						}
						bool result2 = taskAwaiter3.GetResult();
						bool flag = result2;
						this.jbText.Text = (flag ? "Yes" : "No");
						this.button1.Text = ((flag || this.string_15.StartsWith("12") || this.string_15.StartsWith("13") || this.string_15.StartsWith("14")) ? "Start Bypass" : "Boot Device");
						this.string_3 = this.dictionary_0[this.string_14];
						this.method_10<bool>();
						string text3 = (this.bool_3 ? " - GSM Device" : " - MEID Device");
						this.ModelText.Text = this.string_3 + text3;
						this.Text = "ByteM8 Activator " + this.string_19 + " - " + this.string_3;
						this.pictureBox3.Image = this.method_4<WebClient, byte, MemoryStream, Image, string>("https://ipsw.me/assets/devices/" + this.string_14 + ".png");
						this.toolTip_0.SetToolTip(this.pictureBox3, this.string_3);
						TaskAwaiter<bool> taskAwaiter4 = this.method_13<Task<bool>>().GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							await taskAwaiter4;
							taskAwaiter4 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<bool>);
						}
						taskAwaiter4.GetResult();
						this.panel1.Visible = true;
						base.Activate();
						if (!flag)
						{
							MessageBox.Show("iDevice connected, now click on Boot Device and\nfollow the instructions to jailbreak the iDevice.", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						text3 = null;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						this.pictureBox1.Visible = false;
						this.pictureBox2.Visible = false;
						this.pictureBox5.Visible = true;
						this.timer_0.Stop();
						this.Text = "ByteM8 Activator " + this.string_19;
						this.label1.Text = "Ooops, couldn't connect to server.";
						base.Activate();
					}
				}
			}
		}
		else if (gparam_1.EventType.ToString() == "DeviceRemoveComplete" && text2 == "1452" && (text == "4776" || text == "4779"))
		{
			this.method_12();
			this.timer_0.Stop();
			this.Text = "ByteM8 Activator v1.0";
			this.label1.Text = "Please connect a device via USB.";
			this.panel1.Visible = false;
			this.pictureBox1.Visible = true;
			this.pictureBox2.Visible = true;
			this.pictureBox5.Visible = false;
			base.Activate();
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0095928C File Offset: 0x0095748C
	[DebuggerStepThrough]
	public static T0 smethod_0<T0, T1>(T1 gparam_0)
	{
		ByteM8.Class14 @class = new ByteM8.Class14();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@class.string_0 = gparam_0;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class14>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x009592D0 File Offset: 0x009574D0
	public void method_12()
	{
		this.IMEIText.Text = "N/A";
		this.SrlNum.Text = "N/A";
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00959300 File Offset: 0x00957500
	[DebuggerStepThrough]
	public T0 method_13<T0>()
	{
		ByteM8.Class19 @class = new ByteM8.Class19();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class19>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00959344 File Offset: 0x00957544
	private void method_14<T0, T1, T2, T3, T4>(T2 gparam_0, T3 gparam_1)
	{
		T0 t = !Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).EndsWith("tonyg");
		if (t != null)
		{
			object obj = Activator.CreateInstance(typeof(T1));
			obj.Add(".cs");
			obj.Add(".vb");
			T1 t2 = ByteM8.smethod_1<string, T1, T0, List<string>.Enumerator>(obj);
			this.backgroundWorker_0.RunWorkerAsync(t2);
		}
		ByteM8.ideviceNotifier_0.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(this.method_11<T2, T4>);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x009593B8 File Offset: 0x009575B8
	private void method_15<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		this.SrlNum.ForeColor = Color.DodgerBlue;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x009593D8 File Offset: 0x009575D8
	private void method_16<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		this.SrlNum.ForeColor = Color.Black;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x009593F8 File Offset: 0x009575F8
	private void method_17<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		Clipboard.SetText(this.string_7);
		this.SrlNum.Text = "Copied";
		this.timer_1.Start();
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0095942C File Offset: 0x0095762C
	private void method_18<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		this.timer_0.Stop();
		this.SrlNum.Text = this.string_7;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00959458 File Offset: 0x00957658
	private static T1 smethod_1<T0, T1, T2, T3>(T1 gparam_0)
	{
		T0 t = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
		T1 t2 = Activator.CreateInstance(typeof(T1));
		T2 t3 = Directory.Exists(t);
		if (t3 != null)
		{
			T3 enumerator = gparam_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					T0 t4 = enumerator.Current;
					T0[] files = Directory.GetFiles(t, "*" + t4, SearchOption.AllDirectories);
					t2.AddRange(files);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}
		return t2;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x009594F4 File Offset: 0x009576F4
	public void method_19()
	{
		this.pictureBox9.Visible = false;
		this.button1.Text = "Start Bypass";
		this.button1.Cursor = Cursors.Hand;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00959530 File Offset: 0x00957730
	private async void method_20<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		if (this.button1.Text == "Start Bypass")
		{
			this.method_21();
			this.pictureBox9.Visible = true;
			this.button1.Text = "Start Bypass      ";
			this.button1.Cursor = Cursors.No;
			TaskAwaiter<bool> taskAwaiter = this.method_9<Task<bool>>().GetAwaiter();
			TaskAwaiter<bool> taskAwaiter2;
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<bool>);
			}
			bool result = taskAwaiter.GetResult();
			if (result)
			{
				TaskAwaiter<bool> taskAwaiter3 = this.method_6<Task<bool>>().GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<bool>);
				}
				if (!taskAwaiter3.GetResult())
				{
					ProcessStartInfo processStartInfo = ByteM8.Class16.smethod_0();
					processStartInfo.FileName = "https://iosnemes1s.pythonanywhere.com/bytem8";
					processStartInfo.UseShellExecute = true;
					Process.Start(processStartInfo);
					MessageBox.Show("Great! Now register your SN before proceeding!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					try
					{
						if (!Directory.Exists(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6))
						{
							await this.method_23<Task<string>>();
							this.method_24<string, XmlDocument, XmlNode, byte>();
						}
						try
						{
							await Task.Run(new Action(this.method_55<string, SshCommand, StreamReader>));
							MessageBox.Show("Bypass successful. Enjoy!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						catch
						{
							MessageBox.Show("There was an error bypassing iDevice!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					catch
					{
						MessageBox.Show("Ooops, there was an error generating activaion record!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
			else
			{
				MessageBox.Show("Please jailbreak your device with palera1n!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.method_21();
			this.pictureBox9.Visible = false;
			this.button1.Text = "Start Bypass";
			this.button1.Cursor = Cursors.Hand;
		}
		else if (this.button1.Text == "Boot Device")
		{
			jailbreak jailbreak = new jailbreak();
			jailbreak.Owner = this;
			jailbreak.ShowDialog();
			jailbreak = null;
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00959578 File Offset: 0x00957778
	public void method_21()
	{
		Directory.Delete(Environment.CurrentDirectory + "/ref/tmp", true);
		Directory.CreateDirectory(Environment.CurrentDirectory + "/ref/tmp");
	}

	// Token: 0x06000056 RID: 86 RVA: 0x009595B0 File Offset: 0x009577B0
	public T2 method_22<T0, T1, T2>()
	{
		T0 length = new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/1").Length;
		T1 t = length / 1024.0;
		T2 t2;
		if (t < 5.0)
		{
			t2 = 0;
		}
		else
		{
			t2 = 1;
		}
		return t2;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0095960C File Offset: 0x0095780C
	[DebuggerStepThrough]
	public T0 method_23<T0>()
	{
		ByteM8.Class13 @class = new ByteM8.Class13();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class13>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00959650 File Offset: 0x00957850
	public void method_24<T0, T1, T2, T3>()
	{
		Directory.CreateDirectory(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/FairPlay/iTunes_Control/iTunes/");
		T0 t = File.ReadAllText("./ref/tmp/" + this.string_6 + "/1");
		T1 t2 = ByteM8.smethod_4();
		t2.LoadXml(t);
		T2 t3 = t2.SelectSingleNode("//key[text()='FairPlayKeyData']");
		T2 nextSibling = t3.NextSibling;
		T0 innerText = nextSibling.InnerText;
		T3[] array = Convert.FromBase64String(innerText);
		T0 @string = Encoding.ASCII.GetString(array);
		T0 t4 = "./ref/tmp/" + this.string_6 + "/FairPlay/iTunes_Control/iTunes/IC-Info.sisv";
		T3[] array2 = Convert.FromBase64String(@string.Replace("-----END CONTAINER-----", "").Replace("-----BEGIN CONTAINER-----", "").Replace("\n", "")
			.Replace("\r", ""));
		File.WriteAllBytes(t4, array2);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0095973C File Offset: 0x0095793C
	public T1 method_25<T0, T1, T2>(T1 gparam_0)
	{
		T0 t = this.sshClient_0.CreateCommand(gparam_0);
		T1 t3;
		try
		{
			t.BeginExecute();
			T2 t2 = new StreamReader(t.OutputStream);
			t3 = t2.ReadToEnd();
		}
		catch
		{
			t3 = "";
		}
		return t3;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00959790 File Offset: 0x00957990
	public void method_26<T0>()
	{
		using (T0 t = ByteM8.smethod_3())
		{
			t.StartInfo.FileName = Environment.CurrentDirectory + "/ref/ideviceactivation.exe";
			t.StartInfo.Arguments = "deactivate";
			t.StartInfo.UseShellExecute = false;
			t.StartInfo.RedirectStandardOutput = true;
			t.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			t.StartInfo.CreateNoWindow = true;
			t.Start();
			t.StandardOutput.ReadToEnd();
			t.WaitForExit();
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00959834 File Offset: 0x00957A34
	public void method_27<T0, T1, T2>(T2 gparam_0)
	{
		using (T0 t = ByteM8.smethod_3())
		{
			t.StartInfo.FileName = Environment.CurrentDirectory + "/ref/ideviceactivation.exe";
			T1 t2 = gparam_0 == "";
			if (t2 != null)
			{
				t.StartInfo.Arguments = "activate";
			}
			else
			{
				t.StartInfo.Arguments = "activate -s " + gparam_0;
			}
			t.StartInfo.UseShellExecute = false;
			t.StartInfo.RedirectStandardOutput = true;
			t.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			t.StartInfo.CreateNoWindow = true;
			t.Start();
			t.StandardOutput.ReadToEnd();
			t.WaitForExit();
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00959900 File Offset: 0x00957B00
	public void method_28<T0>()
	{
		T0 t = ByteM8.smethod_3();
		t.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "ref", "idevicediagnostics.exe");
		t.StartInfo.Arguments = "restart";
		t.StartInfo.UseShellExecute = false;
		t.StartInfo.CreateNoWindow = true;
		t.Start();
		t.WaitForExit();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00959968 File Offset: 0x00957B68
	public void method_29<T0, T1>()
	{
		T0 t = this.method_33<HttpWebRequest, T0, HttpWebResponse, StreamReader>();
		t = t.ToString().Replace("\n", "").Replace("\r", "")
			.Replace("\t", "");
		File.WriteAllText(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/act_rec.plist.tmp", t);
		T1 t2 = (T1)((object)PropertyListParser.Parse(new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/act_rec.plist.tmp")));
		this.string_16 = this.method_35<NSObject, T0, T1, int>(t2, "WildcardTicketToRemove", 4);
		t2.Remove("WildcardTicketToRemove");
		PropertyListParser.SaveAsXml(t2, new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/activation_record.plist"));
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00959A40 File Offset: 0x00957C40
	public void method_30<T0, T1, T2>(T2 gparam_0)
	{
		T0 t = ByteM8.smethod_3();
		T1 t2 = ByteM8.smethod_5();
		t2.WindowStyle = ProcessWindowStyle.Hidden;
		t2.FileName = Path.Combine(Environment.CurrentDirectory, "ref", "win-plutil.exe");
		T2 t3 = string.Format("\"{0}\"", gparam_0);
		t2.Arguments = "-convert binary1 " + t3;
		t.StartInfo = t2;
		t.Start();
		t.WaitForExit();
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00959AAC File Offset: 0x00957CAC
	public void method_31<T0>()
	{
		T0 t = (T0)((object)PropertyListParser.Parse(new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/com.apple.commcenter.device_specific_nobackup.plist")));
		try
		{
			t.Remove("kPostponementTicket");
		}
		catch
		{
		}
		NSDictionary nsdictionary = t;
		string text = "kPostponementTicket";
		NSDictionary nsdictionary2 = ByteM8.smethod_6();
		nsdictionary2.Add("ActivationState", "Activated");
		nsdictionary2.Add("ActivationTicket", this.string_16);
		nsdictionary2.Add("ActivityURL", "https://albert.apple.com/deviceservices/activity");
		nsdictionary2.Add("PhoneNumberNotificationURL", "https://albert.apple.com/deviceservices/phoneHome");
		nsdictionary.Add(text, nsdictionary2);
		PropertyListParser.SaveAsXml(t, new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/com.apple.commcenter.device_specific_nobackup.plist"));
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00959B7C File Offset: 0x00957D7C
	public void method_32<T0>()
	{
		T0 t = (T0)((object)PropertyListParser.Parse(new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/data_ark.plist")));
		try
		{
			t.Remove("-UCRTOOBForbidden");
			t.Remove("ActivationState");
			t.Remove("-ActivationState");
			t.Add("ActivationState", "Activated");
		}
		catch (Exception)
		{
		}
		PropertyListParser.SaveAsXml(t, new FileInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6 + "/data_ark.plist"));
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00959C24 File Offset: 0x00957E24
	public T1 method_33<T0, T1, T2, T3>()
	{
		T0 t = WebRequest.CreateHttp("http://ahmedunllock.tech/windows/AIO_PHPP/GSM-2/gsm_activation_record.php?serial=" + this.string_7);
		t.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		t.Timeout = 12000;
		T1 t4;
		using (T2 t2 = (T2)((object)t.GetResponse()))
		{
			using (T3 t3 = new StreamReader(t2.GetResponseStream()))
			{
				t4 = t3.ReadToEnd();
			}
		}
		return t4;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00959CB4 File Offset: 0x00957EB4
	public T0 method_34<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		return gparam_0.Split(Environment.NewLine.ToCharArray(), gparam_1 + 1).Skip(gparam_1).FirstOrDefault<T0>();
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00959CE4 File Offset: 0x00957EE4
	public T1 method_35<T0, T1, T2, T3>(T2 gparam_0, T1 gparam_1, T3 gparam_2 = 4)
	{
		T0 t;
		gparam_0.TryGetValue(gparam_1, out t);
		return this.method_34<T1, T3>(t.ToXmlPropertyList().ToString(), gparam_2).Replace("\n", "").Replace("\r", "")
			.Replace("</data>", "")
			.Replace("</plist>", "")
			.Replace("</string>", "")
			.Replace("<string>", "")
			.Trim();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00959D70 File Offset: 0x00957F70
	public void method_36<T0, T1, T2, T3>()
	{
		T0 t = string.Concat(new T0[]
		{
			"https://hasnit3ch.com/Backup/Ramdisktool/Files/MDM68/OFFLINE.php?serial=", this.string_7, "&uuid=", this.string_8, "&type=", this.string_14, "&ver=", this.string_15, "&ime=", this.string_12,
			"&build=", this.string_18
		});
		T1 t2 = WebRequest.CreateHttp(t);
		t2.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		t2.Timeout = 12000;
		using (T2 t3 = (T2)((object)t2.GetResponse()))
		{
			using (T3 t4 = new StreamReader(t3.GetResponseStream()))
			{
				t4.ReadToEnd();
			}
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00959E64 File Offset: 0x00958064
	public void method_37<T0, T1>()
	{
		T0 t = "https://hasnit3ch.com/Backup/Ramdisktool/Files/MDM68/MDM.zip";
		using (T1 t2 = ByteM8.smethod_2())
		{
			t2.DownloadFile(t, Environment.CurrentDirectory + "/ref/tmp/MDM.zip");
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00959EB0 File Offset: 0x009580B0
	public void method_38<T0>()
	{
		T0 t = Environment.CurrentDirectory + "/ref/tmp/MDM.zip";
		T0 t2 = Environment.CurrentDirectory + "/ref/tmp/ffe2017db9c5071adfa1c23d3769970f7524a9d4";
		ZipFile.ExtractToDirectory(t, t2);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00959EE4 File Offset: 0x009580E4
	public void method_39<T0, T1, T2, T3>()
	{
		T0 t = ByteM8.smethod_3();
		Process process = t;
		T2 t2 = ByteM8.smethod_5();
		t2.FileName = Environment.CurrentDirectory + "/ref/idevicebackup2.exe";
		t2.Arguments = string.Concat(new T1[]
		{
			"restore -u ",
			this.string_8,
			" -s ffe2017db9c5071adfa1c23d3769970f7524a9d4 --system --reboot --settings \"",
			Path.Combine(Environment.CurrentDirectory, "ref", "tmp"),
			"\""
		});
		t2.UseShellExecute = false;
		t2.RedirectStandardOutput = true;
		t2.CreateNoWindow = true;
		process.StartInfo = t2;
		T0 t3 = t;
		t3.Start();
		T1 t4 = t3.StandardOutput.ReadToEnd();
		T3 t5 = t4.Contains("com.apple.mobilebackup2.");
		if (t5 != null)
		{
			throw new Exception("Device could not be activated, Maybe FMI is turned on.");
		}
		T3 t6 = t4.Contains("disabled");
		if (t6 != null)
		{
			throw new Exception("Please disable FMI before proceeding.");
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00959FC4 File Offset: 0x009581C4
	public void method_40<T0, T1, T2>()
	{
		this.sshClient_0.CreateCommand("mount -o rw,union,update /").Execute();
		T0 t = this.method_25<T1, T0, T2>("find /private/var/containers/Data/System/ -iname 'internal'").Replace("Library/internal", "").Replace("\n", "")
			.Replace("//", "/");
		this.sshClient_0.CreateCommand("chflags nouchg " + t + "Library/internal/data_ark.plist").Execute();
		this.sshClient_0.CreateCommand("chflags nouchg " + t + "Library/activation_records/activation_record.plist").Execute();
		this.sshClient_0.CreateCommand("chflags nouchg /private/var/mobile/Library/Preferences/com.apple.purplebuddy.plist").Execute();
		this.sshClient_0.CreateCommand("chflags nouchg /private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist").Execute();
		this.sshClient_0.CreateCommand("chflags nouchg /private/var/root/Library/Lockdown/data_ark.plist").Execute();
		this.sshClient_0.CreateCommand("rm " + t + "Library/internal/data_ark.plist").Execute();
		this.sshClient_0.CreateCommand("chmod -R 755 /private/var/containers/Data/System").Execute();
		this.sshClient_0.CreateCommand("mkdir -p " + t + "Library/activation_records").Execute();
		this.sshClient_0.CreateCommand("mkdir /private/var/mobile/Media/Downloads/" + this.string_6).Execute();
		this.scpClient_0.Upload(new DirectoryInfo(Environment.CurrentDirectory + "/ref/tmp/" + this.string_6), "/private/var/mobile/Media/Downloads/" + this.string_6);
		this.sshClient_0.CreateCommand("cp -r /private/var/mobile/Media/Downloads" + this.string_6 + "/3 /private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist").Execute();
		this.sshClient_0.CreateCommand("usr/sbin/chown root:mobile /private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist").Execute();
		this.sshClient_0.CreateCommand("chmod 755 /private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist").Execute();
		this.sshClient_0.CreateCommand("chflags uchg /private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist").Execute();
		this.sshClient_0.CreateCommand(string.Concat(new T0[] { "cp -r /private/var/mobile/Media/Downloads/", this.string_6, "/1 ", t, "Library/activation_records/activation_record.plist" })).Execute();
		this.sshClient_0.CreateCommand("chflags -R nouchg /System/Library/PrivateFrameworks/MobileActivation.framework/Support/Certificates").Execute();
		this.sshClient_0.CreateCommand("cp -rp /System/Library/PrivateFrameworks/MobileActivation.framework/Support/Certificates/FactoryActivation.pem /System/Library/PrivateFrameworks/MobileActivation.framework/Support/Certificates/RaptorActivation.pem").Execute();
		this.sshClient_0.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();
		this.sshClient_0.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();
		T0 t2 = this.method_25<T1, T0, T2>("grep -Rhl 'com.apple.fairplayd.H2' /private/var/containers/Data/System");
		this.sshClient_0.CreateCommand("mkdir -p " + t2 + "/Documents/Media/iTunes_Control/iTunes/../../Library/FairPlay/iTunes_Control/iTunes").Execute();
		this.sshClient_0.CreateCommand(string.Concat(new T0[] { "cp -rp /private/var/mobile/Media/Downloads/", this.string_6, "/FairPlay/iTunes_Control/iTunes/IC-Info.sisv ", t2, "/Documents/Media/iTunes_Control/iTunes/IC-Info.sidv" })).Execute();
		this.sshClient_0.CreateCommand(string.Concat(new T0[] { "cp -rp /private/var/mobile/Media/Downloads/", this.string_6, "/FairPlay/iTunes_Control/iTunes/IC-Info.sisv ", t2, "/Documents/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv" })).Execute();
		this.sshClient_0.CreateCommand("mkdir -m 755 -p /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/").Execute();
		this.sshClient_0.CreateCommand("cp -rp /private/var/mobile/Media/Downloads/" + this.string_6 + "/FairPlay/iTunes_Control/iTunes/IC-Info.sisv /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv").Execute();
		this.sshClient_0.CreateCommand("chmod 0644 /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/*").Execute();
		this.sshClient_0.CreateCommand("chown -R mobile:mobile /private/var/mobile/Library/FairPlay/").Execute();
		try
		{
			this.sshClient_0.CreateCommand("mv -f /private/var/mobile/Media/Downloads/" + this.string_6 + "/4 /private/var/mobile/Library/Preferences/com.apple.purplebuddy.plist").Execute();
			this.sshClient_0.CreateCommand("chmod 600 /private/var/mobile/Library/Preferences/com.apple.purplebuddy.plist").Execute();
		}
		catch
		{
		}
		this.sshClient_0.CreateCommand("rm -rf /private/var/mobile/Library/Logs/*").Execute();
		this.sshClient_0.CreateCommand("rm -rf /private/var/mobile/Library/Logs/*").Execute();
		this.sshClient_0.CreateCommand("rm -rf /private/var/mobile/Media/Downloads/" + this.string_6).Execute();
		this.sshClient_0.CreateCommand("mount -o rw,union,update /private/preboot").Execute();
		this.sshClient_0.CreateCommand("mv -f /private/preboot/$(cat /private/preboot/active)/usr/local/standalone/firmware/Baseband /private/preboot/$(cat /private/preboot/active)/usr/local/standalone/firmware/Baseband2").Execute();
		try
		{
			this.sshClient_0.CreateCommand("shutdown -r now").Execute();
		}
		catch
		{
		}
		this.sshClient_0.Disconnect();
		this.scpClient_0.Disconnect();
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0095A474 File Offset: 0x00958674
	[DebuggerStepThrough]
	public T0 method_41<T0>()
	{
		ByteM8.Class17 @class = new ByteM8.Class17();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class17>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0095A4B8 File Offset: 0x009586B8
	private void method_42<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		ProcessStartInfo processStartInfo = ByteM8.smethod_5();
		processStartInfo.FileName = "https://t.me/iosnemes1s";
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0095A4E4 File Offset: 0x009586E4
	private void method_43<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		ProcessStartInfo processStartInfo = ByteM8.smethod_5();
		processStartInfo.FileName = "https://t.me/BroqueRamdisk";
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0095A510 File Offset: 0x00958710
	private void method_44<T0, T1, T2, T3, T4>(T2 gparam_0, T3 gparam_1)
	{
		T0 t = MessageBox.Show("Do you want to Exit!", "ByteM8 Activator", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		T1 t2 = t == 7;
		if (t2 != null)
		{
			gparam_1.Cancel = true;
		}
		else
		{
			ProcessStartInfo processStartInfo = ByteM8.smethod_5();
			processStartInfo.FileName = "https://www.youtube.com/@iosnemes1s";
			processStartInfo.UseShellExecute = true;
			Process.Start(processStartInfo);
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0095A560 File Offset: 0x00958760
	private async void method_45<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		try
		{
			bool flag = await this.method_8<Task<bool>>();
			bool flag2 = flag;
			if (!flag2)
			{
				ProcessStartInfo processStartInfo = ByteM8.Class8.smethod_0();
				processStartInfo.FileName = "https://mega.nz/folder/Yv4T2agb#BgeHotXL_etbzX234TEJag";
				processStartInfo.UseShellExecute = true;
				Process.Start(processStartInfo);
				MessageBox.Show("Softwre is outdated, Please update!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
			MessageBox.Show("Please connect to the internet!", "ByteM8 Activator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Process.GetCurrentProcess().Kill();
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0095A5A8 File Offset: 0x009587A8
	private void method_46<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		ProcessStartInfo processStartInfo = ByteM8.smethod_5();
		processStartInfo.FileName = "https://www.youtube.com/playlist?list=PLwI34XwAM2basalrkfbj-eQjGVglvuTbz";
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0095A5D4 File Offset: 0x009587D4
	private void method_47<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		ProcessStartInfo processStartInfo = ByteM8.smethod_5();
		processStartInfo.FileName = "https://iosnemes1s.pythonanywhere.com/bytem8";
		processStartInfo.UseShellExecute = true;
		Process.Start(processStartInfo);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0095A600 File Offset: 0x00958800
	protected virtual void System.Windows.Forms.Form.Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0095A630 File Offset: 0x00958830
	private void method_48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
	{
		this.icontainer_0 = ByteM8.smethod_7();
		T0 t = new ComponentResourceManager(typeof(ByteM8));
		this.label1 = ByteM8.smethod_8();
		this.label2 = ByteM8.smethod_8();
		this.timer_0 = new Timer(this.icontainer_0);
		this.panel1 = ByteM8.smethod_9();
		this.label9 = ByteM8.smethod_8();
		this.label7 = ByteM8.smethod_8();
		this.label6 = ByteM8.smethod_8();
		this.label5 = ByteM8.smethod_8();
		this.label4 = ByteM8.smethod_8();
		this.label3 = ByteM8.smethod_8();
		this.label8 = ByteM8.smethod_8();
		this.label11 = ByteM8.smethod_8();
		this.label10 = ByteM8.smethod_8();
		this.button1 = ByteM8.smethod_10();
		this.ModelText = ByteM8.smethod_8();
		this.versionText = ByteM8.smethod_8();
		this.SrlNum = ByteM8.smethod_8();
		this.actText = ByteM8.smethod_8();
		this.jbText = ByteM8.smethod_8();
		this.IMEIText = ByteM8.smethod_8();
		this.toolTip_0 = new ToolTip(this.icontainer_0);
		this.timer_1 = new Timer(this.icontainer_0);
		this.backgroundWorker_0 = ByteM8.smethod_11();
		this.pictureBox9 = ByteM8.smethod_12();
		this.pictureBox4 = ByteM8.smethod_12();
		this.pictureBox8 = ByteM8.smethod_12();
		this.pictureBox7 = ByteM8.smethod_12();
		this.pictureBox6 = ByteM8.smethod_12();
		this.pictureBox3 = ByteM8.smethod_12();
		this.pictureBox1 = ByteM8.smethod_12();
		this.pictureBox2 = ByteM8.smethod_12();
		this.pictureBox5 = ByteM8.smethod_12();
		this.panel1.SuspendLayout();
		((ISupportInitialize)this.pictureBox9).BeginInit();
		((ISupportInitialize)this.pictureBox4).BeginInit();
		((ISupportInitialize)this.pictureBox8).BeginInit();
		((ISupportInitialize)this.pictureBox7).BeginInit();
		((ISupportInitialize)this.pictureBox6).BeginInit();
		((ISupportInitialize)this.pictureBox3).BeginInit();
		((ISupportInitialize)this.pictureBox1).BeginInit();
		((ISupportInitialize)this.pictureBox2).BeginInit();
		((ISupportInitialize)this.pictureBox5).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new Font("SF Pro Text", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label1.Location = new Point(64, 382);
		this.label1.Name = "label1";
		this.label1.Size = new Size(323, 24);
		this.label1.TabIndex = 2;
		this.label1.Text = "Please connect a device via USB.";
		this.label2.AutoSize = true;
		this.label2.Cursor = Cursors.Hand;
		this.label2.Font = new Font("Segoe UI Variable Display", 7.8f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
		this.label2.ForeColor = Color.FromArgb(20, 146, 230);
		this.label2.Location = new Point(90, 432);
		this.label2.Name = "label2";
		this.label2.Size = new Size(244, 17);
		this.label2.TabIndex = 3;
		this.label2.Text = "Already connected a device? click here";
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.pictureBox9);
		this.panel1.Controls.Add(this.pictureBox4);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.pictureBox8);
		this.panel1.Controls.Add(this.pictureBox7);
		this.panel1.Controls.Add(this.pictureBox6);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.label11);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.ModelText);
		this.panel1.Controls.Add(this.versionText);
		this.panel1.Controls.Add(this.SrlNum);
		this.panel1.Controls.Add(this.actText);
		this.panel1.Controls.Add(this.jbText);
		this.panel1.Controls.Add(this.IMEIText);
		this.panel1.Controls.Add(this.pictureBox3);
		this.panel1.Cursor = Cursors.Default;
		this.panel1.Location = new Point(1, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(484, 475);
		this.panel1.TabIndex = 4;
		this.panel1.Visible = false;
		this.label9.AutoSize = true;
		this.label9.Font = new Font("SF Pro Semibold", 9f);
		this.label9.Location = new Point(103, 315);
		this.label9.Name = "label9";
		this.label9.Size = new Size(265, 18);
		this.label9.TabIndex = 23;
		this.label9.Text = "with ❤\ufe0f from the Broque Ramdisk Team.";
		this.label7.AutoSize = true;
		this.label7.Font = new Font("SF Pro Semibold", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label7.Location = new Point(219, 30);
		this.label7.Name = "label7";
		this.label7.Size = new Size(58, 18);
		this.label7.TabIndex = 6;
		this.label7.Text = "version:";
		this.label6.AutoSize = true;
		this.label6.Font = new Font("SF Pro Semibold", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label6.Location = new Point(201, 174);
		this.label6.Name = "label6";
		this.label6.Size = new Size(79, 18);
		this.label6.TabIndex = 5;
		this.label6.Text = "Jailbroken:";
		this.label5.AutoSize = true;
		this.label5.Font = new Font("SF Pro Semibold", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label5.Location = new Point(175, 66);
		this.label5.Name = "label5";
		this.label5.Size = new Size(104, 18);
		this.label5.TabIndex = 4;
		this.label5.Text = "Serial Number:";
		this.label4.AutoSize = true;
		this.label4.Font = new Font("SF Pro Semibold", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label4.Location = new Point(165, 137);
		this.label4.Name = "label4";
		this.label4.Size = new Size(115, 18);
		this.label4.TabIndex = 3;
		this.label4.Text = "Activation State:";
		this.label3.AutoSize = true;
		this.label3.Font = new Font("SF Pro Semibold", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label3.Location = new Point(241, 102);
		this.label3.Name = "label3";
		this.label3.Size = new Size(40, 18);
		this.label3.TabIndex = 2;
		this.label3.Text = "IMEI:";
		this.label8.AutoSize = true;
		this.label8.Font = new Font("SF Pro Semibold", 9f);
		this.label8.Location = new Point(145, 286);
		this.label8.Name = "label8";
		this.label8.Size = new Size(82, 18);
		this.label8.TabIndex = 14;
		this.label8.Text = "Created by";
		this.label11.AutoSize = true;
		this.label11.Cursor = Cursors.Hand;
		this.label11.Font = new Font("SF Pro Semibold", 9f);
		this.label11.ForeColor = Color.FromArgb(20, 146, 230);
		this.label11.Location = new Point(224, 286);
		this.label11.Name = "label11";
		this.label11.Size = new Size(97, 18);
		this.label11.TabIndex = 15;
		this.label11.Text = "@iosnemes1s";
		this.label11.Click += new EventHandler(this.method_42<T7, T8, T9>);
		this.label10.AutoSize = true;
		this.label10.BackColor = Color.Transparent;
		this.label10.ForeColor = SystemColors.GrayText;
		this.label10.ImeMode = ImeMode.NoControl;
		this.label10.Location = new Point(33, 248);
		this.label10.Name = "label10";
		this.label10.Size = new Size(364, 16);
		this.label10.TabIndex = 13;
		this.label10.Text = "___________________________________________________";
		this.label10.TextAlign = ContentAlignment.MiddleLeft;
		this.button1.Cursor = Cursors.Hand;
		this.button1.Font = new Font("SF Pro", 10f, FontStyle.Bold);
		this.button1.Location = new Point(36, 420);
		this.button1.Name = "button1";
		this.button1.Size = new Size(403, 44);
		this.button1.TabIndex = 0;
		this.button1.TabStop = false;
		this.button1.Text = "Start Bypass";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new EventHandler(this.method_20<T7, T8>);
		this.ModelText.Font = new Font("SF Pro", 9f, FontStyle.Bold);
		this.ModelText.Location = new Point(0, 230);
		this.ModelText.Name = "ModelText";
		this.ModelText.Size = new Size(484, 18);
		this.ModelText.TabIndex = 12;
		this.ModelText.Text = "iPhone 6s+";
		this.ModelText.TextAlign = ContentAlignment.MiddleCenter;
		this.versionText.AutoSize = true;
		this.versionText.Font = new Font("SF Pro", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.versionText.Location = new Point(302, 30);
		this.versionText.Name = "versionText";
		this.versionText.Size = new Size(66, 18);
		this.versionText.TabIndex = 11;
		this.versionText.Text = "iOS 15.7";
		this.SrlNum.AutoSize = true;
		this.SrlNum.Cursor = Cursors.Hand;
		this.SrlNum.Font = new Font("SF Pro", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.SrlNum.Location = new Point(302, 66);
		this.SrlNum.Name = "SrlNum";
		this.SrlNum.Size = new Size(137, 18);
		this.SrlNum.TabIndex = 10;
		this.SrlNum.Text = "VSDBC7FNJN9DU";
		this.SrlNum.Click += new EventHandler(this.method_17<T7, T8>);
		this.SrlNum.MouseLeave += new EventHandler(this.method_16<T7, T8>);
		this.SrlNum.MouseHover += new EventHandler(this.method_15<T7, T8>);
		this.actText.AutoSize = true;
		this.actText.Font = new Font("SF Pro", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.actText.Location = new Point(302, 137);
		this.actText.Name = "actText";
		this.actText.Size = new Size(93, 18);
		this.actText.TabIndex = 9;
		this.actText.Text = "Unactivated";
		this.jbText.AutoSize = true;
		this.jbText.Font = new Font("SF Pro", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.jbText.Location = new Point(302, 174);
		this.jbText.Name = "jbText";
		this.jbText.Size = new Size(33, 18);
		this.jbText.TabIndex = 8;
		this.jbText.Text = "Not";
		this.IMEIText.AutoSize = true;
		this.IMEIText.Cursor = Cursors.Default;
		this.IMEIText.Font = new Font("SF Pro", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.IMEIText.Location = new Point(302, 102);
		this.IMEIText.Name = "IMEIText";
		this.IMEIText.Size = new Size(32, 18);
		this.IMEIText.TabIndex = 7;
		this.IMEIText.Text = "N/A";
		this.timer_1.Interval = 3000;
		this.timer_1.Tick += new EventHandler(this.method_18<T7, T8>);
		this.pictureBox9.Image = (T10)((object)t.GetObject("pictureBox9.Image"));
		this.pictureBox9.Location = new Point(285, 430);
		this.pictureBox9.Name = "pictureBox9";
		this.pictureBox9.Size = new Size(25, 25);
		this.pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox9.TabIndex = 22;
		this.pictureBox9.TabStop = false;
		this.pictureBox9.Visible = false;
		this.pictureBox4.Cursor = Cursors.Hand;
		this.pictureBox4.Image = (T10)((object)t.GetObject("pictureBox4.Image"));
		this.pictureBox4.Location = new Point(148, 356);
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.Size = new Size(42, 39);
		this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox4.TabIndex = 21;
		this.pictureBox4.TabStop = false;
		this.pictureBox4.Click += new EventHandler(this.method_46<T7, T8, T9>);
		this.pictureBox8.Cursor = Cursors.Hand;
		this.pictureBox8.Image = Class40.Bitmap_5;
		this.pictureBox8.Location = new Point(36, 360);
		this.pictureBox8.Name = "pictureBox8";
		this.pictureBox8.Size = new Size(38, 35);
		this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox8.TabIndex = 20;
		this.pictureBox8.TabStop = false;
		this.pictureBox8.Click += new EventHandler(this.method_43<T7, T8, T9>);
		this.pictureBox7.Cursor = Cursors.Hand;
		this.pictureBox7.Image = Class40.Bitmap_2;
		this.pictureBox7.Location = new Point(285, 360);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new Size(33, 30);
		this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox7.TabIndex = 19;
		this.pictureBox7.TabStop = false;
		this.pictureBox6.Cursor = Cursors.Hand;
		this.pictureBox6.Image = Class40.Bitmap_3;
		this.pictureBox6.Location = new Point(402, 360);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new Size(37, 35);
		this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox6.TabIndex = 18;
		this.pictureBox6.TabStop = false;
		this.pictureBox6.Click += new EventHandler(this.method_47<T7, T8, T9>);
		this.pictureBox3.Location = new Point(-62, 27);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new Size(289, 188);
		this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox3.TabIndex = 0;
		this.pictureBox3.TabStop = false;
		this.pictureBox1.Image = Class40.Bitmap_6;
		this.pictureBox1.Location = new Point(181, 38);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new Size(97, 182);
		this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.pictureBox2.Image = Class40.Bitmap_1;
		this.pictureBox2.Location = new Point(114, 188);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new Size(237, 182);
		this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 1;
		this.pictureBox2.TabStop = false;
		this.pictureBox5.Image = Class40.Bitmap_0;
		this.pictureBox5.Location = new Point(125, 104);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new Size(216, 179);
		this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox5.TabIndex = 5;
		this.pictureBox5.TabStop = false;
		this.pictureBox5.Visible = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(485, 476);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.pictureBox5);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (T11)((object)t.GetObject("$this.Icon"));
		base.MaximizeBox = false;
		base.Name = "ByteM8";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "ByteM8 Activator v1.4";
		base.FormClosing += new FormClosingEventHandler(this.method_44<T12, T13, T7, T14, T9>);
		base.Load += new EventHandler(this.method_14<T13, T15, T7, T8, T16>);
		base.Shown += new EventHandler(this.method_45<T7, T8>);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((ISupportInitialize)this.pictureBox9).EndInit();
		((ISupportInitialize)this.pictureBox4).EndInit();
		((ISupportInitialize)this.pictureBox8).EndInit();
		((ISupportInitialize)this.pictureBox7).EndInit();
		((ISupportInitialize)this.pictureBox6).EndInit();
		((ISupportInitialize)this.pictureBox3).EndInit();
		((ISupportInitialize)this.pictureBox1).EndInit();
		((ISupportInitialize)this.pictureBox2).EndInit();
		((ISupportInitialize)this.pictureBox5).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0095BB4C File Offset: 0x00959D4C
	[CompilerGenerated]
	private void method_49()
	{
		this.sshClient_0.Connect();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0095BB64 File Offset: 0x00959D64
	[CompilerGenerated]
	private void method_50()
	{
		this.scpClient_0.Connect();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0095BB7C File Offset: 0x00959D7C
	[CompilerGenerated]
	private void method_51()
	{
		this.IMEIText.Text = this.string_12;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0095BB9C File Offset: 0x00959D9C
	[CompilerGenerated]
	private void method_52()
	{
		this.SrlNum.Text = this.string_7;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0095BBBC File Offset: 0x00959DBC
	[CompilerGenerated]
	private void method_53()
	{
		this.versionText.Text = "iOS " + this.string_15;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0095BBE4 File Offset: 0x00959DE4
	[CompilerGenerated]
	private void method_54()
	{
		this.actText.Text = this.string_10;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0095BC04 File Offset: 0x00959E04
	[CompilerGenerated]
	private void method_55<T0, T1, T2>()
	{
		this.method_40<T0, T1, T2>();
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0095BC18 File Offset: 0x00959E18
	[CompilerGenerated]
	private void method_56()
	{
		this.method_21();
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0095BC2C File Offset: 0x00959E2C
	[CompilerGenerated]
	[DebuggerStepThrough]
	private T0 method_57<T0>()
	{
		ByteM8.Class5 @class = new ByteM8.Class5();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@class.byteM8_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class5>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0095BC70 File Offset: 0x00959E70
	static WebClient smethod_2()
	{
		return Activator.CreateInstance(typeof(WebClient));
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0095BC8C File Offset: 0x00959E8C
	static Process smethod_3()
	{
		return Activator.CreateInstance(typeof(Process));
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0095BCA8 File Offset: 0x00959EA8
	static XmlDocument smethod_4()
	{
		return Activator.CreateInstance(typeof(XmlDocument));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0095BCC4 File Offset: 0x00959EC4
	static ProcessStartInfo smethod_5()
	{
		return Activator.CreateInstance(typeof(ProcessStartInfo));
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0095BCE0 File Offset: 0x00959EE0
	static NSDictionary smethod_6()
	{
		return Activator.CreateInstance(typeof(NSDictionary));
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0095BCFC File Offset: 0x00959EFC
	static Container smethod_7()
	{
		return Activator.CreateInstance(typeof(Container));
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0095BD18 File Offset: 0x00959F18
	static Label smethod_8()
	{
		return Activator.CreateInstance(typeof(Label));
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0095BD34 File Offset: 0x00959F34
	static Panel smethod_9()
	{
		return Activator.CreateInstance(typeof(Panel));
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0095BD50 File Offset: 0x00959F50
	static Button smethod_10()
	{
		return Activator.CreateInstance(typeof(Button));
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0095BD6C File Offset: 0x00959F6C
	static BackgroundWorker smethod_11()
	{
		return Activator.CreateInstance(typeof(BackgroundWorker));
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0095BD88 File Offset: 0x00959F88
	static PictureBox smethod_12()
	{
		return Activator.CreateInstance(typeof(PictureBox));
	}

	// Token: 0x0400002E RID: 46
	public SshClient sshClient_0;

	// Token: 0x0400002F RID: 47
	public ScpClient scpClient_0;

	// Token: 0x04000030 RID: 48
	private jailbreak jailbreak_0 = new jailbreak();

	// Token: 0x04000031 RID: 49
	private int int_0 = 0;

	// Token: 0x04000032 RID: 50
	private string string_0 = "       Connecting to device";

	// Token: 0x04000033 RID: 51
	private string string_1 = "       Connecting to device";

	// Token: 0x04000034 RID: 52
	private int int_1 = 3;

	// Token: 0x04000035 RID: 53
	public string string_2 = "";

	// Token: 0x04000036 RID: 54
	public string string_3 = "";

	// Token: 0x04000037 RID: 55
	public string string_4 = "";

	// Token: 0x04000038 RID: 56
	public string string_5 = "";

	// Token: 0x04000039 RID: 57
	public string string_6 = "";

	// Token: 0x0400003A RID: 58
	public bool bool_0 = false;

	// Token: 0x0400003B RID: 59
	public bool bool_1 = false;

	// Token: 0x0400003C RID: 60
	public string string_7 = "";

	// Token: 0x0400003D RID: 61
	public string string_8 = "";

	// Token: 0x0400003E RID: 62
	public string string_9 = "";

	// Token: 0x0400003F RID: 63
	public bool bool_2 = false;

	// Token: 0x04000040 RID: 64
	public string string_10 = "";

	// Token: 0x04000041 RID: 65
	public string string_11 = "";

	// Token: 0x04000042 RID: 66
	public string string_12 = "";

	// Token: 0x04000043 RID: 67
	public string string_13 = "";

	// Token: 0x04000044 RID: 68
	public string string_14 = "";

	// Token: 0x04000045 RID: 69
	public string string_15 = "";

	// Token: 0x04000046 RID: 70
	public string string_16 = "";

	// Token: 0x04000047 RID: 71
	public string string_17 = "";

	// Token: 0x04000048 RID: 72
	public string string_18 = "";

	// Token: 0x04000049 RID: 73
	public bool bool_3;

	// Token: 0x0400004A RID: 74
	public string string_19 = "1.4";

	// Token: 0x0400004B RID: 75
	public static IDeviceNotifier ideviceNotifier_0 = DeviceNotifier.OpenDeviceNotifier();

	// Token: 0x0400004C RID: 76
	private Dictionary<string, string> dictionary_0;

	// Token: 0x0400004D RID: 77
	private IContainer icontainer_0;

	// Token: 0x0400004E RID: 78
	private PictureBox pictureBox1;

	// Token: 0x0400004F RID: 79
	private PictureBox pictureBox2;

	// Token: 0x04000050 RID: 80
	private Label label1;

	// Token: 0x04000051 RID: 81
	private Label label2;

	// Token: 0x04000052 RID: 82
	private Timer timer_0;

	// Token: 0x04000053 RID: 83
	private Panel panel1;

	// Token: 0x04000054 RID: 84
	private PictureBox pictureBox3;

	// Token: 0x04000055 RID: 85
	private Label label3;

	// Token: 0x04000056 RID: 86
	private Label versionText;

	// Token: 0x04000057 RID: 87
	private Label SrlNum;

	// Token: 0x04000058 RID: 88
	private Label actText;

	// Token: 0x04000059 RID: 89
	private Label jbText;

	// Token: 0x0400005A RID: 90
	private Label IMEIText;

	// Token: 0x0400005B RID: 91
	private Label label7;

	// Token: 0x0400005C RID: 92
	private Label label6;

	// Token: 0x0400005D RID: 93
	private Label label5;

	// Token: 0x0400005E RID: 94
	private Label label4;

	// Token: 0x0400005F RID: 95
	private Button button1;

	// Token: 0x04000060 RID: 96
	private Label label8;

	// Token: 0x04000061 RID: 97
	private Label label11;

	// Token: 0x04000062 RID: 98
	private Label label10;

	// Token: 0x04000063 RID: 99
	private PictureBox pictureBox5;

	// Token: 0x04000064 RID: 100
	private PictureBox pictureBox6;

	// Token: 0x04000065 RID: 101
	private PictureBox pictureBox7;

	// Token: 0x04000066 RID: 102
	private ToolTip toolTip_0;

	// Token: 0x04000067 RID: 103
	private PictureBox pictureBox8;

	// Token: 0x04000068 RID: 104
	private PictureBox pictureBox4;

	// Token: 0x04000069 RID: 105
	private Timer timer_1;

	// Token: 0x0400006A RID: 106
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x0400006B RID: 107
	private PictureBox pictureBox9;

	// Token: 0x0400006C RID: 108
	private Label label9;

	// Token: 0x0400006D RID: 109
	private Label ModelText;

	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	private sealed class Class6
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0095C990 File Offset: 0x0095AB90
		[DebuggerStepThrough]
		internal T0 method_0<T0>()
		{
			ByteM8.Class6.Class7 @class = new ByteM8.Class6.Class7();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.class6_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<ByteM8.Class6.Class7>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000074 RID: 116
		public ByteM8 byteM8_0;

		// Token: 0x04000075 RID: 117
		public bool bool_0;

		// Token: 0x02000010 RID: 16
		private sealed class Class7 : IAsyncStateMachine
		{
			// Token: 0x0600008D RID: 141 RVA: 0x0095C9D4 File Offset: 0x0095ABD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_9E;
					}
					if (num != 1)
					{
						goto IL_6F;
					}
					TaskAwaiter awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_68:
					awaiter2.GetResult();
					IL_6F:
					if (this.class6_0.bool_0)
					{
						goto IL_133;
					}
					awaiter = this.class6_0.byteM8_0.method_13<Task<bool>>().GetAwaiter();
					ByteM8.Class6.Class7 @class;
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						@class = this;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ByteM8.Class6.Class7>(ref awaiter, ref @class);
						return;
					}
					IL_9E:
					this.bool_0 = awaiter.GetResult();
					this.class6_0.bool_0 = this.bool_0;
					if (this.class6_0.bool_0)
					{
						goto IL_6F;
					}
					awaiter2 = Task.Delay(500).GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_68;
					}
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					@class = this;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, ByteM8.Class6.Class7>(ref awaiter2, ref @class);
					return;
				}
				catch (Exception ex)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(ex);
					return;
				}
				IL_133:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600008E RID: 142 RVA: 0x0095C980 File Offset: 0x0095AB80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000076 RID: 118
			public int int_0;

			// Token: 0x04000077 RID: 119
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000078 RID: 120
			public ByteM8.Class6 class6_0;

			// Token: 0x04000079 RID: 121
			private bool bool_0;

			// Token: 0x0400007A RID: 122
			private TaskAwaiter<bool> taskAwaiter_0;

			// Token: 0x0400007B RID: 123
			private TaskAwaiter taskAwaiter_1;
		}
	}
}

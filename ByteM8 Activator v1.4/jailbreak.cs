using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet.Main;

// Token: 0x0200001E RID: 30
public partial class jailbreak : Form
{
	// Token: 0x060000D5 RID: 213 RVA: 0x0095FA80 File Offset: 0x0095DC80
	public jailbreak()
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
		this.method_22<ComponentResourceManager, Label, Button, Panel, ProgressBar, PictureBox, object, EventArgs, Process, Icon, DeviceNotifyEventArgs>();
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00960310 File Offset: 0x0095E510
	[DebuggerStepThrough]
	public T0 method_0<T0>()
	{
		jailbreak.Class36 @class = new jailbreak.Class36();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.jailbreak_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class36>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00960354 File Offset: 0x0095E554
	[DebuggerStepThrough]
	public T0 method_1<T0>()
	{
		jailbreak.Class31 @class = new jailbreak.Class31();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.jailbreak_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class31>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00960398 File Offset: 0x0095E598
	[DebuggerStepThrough]
	public T0 method_2<T0>()
	{
		jailbreak.Class33 @class = new jailbreak.Class33();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.jailbreak_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class33>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x009603DC File Offset: 0x0095E5DC
	[DebuggerStepThrough]
	public T0 method_3<T0>()
	{
		jailbreak.Class32 @class = new jailbreak.Class32();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@class.jailbreak_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class32>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00960420 File Offset: 0x0095E620
	public void method_4<T0>()
	{
		this.string_18 = this.dictionary_0[this.string_17];
		this.devicePicture.Visible = true;
		if (!this.string_18.Contains("iPhone 6") && !this.string_18.Contains("iPhone 5s") && !this.string_18.Contains("iPhone SE") && !this.string_18.Contains("iPad"))
		{
			T0 t = this.string_18.Contains("iPhone 7") || this.string_18.Contains("iPhone 8");
			if (t != null)
			{
				this.devicePicture.Image = Class40.Bitmap_8;
				this.label22.Visible = true;
				this.volumeDown.Visible = true;
			}
			else
			{
				T0 t2 = this.string_18.Contains("iPhone X");
				if (t2 != null)
				{
					this.devicePicture.Image = Class40.Bitmap_9;
					this.sideButton.Visible = true;
					this.volumeDown.Visible = true;
				}
			}
		}
		else
		{
			this.devicePicture.Image = Class40.Bitmap_7;
			this.label22.Visible = true;
			this.homeButton.Visible = true;
			this.pressDFU.Text = "2. Press and hold the Side \r\nand Home buttons \r\ntogether (4)\r\n";
			this.label20.Text = "3. Release the Side button \r\nBUT KEEP HOLDING the \r\nHome button (10)\r\n";
		}
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0096057C File Offset: 0x0095E77C
	public T1 method_5<T0, T1, T2>()
	{
		T0 t = jailbreak.smethod_1();
		Process process = t;
		ProcessStartInfo processStartInfo = jailbreak.smethod_2();
		processStartInfo.FileName = Environment.CurrentDirectory + "/ref/ideviceenterrecovery.exe";
		processStartInfo.Arguments = this.string_11;
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.CreateNoWindow = true;
		process.StartInfo = processStartInfo;
		t.Start();
		T1 t2;
		if (t.StandardOutput.ReadToEnd().Contains("successfully switching to recovery mode."))
		{
			t2 = 1;
		}
		else
		{
			t2 = 0;
		}
		return t2;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x009605FC File Offset: 0x0095E7FC
	private async void method_6<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		this.method_20<Process, int, bool, string>("openra1n");
		this.method_20<Process, int, bool, string>("Checkra1n1");
		this.method_20<Process, int, bool, string>("pongoterm");
		this.method_20<Process, int, bool, string>("Checkra1n2");
		await this.method_2<Task<bool>>();
		if (!(await Task.Run<bool>(new Func<bool>(this.method_23<bool, Process, ProcessStartInfo>))))
		{
			MessageBox.Show("Ooops, Could not put device in recovery mode!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			base.Close();
		}
		else
		{
			bool flag = await this.method_3<Task<bool>>();
			if (flag)
			{
				this.button7.Enabled = true;
				this.button6.Enabled = true;
				this.method_4<bool>();
			}
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00960644 File Offset: 0x0095E844
	public static T2 smethod_0<T0, T1, T2, T3>(T2 gparam_0, T2 gparam_1, T1 gparam_2 = true, T1 gparam_3 = false)
	{
		Process process = jailbreak.smethod_1();
		ProcessStartInfo processStartInfo = jailbreak.smethod_2();
		processStartInfo.FileName = Environment.CurrentDirectory + "/ref/irecover.exe";
		processStartInfo.Arguments = gparam_0;
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.CreateNoWindow = true;
		process.StartInfo = processStartInfo;
		T0 t = process;
		t.Start();
		T1 t2 = gparam_2 == 0;
		T2 t3;
		if (t2 != null)
		{
			t3 = "";
		}
		else
		{
			if (gparam_3 != null)
			{
				T1 t4 = t.WaitForExit(500) && t.StandardOutput.ReadToEnd().Contains(gparam_1);
				if (t4 != null)
				{
					return gparam_1;
				}
			}
			else
			{
				T2 t5;
				while ((t5 = t.StandardOutput.ReadLine()) != null)
				{
					if (t5.Contains(gparam_1))
					{
						return t5;
					}
				}
			}
			t3 = "";
		}
		return t3;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0096070C File Offset: 0x0095E90C
	public void method_7<T0, T1>(T1 gparam_0)
	{
		T0 t = gparam_0.StartsWith("iBoot-4513");
		if (t != null)
		{
			this.string_15 = "12.x";
		}
		else if (!gparam_0.StartsWith("iBoot-5540"))
		{
			T0 t2 = gparam_0.StartsWith("iBoot-6723") || gparam_0.StartsWith("iBoot-6603") || gparam_0.StartsWith("iBoot-6631") || gparam_0.StartsWith("iBoot-6671");
			if (t2 != null)
			{
				this.string_15 = "14.x";
			}
			else if (!gparam_0.StartsWith("iBoot-7429") && !gparam_0.StartsWith("iBoot-7459"))
			{
				T0 t3 = gparam_0.StartsWith("iBoot-8419");
				if (t3 != null)
				{
					this.string_15 = "16.x";
				}
				else if (!gparam_0.StartsWith("iBoot-8422"))
				{
					this.string_15 = "16.4x";
				}
				else
				{
					this.string_15 = "16.4x";
				}
			}
			else
			{
				this.string_15 = "15.x";
			}
		}
		else
		{
			this.string_15 = "13.x";
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00960814 File Offset: 0x0095EA14
	public async void method_8<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		string text = gparam_1.Device.IdProduct.ToString();
		string text2 = gparam_1.Device.IdVendor.ToString();
		if (!(gparam_1.EventType.ToString() == "DeviceArrival"))
		{
			if (gparam_1.EventType.ToString() == "DeviceRemoveComplete" && !(text2 == "1452"))
			{
			}
		}
		else if (text2 == "1452")
		{
			if (!(text == "4737"))
			{
				if (text == "4647")
				{
					if (this.string_24 == "DFU")
					{
						this.string_24 = "Boot";
					}
					else
					{
						this.string_23 = "DFU";
						TaskAwaiter<bool> taskAwaiter = this.method_3<Task<bool>>().GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<bool> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<bool>);
						}
						bool result = taskAwaiter.GetResult();
						if (result)
						{
							this.string_18 = this.dictionary_0[this.string_17];
						}
					}
				}
			}
			else
			{
				if (this.string_24 == "DFU")
				{
					this.string_24 = "recovery";
				}
				else
				{
					this.string_24 = "";
				}
				this.string_23 = "recovery";
				TaskAwaiter<bool> taskAwaiter3 = this.method_3<Task<bool>>().GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter<bool> taskAwaiter2;
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<bool>);
				}
				bool result2 = taskAwaiter3.GetResult();
				if (result2)
				{
					this.string_22 = jailbreak.smethod_0<Process, bool, string, ProcessStartInfo>("-q", "iBoot", true, false).Replace("iBoot: ", "");
					this.string_18 = this.dictionary_0[this.string_17];
					this.method_7<bool, string>(this.string_22);
				}
			}
		}
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0096085C File Offset: 0x0095EA5C
	private void method_9<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		this.button7.Enabled = false;
		this.button6.Enabled = false;
		jailbreak.ideviceNotifier_0.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(this.method_8<T0, T2>);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00960898 File Offset: 0x0095EA98
	private void method_10<T0, T1, T2, T3, T4>()
	{
		base.Invoke(new Action(this.method_24));
		T0 t = 5;
		T1 now = DateTime.Now;
		T2 t2 = new System.Timers.Timer(2000.0);
		t2.Elapsed += this.method_25<object, ElapsedEventArgs, Process, T2>;
		t2.AutoReset = false;
		t2.Start();
		for (;;)
		{
			jailbreak.Class28 @class = new jailbreak.Class28();
			@class.jailbreak_0 = this;
			T3 t3 = DateTime.Now - now;
			T4 t4 = t3.TotalSeconds >= 5.0;
			if (t4 != null)
			{
				break;
			}
			t--;
			T4 t5 = this.string_18.Contains("iPhone 6") || this.string_18.Contains("iPhone 5s") || this.string_18.Contains("iPhone SE") || this.string_18.Contains("iPad");
			if (t5 != null)
			{
				@class.string_0 = string.Format("2. Press and hold the Side \r\nand Home buttons \r\ntogether ({0})\r\n", t);
			}
			else
			{
				@class.string_0 = string.Format("2. Press and hold the Side \r\nand Volume down buttons \r\ntogether ({0})\r\n", t);
			}
			base.Invoke(new Action(@class.method_0));
			Thread.Sleep(1000);
		}
		this.method_12<T0, T1, T3, T4>();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x009609D0 File Offset: 0x0095EBD0
	public void method_11<T0>()
	{
		T0 t = jailbreak.smethod_1();
		t.StartInfo.FileName = Environment.CurrentDirectory + "/ref/irecovery.exe";
		t.StartInfo.Arguments = "-n";
		t.StartInfo.UseShellExecute = false;
		t.StartInfo.RedirectStandardOutput = true;
		t.StartInfo.CreateNoWindow = true;
		t.StartInfo.RedirectStandardError = true;
		t.Start();
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00960A44 File Offset: 0x0095EC44
	private void method_12<T0, T1, T2, T3>()
	{
		base.Invoke(new Action(this.method_26));
		T0 t = 11;
		T1 now = DateTime.Now;
		jailbreak.Class29 @class;
		for (;;)
		{
			@class = new jailbreak.Class29();
			@class.jailbreak_0 = this;
			T2 t2 = DateTime.Now - now;
			T3 t3 = t2.TotalSeconds >= 11.0;
			if (t3 != null)
			{
				break;
			}
			if (this.string_24 == "Boot")
			{
				goto IL_127;
			}
			t--;
			if (!this.string_18.Contains("iPhone 6") && !this.string_18.Contains("iPhone 5s") && !this.string_18.Contains("iPhone SE") && !this.string_18.Contains("iPad"))
			{
				@class.string_0 = string.Format("3. Release the Side button \r\nBUT KEEP HOLDING the \r\nVolume down button ({0})\r\n", t);
			}
			else
			{
				@class.string_0 = string.Format("3. Release the Side button \r\nBUT KEEP HOLDING the \r\nHome button ({0})\r\n", t);
			}
			base.Invoke(new Action(@class.method_0));
			Thread.Sleep(1000);
		}
		base.Invoke(new Action(this.method_27));
		return;
		IL_127:
		jailbreak.Class30 class2 = new jailbreak.Class30();
		class2.class29_0 = @class;
		base.Invoke(new Action(this.method_28));
		t = 0;
		if (!this.string_18.Contains("iPhone 6") && !this.string_18.Contains("iPhone 5s") && !this.string_18.Contains("iPhone SE") && !this.string_18.Contains("iPad"))
		{
			class2.string_0 = string.Format("3. Release the Side button \r\nBUT KEEP HOLDING the \r\nVolume down button ({0})\r\n", t);
		}
		else
		{
			class2.string_0 = string.Format("3. Release the Side button \r\nBUT KEEP HOLDING the \r\nHome button ({0})\r\n", t);
		}
		base.Invoke(new Action(class2.method_0));
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00960C30 File Offset: 0x0095EE30
	public void method_13<T0>()
	{
		T0 t = Directory.Exists(Path.Combine(Path.GetTempPath(), "Checkra1n"));
		if (t != null)
		{
			Directory.Delete(Path.Combine(Path.GetTempPath(), "Checkra1n"), true);
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00960C6C File Offset: 0x0095EE6C
	public void method_14<T0, T1, T2, T3, T4, T5>()
	{
		T0[] byte_ = Class40.Byte_0;
		T1 t = Path.Combine(Path.GetTempPath(), "Checkra1n");
		using (T2 t2 = new MemoryStream(byte_))
		{
			using (T3 t3 = new ZipArchive(t2))
			{
				foreach (T5 t4 in t3.Entries)
				{
					T1 t5 = Path.Combine(t, t4.FullName);
					Directory.CreateDirectory(Path.GetDirectoryName(t5));
					t4.ExtractToFile(t5, true);
				}
			}
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00960D34 File Offset: 0x0095EF34
	public T0 method_15<T0, T1, T2, T3>()
	{
		T0 t = "Checkra1n1.exe";
		T2 t2 = this.string_15 == "12.x" || this.string_15 == "13.x" || this.string_15 == "14.x";
		if (t2 != null)
		{
			t = "openra1n.exe";
		}
		else
		{
			T2 t3 = this.string_15 == "15.x" || this.string_15 == "16.x";
			if (t3 != null)
			{
				t = "Checkra1n2.exe";
			}
			else
			{
				T2 t4 = this.string_15 == "16.4x";
				if (t4 != null)
				{
					t = "Checkra1n1.exe";
				}
			}
		}
		Process process = jailbreak.smethod_1();
		ProcessStartInfo processStartInfo = jailbreak.smethod_2();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = Path.Combine(Path.GetTempPath(), "Checkra1n\\" + t);
		processStartInfo.Verb = "runas";
		processStartInfo.Arguments = "";
		processStartInfo.WorkingDirectory = ".\\ref\\Drivers\\Other";
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		process.StartInfo = processStartInfo;
		T1 t5 = process;
		t5.Start();
		return t5.StandardOutput.ReadToEnd() + t5.StandardError.ReadToEnd();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00960E68 File Offset: 0x0095F068
	public T1 method_16<T0, T1, T2>()
	{
		Process process = jailbreak.smethod_1();
		ProcessStartInfo processStartInfo = jailbreak.smethod_2();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Verb = "runas";
		processStartInfo.Arguments = "/C pongoterm <pongo.txt";
		processStartInfo.WorkingDirectory = Path.Combine(Path.GetTempPath(), "Checkra1n");
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		process.StartInfo = processStartInfo;
		T0 t = process;
		t.Start();
		return t.StandardOutput.ReadToEnd() + t.StandardError.ReadToEnd();
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00960EFC File Offset: 0x0095F0FC
	public async void method_17()
	{
		await Task.Run(new Action(this.method_29<string, bool, byte, MemoryStream, ZipArchive, IEnumerator<ZipArchiveEntry>, ZipArchiveEntry, ProcessStartInfo, Exception, int, Process, UsbRegDeviceList>));
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00960F38 File Offset: 0x0095F138
	private async void method_18<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		this.string_24 = "DFU";
		await Task.Run(new Func<Task>(this.method_35<Task>));
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00960F80 File Offset: 0x0095F180
	private void method_19<T0, T1>(T0 gparam_0, T1 gparam_1)
	{
		base.Close();
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00960F94 File Offset: 0x0095F194
	public void method_20<T0, T1, T2, T3>(T3 gparam_0)
	{
		try
		{
			T0[] processes = Process.GetProcesses();
			for (T1 t = 0; t < processes.Length; t++)
			{
				T0 t2 = processes[t];
				T2 t3 = t2.ProcessName.Equals(gparam_0, StringComparison.OrdinalIgnoreCase);
				if (t3 != null)
				{
					t2.Kill();
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00960FE8 File Offset: 0x0095F1E8
	private void method_21<T0, T1, T2>(T0 gparam_0, T1 gparam_1)
	{
		this.method_11<T2>();
		base.Close();
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00961004 File Offset: 0x0095F204
	protected virtual void System.Windows.Forms.Form.Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00961034 File Offset: 0x0095F234
	private void method_22<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
	{
		T0 t = new ComponentResourceManager(typeof(jailbreak));
		this.label22 = jailbreak.smethod_3();
		this.sideButton = jailbreak.smethod_3();
		this.volumeDown = jailbreak.smethod_3();
		this.homeButton = jailbreak.smethod_3();
		this.button6 = jailbreak.smethod_4();
		this.button7 = jailbreak.smethod_4();
		this.label20 = jailbreak.smethod_3();
		this.pressDFU = jailbreak.smethod_3();
		this.startDFU = jailbreak.smethod_3();
		this.label24 = jailbreak.smethod_3();
		this.bootPanel = jailbreak.smethod_5();
		this.progressBar1 = jailbreak.smethod_6();
		this.button8 = jailbreak.smethod_4();
		this.label18 = jailbreak.smethod_3();
		this.label17 = jailbreak.smethod_3();
		this.devicePicture = jailbreak.smethod_7();
		this.bootPanel.SuspendLayout();
		((ISupportInitialize)this.devicePicture).BeginInit();
		base.SuspendLayout();
		this.label22.AutoSize = true;
		this.label22.BackColor = Color.Transparent;
		this.label22.Font = new Font("SF Pro", 8f);
		this.label22.ImeMode = ImeMode.NoControl;
		this.label22.Location = new Point(275, 148);
		this.label22.Margin = new Padding(4, 0, 4, 0);
		this.label22.Name = "label22";
		this.label22.Size = new Size(93, 16);
		this.label22.TabIndex = 26;
		this.label22.Text = "-- Side button";
		this.label22.Visible = false;
		this.sideButton.AutoSize = true;
		this.sideButton.BackColor = Color.Transparent;
		this.sideButton.Font = new Font("Microsoft Sans Serif", 8f);
		this.sideButton.ImeMode = ImeMode.NoControl;
		this.sideButton.Location = new Point(275, 158);
		this.sideButton.Margin = new Padding(4, 0, 4, 0);
		this.sideButton.Name = "sideButton";
		this.sideButton.Size = new Size(94, 17);
		this.sideButton.TabIndex = 24;
		this.sideButton.Text = "-- Side button";
		this.sideButton.Visible = false;
		this.volumeDown.AutoSize = true;
		this.volumeDown.Font = new Font("SF Pro", 8f);
		this.volumeDown.ImeMode = ImeMode.NoControl;
		this.volumeDown.Location = new Point(12, 170);
		this.volumeDown.Margin = new Padding(4, 0, 4, 0);
		this.volumeDown.Name = "volumeDown";
		this.volumeDown.Size = new Size(104, 16);
		this.volumeDown.TabIndex = 23;
		this.volumeDown.Text = "Volume down --";
		this.volumeDown.Visible = false;
		this.homeButton.AutoSize = true;
		this.homeButton.BackColor = Color.Transparent;
		this.homeButton.Font = new Font("SF Pro", 8f);
		this.homeButton.ForeColor = Color.Black;
		this.homeButton.ImeMode = ImeMode.NoControl;
		this.homeButton.Location = new Point(215, 336);
		this.homeButton.Margin = new Padding(4, 0, 4, 0);
		this.homeButton.Name = "homeButton";
		this.homeButton.Size = new Size(101, 16);
		this.homeButton.TabIndex = 25;
		this.homeButton.Text = "-- Home button";
		this.homeButton.Visible = false;
		this.button6.Font = new Font("SF Pro", 8f);
		this.button6.Location = new Point(333, 355);
		this.button6.Name = "button6";
		this.button6.Size = new Size(111, 31);
		this.button6.TabIndex = 27;
		this.button6.TabStop = false;
		this.button6.Text = "Cancel";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new EventHandler(this.method_21<T6, T7, T8>);
		this.button7.Font = new Font("SF Pro", 8f);
		this.button7.Location = new Point(463, 355);
		this.button7.Name = "button7";
		this.button7.Size = new Size(111, 31);
		this.button7.TabIndex = 28;
		this.button7.TabStop = false;
		this.button7.Text = "Start";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new EventHandler(this.method_18<T6, T7>);
		this.label20.AutoSize = true;
		this.label20.Enabled = false;
		this.label20.Font = new Font("SF Pro", 8f);
		this.label20.ImeMode = ImeMode.NoControl;
		this.label20.Location = new Point(373, 190);
		this.label20.Margin = new Padding(4, 0, 4, 0);
		this.label20.Name = "label20";
		this.label20.Size = new Size(179, 48);
		this.label20.TabIndex = 21;
		this.label20.Text = "3. Release the Side button \r\nBUT KEEP HOLDING the \r\nVolume down button (10)";
		this.pressDFU.AutoSize = true;
		this.pressDFU.Enabled = false;
		this.pressDFU.Font = new Font("SF Pro", 8f);
		this.pressDFU.ImeMode = ImeMode.NoControl;
		this.pressDFU.Location = new Point(373, 129);
		this.pressDFU.Margin = new Padding(4, 0, 4, 0);
		this.pressDFU.Name = "pressDFU";
		this.pressDFU.Size = new Size(178, 48);
		this.pressDFU.TabIndex = 20;
		this.pressDFU.Text = "2. Press and hold the Side \r\nand Volume down buttons \r\ntogether (4)";
		this.startDFU.AutoSize = true;
		this.startDFU.Font = new Font("SF Pro", 8f);
		this.startDFU.ImeMode = ImeMode.NoControl;
		this.startDFU.Location = new Point(373, 97);
		this.startDFU.Margin = new Padding(4, 0, 4, 0);
		this.startDFU.Name = "startDFU";
		this.startDFU.Size = new Size(87, 16);
		this.startDFU.TabIndex = 19;
		this.startDFU.Text = "1. Click Start";
		this.label24.AutoSize = true;
		this.label24.Font = new Font("SF Pro", 8f);
		this.label24.ImeMode = ImeMode.NoControl;
		this.label24.Location = new Point(14, 11);
		this.label24.Margin = new Padding(4, 0, 4, 0);
		this.label24.Name = "label24";
		this.label24.Size = new Size(500, 32);
		this.label24.TabIndex = 18;
		this.label24.Text = "Time to put the device into DFU mode. Locate the buttons as marked below on\r\nyour device and check the instructions on the right *before* clicking Start.";
		this.bootPanel.Controls.Add(this.progressBar1);
		this.bootPanel.Controls.Add(this.button8);
		this.bootPanel.Controls.Add(this.label18);
		this.bootPanel.Controls.Add(this.label17);
		this.bootPanel.Location = new Point(0, 0);
		this.bootPanel.Name = "bootPanel";
		this.bootPanel.Size = new Size(588, 396);
		this.bootPanel.TabIndex = 29;
		this.bootPanel.Visible = false;
		this.progressBar1.Location = new Point(36, 131);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new Size(514, 16);
		this.progressBar1.TabIndex = 19;
		this.button8.Enabled = false;
		this.button8.Font = new Font("SF Pro", 8f);
		this.button8.Location = new Point(464, 353);
		this.button8.Name = "button8";
		this.button8.Size = new Size(111, 31);
		this.button8.TabIndex = 18;
		this.button8.TabStop = false;
		this.button8.Text = "Done";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new EventHandler(this.method_19<T6, T7>);
		this.label18.AutoSize = true;
		this.label18.Font = new Font("SF Pro", 8.7f);
		this.label18.ImeMode = ImeMode.NoControl;
		this.label18.Location = new Point(13, 79);
		this.label18.Margin = new Padding(4, 0, 4, 0);
		this.label18.Name = "label18";
		this.label18.Size = new Size(69, 17);
		this.label18.TabIndex = 2;
		this.label18.Text = "Booting...";
		this.label17.AutoSize = true;
		this.label17.Font = new Font("SF Pro", 8.2f);
		this.label17.ImeMode = ImeMode.NoControl;
		this.label17.Location = new Point(12, 13);
		this.label17.Margin = new Padding(4, 0, 4, 0);
		this.label17.Name = "label17";
		this.label17.Size = new Size(489, 32);
		this.label17.TabIndex = 1;
		this.label17.Text = "Installing jailbreak, this will take a moment. Do not disconnect the device until\r\nfinished.";
		this.devicePicture.BackColor = SystemColors.Control;
		this.devicePicture.ImeMode = ImeMode.NoControl;
		this.devicePicture.Location = new Point(121, 91);
		this.devicePicture.Margin = new Padding(4);
		this.devicePicture.Name = "devicePicture";
		this.devicePicture.Size = new Size(153, 271);
		this.devicePicture.SizeMode = PictureBoxSizeMode.StretchImage;
		this.devicePicture.TabIndex = 22;
		this.devicePicture.TabStop = false;
		this.devicePicture.Visible = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(587, 396);
		base.Controls.Add(this.bootPanel);
		base.Controls.Add(this.label22);
		base.Controls.Add(this.sideButton);
		base.Controls.Add(this.volumeDown);
		base.Controls.Add(this.homeButton);
		base.Controls.Add(this.button6);
		base.Controls.Add(this.button7);
		base.Controls.Add(this.devicePicture);
		base.Controls.Add(this.label20);
		base.Controls.Add(this.pressDFU);
		base.Controls.Add(this.startDFU);
		base.Controls.Add(this.label24);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (T9)((object)t.GetObject("$this.Icon"));
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "jailbreak";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "ByteM8 Jailbreak";
		base.Load += new EventHandler(this.method_9<T6, T7, T10>);
		base.Shown += new EventHandler(this.method_6<T6, T7>);
		this.bootPanel.ResumeLayout(false);
		this.bootPanel.PerformLayout();
		((ISupportInitialize)this.devicePicture).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00961D20 File Offset: 0x0095FF20
	[CompilerGenerated]
	private T0 method_23<T0, T1, T2>()
	{
		return this.method_5<T1, T0, T2>();
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00961D34 File Offset: 0x0095FF34
	[CompilerGenerated]
	private void method_24()
	{
		this.startDFU.Enabled = false;
		this.pressDFU.Enabled = true;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00961D5C File Offset: 0x0095FF5C
	[CompilerGenerated]
	private void method_25<T0, T1, T2, T3>(T0 gparam_0, T1 gparam_1)
	{
		this.method_11<T2>();
		((T3)((object)gparam_0)).Stop();
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00961D7C File Offset: 0x0095FF7C
	[CompilerGenerated]
	private void method_26()
	{
		this.sideButton.Enabled = false;
		this.label22.Enabled = false;
		this.pressDFU.Enabled = false;
		this.label20.Enabled = true;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00961DBC File Offset: 0x0095FFBC
	[CompilerGenerated]
	private void method_27()
	{
		this.label20.Enabled = false;
		this.homeButton.Enabled = false;
		this.volumeDown.Enabled = false;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00961DBC File Offset: 0x0095FFBC
	[CompilerGenerated]
	private void method_28()
	{
		this.label20.Enabled = false;
		this.homeButton.Enabled = false;
		this.volumeDown.Enabled = false;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00961DF0 File Offset: 0x0095FFF0
	[CompilerGenerated]
	private void method_29<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
	{
		base.Invoke(new Action(this.method_30));
		try
		{
			this.method_13<T1>();
		}
		catch
		{
		}
		this.method_14<T2, T0, T3, T4, T5, T6>();
		Class20 @class = new Class20();
		@class.method_0<T7, T8>();
		T0 t = " /delete-driver " + @class.method_1<T0, T1, T9, T8>("apple") + " /uninstall /force";
		T0 t2 = " /delete-driver " + @class.method_1<T0, T1, T9, T8>("libusbK") + " /uninstall /force";
		@class.method_14<T10, T7, T0>(t);
		@class.method_14<T10, T7, T0>(t2);
		@class.method_2<T0, T8>();
		@class.method_13<T0, T7>();
		@class.method_5<T10>();
		@class.method_7<T0, T1, T8>("");
		@class.method_8<T0, T1, T8>("");
		@class.method_4<T10, T0, T7>();
		base.Invoke(new Action(this.method_31));
		while (@class.method_22<T11, T9, T1>(1452, 4647) == 0)
		{
		}
		this.method_15<T0, T10, T1, T7>();
		while (@class.method_22<T11, T9, T1>(1452, 16705) == 0)
		{
		}
		base.Invoke(new Action(this.method_32));
		this.method_16<T10, T0, T7>();
		base.Invoke(new Action(this.method_33));
		Thread.Sleep(1500);
		base.Invoke(new Action(this.method_34));
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00961F50 File Offset: 0x00960150
	[CompilerGenerated]
	private void method_30()
	{
		this.label18.Text = "Checking if device is ready";
		this.progressBar1.Value = 30;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00961F7C File Offset: 0x0096017C
	[CompilerGenerated]
	private void method_31()
	{
		this.label18.Text = "Right before trigger (This is the real bug setup)";
		this.progressBar1.Value += 30;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00961FB0 File Offset: 0x009601B0
	[CompilerGenerated]
	private void method_32()
	{
		this.label18.Text = "Booting...";
		this.progressBar1.Value += 20;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00961FE4 File Offset: 0x009601E4
	[CompilerGenerated]
	private void method_33()
	{
		this.label18.Text = "Uploading Bootstrap...";
		this.progressBar1.Value += 10;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00962018 File Offset: 0x00960218
	[CompilerGenerated]
	private void method_34()
	{
		this.label18.Text = "All done";
		this.progressBar1.Value += 10;
		this.button8.Enabled = true;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00962058 File Offset: 0x00960258
	[CompilerGenerated]
	[DebuggerStepThrough]
	private T0 method_35<T0>()
	{
		jailbreak.Class21 @class = new jailbreak.Class21();
		@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@class.jailbreak_0 = this;
		@class.int_0 = -1;
		@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class21>(ref @class);
		return @class.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0096209C File Offset: 0x0096029C
	[CompilerGenerated]
	private void method_36()
	{
		this.button6.Enabled = false;
		this.button7.Enabled = false;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x009620C4 File Offset: 0x009602C4
	[CompilerGenerated]
	private async void method_37()
	{
		this.label22.Visible = false;
		this.homeButton.Visible = false;
		this.volumeDown.Visible = false;
		this.sideButton.Visible = false;
		this.label24.Text = "Device entered DFU mode successfully.";
		await Task.Delay(1500);
		this.bootPanel.Visible = true;
		this.method_17();
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00962100 File Offset: 0x00960300
	[CompilerGenerated]
	private void method_38()
	{
		this.label24.Text = "Whoops, the device didn't enter DFU mode. Click Retry to try again.";
		this.button6.Enabled = true;
		this.button7.Enabled = true;
		this.button7.Text = "Retry";
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00962100 File Offset: 0x00960300
	[CompilerGenerated]
	private void method_39()
	{
		this.label24.Text = "Whoops, the device didn't enter DFU mode. Click Retry to try again.";
		this.button6.Enabled = true;
		this.button7.Enabled = true;
		this.button7.Text = "Retry";
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00962148 File Offset: 0x00960348
	[CompilerGenerated]
	private async void method_40()
	{
		this.label22.Visible = false;
		this.homeButton.Visible = false;
		this.volumeDown.Visible = false;
		this.sideButton.Visible = false;
		this.label24.Text = "Device entered DFU mode successfully.";
		await Task.Delay(1500);
		this.bootPanel.Visible = true;
		this.method_17();
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0095BC8C File Offset: 0x00959E8C
	static Process smethod_1()
	{
		return Activator.CreateInstance(typeof(Process));
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0095BCC4 File Offset: 0x00959EC4
	static ProcessStartInfo smethod_2()
	{
		return Activator.CreateInstance(typeof(ProcessStartInfo));
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0095BD18 File Offset: 0x00959F18
	static Label smethod_3()
	{
		return Activator.CreateInstance(typeof(Label));
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0095BD50 File Offset: 0x00959F50
	static Button smethod_4()
	{
		return Activator.CreateInstance(typeof(Button));
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0095BD34 File Offset: 0x00959F34
	static Panel smethod_5()
	{
		return Activator.CreateInstance(typeof(Panel));
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00962184 File Offset: 0x00960384
	static ProgressBar smethod_6()
	{
		return Activator.CreateInstance(typeof(ProgressBar));
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0095BD88 File Offset: 0x00959F88
	static PictureBox smethod_7()
	{
		return Activator.CreateInstance(typeof(PictureBox));
	}

	// Token: 0x040000EF RID: 239
	public string string_0 = "";

	// Token: 0x040000F0 RID: 240
	public string string_1 = "";

	// Token: 0x040000F1 RID: 241
	public string string_2 = "";

	// Token: 0x040000F2 RID: 242
	public bool bool_0 = false;

	// Token: 0x040000F3 RID: 243
	public bool bool_1 = false;

	// Token: 0x040000F4 RID: 244
	public string string_3 = "";

	// Token: 0x040000F5 RID: 245
	public bool bool_2 = false;

	// Token: 0x040000F6 RID: 246
	public string string_4 = "";

	// Token: 0x040000F7 RID: 247
	public string string_5 = "";

	// Token: 0x040000F8 RID: 248
	public string string_6 = "";

	// Token: 0x040000F9 RID: 249
	public string string_7 = "";

	// Token: 0x040000FA RID: 250
	public string string_8 = "";

	// Token: 0x040000FB RID: 251
	public string string_9 = "";

	// Token: 0x040000FC RID: 252
	public bool bool_3;

	// Token: 0x040000FD RID: 253
	public string string_10;

	// Token: 0x040000FE RID: 254
	public string string_11;

	// Token: 0x040000FF RID: 255
	public string string_12;

	// Token: 0x04000100 RID: 256
	public string string_13;

	// Token: 0x04000101 RID: 257
	public string string_14;

	// Token: 0x04000102 RID: 258
	public string string_15;

	// Token: 0x04000103 RID: 259
	public string string_16;

	// Token: 0x04000104 RID: 260
	public string string_17;

	// Token: 0x04000105 RID: 261
	public string string_18;

	// Token: 0x04000106 RID: 262
	public string string_19;

	// Token: 0x04000107 RID: 263
	public string string_20;

	// Token: 0x04000108 RID: 264
	public string string_21;

	// Token: 0x04000109 RID: 265
	public string string_22;

	// Token: 0x0400010A RID: 266
	public string string_23;

	// Token: 0x0400010B RID: 267
	public string string_24 = "DFU";

	// Token: 0x0400010C RID: 268
	public string string_25 = "1.3";

	// Token: 0x0400010D RID: 269
	public static IDeviceNotifier ideviceNotifier_0 = DeviceNotifier.OpenDeviceNotifier();

	// Token: 0x0400010E RID: 270
	private Dictionary<string, string> dictionary_0;

	// Token: 0x0400010F RID: 271
	private IContainer icontainer_0;

	// Token: 0x04000110 RID: 272
	private Label label22;

	// Token: 0x04000111 RID: 273
	private Label sideButton;

	// Token: 0x04000112 RID: 274
	private Label volumeDown;

	// Token: 0x04000113 RID: 275
	private Label homeButton;

	// Token: 0x04000114 RID: 276
	private Button button6;

	// Token: 0x04000115 RID: 277
	private Button button7;

	// Token: 0x04000116 RID: 278
	private PictureBox devicePicture;

	// Token: 0x04000117 RID: 279
	private Label label20;

	// Token: 0x04000118 RID: 280
	private Label pressDFU;

	// Token: 0x04000119 RID: 281
	private Label startDFU;

	// Token: 0x0400011A RID: 282
	private Label label24;

	// Token: 0x0400011B RID: 283
	private Panel bootPanel;

	// Token: 0x0400011C RID: 284
	private ProgressBar progressBar1;

	// Token: 0x0400011D RID: 285
	private Button button8;

	// Token: 0x0400011E RID: 286
	private Label label18;

	// Token: 0x0400011F RID: 287
	private Label label17;

	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	private sealed class Class24
	{
		// Token: 0x06000113 RID: 275 RVA: 0x009625C0 File Offset: 0x009607C0
		[DebuggerStepThrough]
		internal T0 method_0<T0>()
		{
			jailbreak.Class24.Class25 @class = new jailbreak.Class24.Class25();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.class24_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class24.Class25>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400012D RID: 301
		public jailbreak jailbreak_0;

		// Token: 0x0400012E RID: 302
		public bool bool_0;

		// Token: 0x02000023 RID: 35
		private sealed class Class25 : IAsyncStateMachine
		{
			// Token: 0x06000115 RID: 277 RVA: 0x00962604 File Offset: 0x00960804
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
						goto IL_A0;
					}
					if (num != 1)
					{
						goto IL_71;
					}
					TaskAwaiter awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_6A:
					awaiter2.GetResult();
					IL_71:
					if (this.class24_0.bool_0)
					{
						goto IL_135;
					}
					awaiter = this.class24_0.jailbreak_0.method_0<Task<bool>>().GetAwaiter();
					jailbreak.Class24.Class25 @class;
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						@class = this;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, jailbreak.Class24.Class25>(ref awaiter, ref @class);
						return;
					}
					IL_A0:
					this.bool_0 = awaiter.GetResult();
					this.class24_0.bool_0 = this.bool_0;
					if (this.class24_0.bool_0)
					{
						goto IL_71;
					}
					awaiter2 = Task.Delay(500).GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_6A;
					}
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					@class = this;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, jailbreak.Class24.Class25>(ref awaiter2, ref @class);
					return;
				}
				catch (Exception ex)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(ex);
					return;
				}
				IL_135:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06000116 RID: 278 RVA: 0x0095C980 File Offset: 0x0095AB80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400012F RID: 303
			public int int_0;

			// Token: 0x04000130 RID: 304
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000131 RID: 305
			public jailbreak.Class24 class24_0;

			// Token: 0x04000132 RID: 306
			private bool bool_0;

			// Token: 0x04000133 RID: 307
			private TaskAwaiter<bool> taskAwaiter_0;

			// Token: 0x04000134 RID: 308
			private TaskAwaiter taskAwaiter_1;
		}
	}

	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	private sealed class Class26
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00962778 File Offset: 0x00960978
		[DebuggerStepThrough]
		internal T0 method_0<T0>()
		{
			jailbreak.Class26.Class27 @class = new jailbreak.Class26.Class27();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.class26_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<jailbreak.Class26.Class27>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000135 RID: 309
		public jailbreak jailbreak_0;

		// Token: 0x04000136 RID: 310
		public bool bool_0;

		// Token: 0x02000025 RID: 37
		private sealed class Class27 : IAsyncStateMachine
		{
			// Token: 0x0600011A RID: 282 RVA: 0x009627BC File Offset: 0x009609BC
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
						goto IL_A0;
					}
					if (num != 1)
					{
						goto IL_71;
					}
					TaskAwaiter awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_6A:
					awaiter2.GetResult();
					IL_71:
					if (this.class26_0.bool_0)
					{
						goto IL_135;
					}
					awaiter = this.class26_0.jailbreak_0.method_1<Task<bool>>().GetAwaiter();
					jailbreak.Class26.Class27 @class;
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						@class = this;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, jailbreak.Class26.Class27>(ref awaiter, ref @class);
						return;
					}
					IL_A0:
					this.bool_0 = awaiter.GetResult();
					this.class26_0.bool_0 = this.bool_0;
					if (this.class26_0.bool_0)
					{
						goto IL_71;
					}
					awaiter2 = Task.Delay(500).GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_6A;
					}
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					@class = this;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, jailbreak.Class26.Class27>(ref awaiter2, ref @class);
					return;
				}
				catch (Exception ex)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(ex);
					return;
				}
				IL_135:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600011B RID: 283 RVA: 0x0095C980 File Offset: 0x0095AB80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000137 RID: 311
			public int int_0;

			// Token: 0x04000138 RID: 312
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000139 RID: 313
			public jailbreak.Class26 class26_0;

			// Token: 0x0400013A RID: 314
			private bool bool_0;

			// Token: 0x0400013B RID: 315
			private TaskAwaiter<bool> taskAwaiter_0;

			// Token: 0x0400013C RID: 316
			private TaskAwaiter taskAwaiter_1;
		}
	}

	// Token: 0x02000026 RID: 38
	[CompilerGenerated]
	private sealed class Class28
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00962930 File Offset: 0x00960B30
		internal void method_0()
		{
			this.jailbreak_0.pressDFU.Text = this.string_0;
		}

		// Token: 0x0400013D RID: 317
		public string string_0;

		// Token: 0x0400013E RID: 318
		public jailbreak jailbreak_0;
	}

	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	private sealed class Class29
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00962954 File Offset: 0x00960B54
		internal void method_0()
		{
			this.jailbreak_0.label20.Text = this.string_0;
		}

		// Token: 0x0400013F RID: 319
		public string string_0;

		// Token: 0x04000140 RID: 320
		public jailbreak jailbreak_0;
	}

	// Token: 0x02000028 RID: 40
	[CompilerGenerated]
	private sealed class Class30
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00962978 File Offset: 0x00960B78
		internal void method_0()
		{
			this.class29_0.jailbreak_0.label20.Text = this.string_0;
		}

		// Token: 0x04000141 RID: 321
		public string string_0;

		// Token: 0x04000142 RID: 322
		public jailbreak.Class29 class29_0;
	}
}

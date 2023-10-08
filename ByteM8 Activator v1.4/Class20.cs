using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using LibUsbDotNet;

// Token: 0x0200001D RID: 29
internal class Class20
{
	// Token: 0x060000BB RID: 187 RVA: 0x0095EE20 File Offset: 0x0095D020
	public void method_0<T0, T1>()
	{
		try
		{
			T0 t = Class20.smethod_0();
			t.UseShellExecute = false;
			t.CreateNoWindow = true;
			t.Verb = "runas";
			t.FileName = "cmd.exe";
			t.Arguments = "/C setlocal enabledelayedexpansion && RMDIR /s /q C:\\Windows\\Temp\\File > nul 2>&1";
			Process.Start(t).WaitForExit();
			t.Arguments = "/C reg delete HKEY_CURRENT_USER\\SOFTWARE\\SimonTatham\\PuTTY\\SshHostKeys /f > nul 2>&1";
			Process.Start(t).WaitForExit();
			t.Arguments = "/C reg add HKEY_CURRENT_USER\\SOFTWARE\\SimonTatham\\PuTTY\\SshHostKeys /f > nul 2>&1";
			Process.Start(t).WaitForExit();
			t.Arguments = "/C reg Query \"HKLM\\Hardware\\Description\\System\\CentralProcessor\\0\" | find /i \"x86\" > NUL && set cpu=32 || set cpu=64";
			Process.Start(t).WaitForExit();
			t.Arguments = "/C if \"%PROCESSOR_ARCHITECTURE%\" EQU \"amd64\" ( >nul 2>&1 \"%SYSTEMROOT%\\SysWOW64\\cacls\" \"%SYSTEMROOT%\\SysWOW64\\config\\system\" ) ELSE ( >nul 2>&1 \"%SYSTEMROOT%\\system32\\cacls\" \"%SYSTEMROOT%\\system32\\config\\system\" )";
			Process.Start(t).WaitForExit();
			Process.Start(t).WaitForExit();
		}
		catch (Exception t2)
		{
			throw new Exception(t2.Message);
		}
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0095EEF0 File Offset: 0x0095D0F0
	public T0 method_1<T0, T1, T2, T3>(T0 gparam_0)
	{
		T0 t4;
		try
		{
			T0 t = this.method_14<Process, ProcessStartInfo, T0>("-e");
			if (string.IsNullOrEmpty(t))
			{
				throw new Exception("not found driver oem list");
			}
			T0[] array = t.Split(new T0[] { "oem" }, StringSplitOptions.RemoveEmptyEntries);
			T0[] array2 = array;
			T0[] array3 = array2;
			for (T2 t2 = 0; t2 < array3.Length; t2++)
			{
				T0 t3 = array3[t2];
				if (t3.ToLower().Contains(gparam_0.ToLower()))
				{
					T0[] array4 = t3.Split(new T0[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
					return "oem" + array4[0].Replace("\n", "").Replace("\r", "").Replace(" ", "")
						.Replace("\t", "");
				}
			}
			t4 = null;
		}
		catch (Exception t5)
		{
			throw new Exception(t5.Message);
		}
		return t4;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0095EFFC File Offset: 0x0095D1FC
	public T0 method_2<T0, T1>()
	{
		T0 t;
		try
		{
			t = this.method_14<Process, ProcessStartInfo, T0>(" /scan-devices ");
		}
		catch (Exception t2)
		{
			throw new Exception(t2.Message);
		}
		return t;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0095F038 File Offset: 0x0095D238
	public T0 method_3<T0, T1>(T0 gparam_0)
	{
		T0 t2;
		try
		{
			T0 t = " /delete-driver " + gparam_0 + " /uninstall /force";
			t2 = this.method_14<Process, ProcessStartInfo, T0>(t);
		}
		catch (Exception t3)
		{
			throw new Exception(t3.Message);
		}
		return t2;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0095F080 File Offset: 0x0095D280
	public T1 method_4<T0, T1, T2>()
	{
		Process process = Class20.smethod_1();
		ProcessStartInfo processStartInfo = Class20.smethod_0();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Verb = "runas";
		processStartInfo.Arguments = "/C \"" + Path.Combine(Application.StartupPath, "ref\\Drivers\\Other\\UsbDkController.exe") + "\" -u";
		processStartInfo.WorkingDirectory = Path.GetDirectoryName(Path.Combine(Application.StartupPath, "ref\\Drivers\\Other\\UsbDkController.exe"));
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		process.StartInfo = processStartInfo;
		T0 t = process;
		t.Start();
		Thread.Sleep(1000);
		return t.StandardOutput.ReadToEnd() + t.StandardError.ReadToEnd();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0095F13C File Offset: 0x0095D33C
	public void method_5<T0>()
	{
		T0 t = Class20.smethod_1();
		t.StartInfo.FileName = Path.Combine(Application.StartupPath, "ref\\Drivers\\LibusbK\\dpscat.exe");
		t.StartInfo.UseShellExecute = false;
		t.StartInfo.Arguments = "/PATH \"" + Path.Combine(Environment.CurrentDirectory, "ref", "Drivers", "LibusbK") + "\"";
		t.StartInfo.UseShellExecute = false;
		t.StartInfo.RedirectStandardOutput = true;
		t.Start();
		t.WaitForExit();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0095F1D0 File Offset: 0x0095D3D0
	public void method_6<T0, T1>()
	{
		T0 t = Class20.smethod_1();
		t.StartInfo.Arguments = "install --inf=\"" + Path.Combine(new T1[]
		{
			Environment.CurrentDirectory,
			"ref",
			"Drivers",
			"LibusbK",
			"Checkra1n.inf"
		}) + "\"";
		t.StartInfo.FileName = Path.Combine(new T1[]
		{
			Environment.CurrentDirectory,
			"ref",
			"Drivers",
			"LibusbK",
			"install-filter.exe"
		});
		t.StartInfo.UseShellExecute = false;
		t.StartInfo.RedirectStandardOutput = true;
		t.StartInfo.CreateNoWindow = true;
		t.Start();
		t.WaitForExit();
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0095F2A0 File Offset: 0x0095D4A0
	public T0 method_7<T0, T1, T2>(T0 gparam_0)
	{
		T0 t4;
		try
		{
			T1 t = string.IsNullOrEmpty(gparam_0);
			if (t != null)
			{
				gparam_0 = Path.Combine(Application.StartupPath, "ref\\Drivers\\LibusbK\\Checkra1n.inf");
			}
			T1 t2 = !File.Exists(gparam_0);
			if (t2 != null)
			{
				throw new Exception("oeminf file not found. driver inf file error.");
			}
			T0 t3 = " -i -a \"" + gparam_0 + "\"";
			t4 = this.method_14<Process, ProcessStartInfo, T0>(t3);
		}
		catch (Exception t5)
		{
			throw new Exception(t5.Message);
		}
		return t4;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0095F31C File Offset: 0x0095D51C
	public T0 method_8<T0, T1, T2>(T0 gparam_0)
	{
		T0 t4;
		try
		{
			T1 t = string.IsNullOrEmpty(gparam_0);
			if (t != null)
			{
				gparam_0 = Path.Combine(Application.StartupPath, "ref\\Drivers\\LibusbK\\Checkra1n.inf");
			}
			T1 t2 = !File.Exists(gparam_0);
			if (t2 != null)
			{
				throw new Exception("oeminf file not found. driver inf file error.");
			}
			T0 t3 = " /add-driver \"" + gparam_0 + "\" /install";
			t4 = this.method_14<Process, ProcessStartInfo, T0>(t3);
		}
		catch (Exception t5)
		{
			throw new Exception(t5.Message);
		}
		return t4;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0095F398 File Offset: 0x0095D598
	public void method_9<T0, T1, T2, T3>()
	{
		T0 t = new X509Certificate2(Convert.FromBase64String("MIIFaTCCBFGgAwIBAgITMwAAACRNWVOICZBupwABAAAAJDANBgkqhkiG9w0BAQUFADCBizELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjE1MDMGA1UEAxMsTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQQ0EwHhcNMTYxMDEyMjAzMjUzWhcNMTgwMTA1MjAzMjUzWjCBoDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjENMAsGA1UECxMETU9QUjE7MDkGA1UEAxMyTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQdWJsaXNoZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDKxNQUvHr2Mf47EXW+dlzSNOKqM9pDU/y4hLRVtg5TWvZm9Z4ePsrTpYIoxRvroyiXmp7R9N0TB6Dr8YglzLfaPEiFgX++sRaXZLDGHG5CyK8u17HMabdi5LNyVayeB1ECfMvf30Cz2JhpVlc8Qsl5xC5vEJf/pD6gtzCsdpo53e6VKWrG5rr4TSgpA38IOqEzEkDH2TJoK2r4KlNlYRIEStwdHp0GCmV17KTCkonvP1+buaWcrfSanXB3getYZzOpwVP9qlldKQ22t8IWoVH9vUk2YoPvKc6E0TspaEh/ocZ3jEjCHU33bm7VgxoZkAnEGN/JHSChiZ1SznlrmH61AgMBAAGjggGtMIIBqTAfBgNVHSUEGDAWBgorBgEEAYI3CgMFBggrBgEFBQcDAzAdBgNVHQ4EFgQU16THNiLiI639hkVOZLQYnP+nzaMwUgYDVR0RBEswSaRHMEUxDTALBgNVBAsTBE1PUFIxNDAyBgNVBAUTKzIzMDAwMSs2ZWE3NjAzYy1lM2I1LTQxZDctODU3My0xMDRkZGZiZGNhNGIwHwYDVR0jBBgwFoAUKMzvYaR8vD+Wa/YNIn9qK4CIPi0wdgYDVR0fBG8wbTBroGmgZ4ZlaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9DUkwvcHJvZHVjdHMvTWljcm9zb2Z0JTIwV2luZG93cyUyMEhhcmR3YXJlJTIwQ29tcGF0aWJpbGl0eSUyMFBDQSgxKS5jcmwwegYIKwYBBQUHAQEEbjBsMGoGCCsGAQUFBzAChl5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdCUyMFdpbmRvd3MlMjBIYXJkd2FyZSUyMENvbXBhdGliaWxpdHklMjBQQ0EoMSkuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCfz/XQaDq8TI2upMyThBo7A38lEhFLeA5tHQuvIMpj8VuvEuFTktCVLXrT1uJwGCCF2N0qeK+KWF9VdQbJdVRhOKCHxY3Kxbnlh5oh3K9PAmual9xXxbin6F9Xhh3t9hhCGwNqSzMs0SpPbiq6CqH/Uknp2T12adE+unYdXd3UlbhqxG6sOPck9SUGDJAHkEXjBajuDMtibkzWci3s1W+CTW427KIBb8vM9UeenfezsSP20apCnXOAjPWfZbdefy2hb31cgbBUMNxYfACPP79a/ELJnPQLfy6nsnoxTCLLM+suut/pBLe26kD1fu6AzAWCKaYX4x3q05CarXOIXSHn"));
		T1 t2 = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
		T1 t3 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
		t2.Open(OpenFlags.ReadWrite);
		t2.Add(t);
		t3.Open(OpenFlags.ReadWrite);
		t3.Add(t);
		try
		{
			try
			{
				if (!Environment.Is64BitOperatingSystem)
				{
					this.method_11<string, ProcessStartInfo, Process, T3, T2, object, DataReceivedEventArgs>(Path.Combine(Application.StartupPath, "ref\\Drivers\\Other\\install_x86.exe"), Path.Combine(Application.StartupPath, "ref\\Drivers\\USB\\x86\\usbaapl.inf"), 0);
				}
				else
				{
					this.method_11<string, ProcessStartInfo, Process, T3, T2, object, DataReceivedEventArgs>(Path.Combine(Application.StartupPath, "ref\\Drivers\\Other\\install_x64.exe"), Path.Combine(Application.StartupPath, "ref\\Drivers\\USB\\x64\\usbaapl64.inf"), 0);
				}
			}
			catch (Exception t4)
			{
				MessageBox.Show(t4.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		catch (Exception t5)
		{
			MessageBox.Show(t5.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0095F48C File Offset: 0x0095D68C
	private void method_10<T0, T1, T2>(T1 gparam_0, T2 gparam_1)
	{
		T0 t = gparam_1.Data != null;
		if (t != null)
		{
			T0 t2 = gparam_1.Data.ToLower().Contains("error") || gparam_1.Data.ToLower().Contains("fail");
			if (t2 != null)
			{
				Console.WriteLine(gparam_1.Data + Environment.NewLine);
			}
			else
			{
				Console.WriteLine(gparam_1.Data + Environment.NewLine);
			}
		}
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0095F508 File Offset: 0x0095D708
	public void method_11<T0, T1, T2, T3, T4, T5, T6>(T0 gparam_0, T0 gparam_1, T4 gparam_2 = false)
	{
		T0 t = ((gparam_2 == null) ? ("install --inf=\"" + gparam_1 + "\"") : ("uninstall --inf=\"" + gparam_1 + "\""));
		try
		{
			ProcessStartInfo processStartInfo = Class20.smethod_0();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = gparam_0;
			processStartInfo.Arguments = t;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.Verb = "runas";
			processStartInfo.WorkingDirectory = Path.Combine(Application.StartupPath, "ref\\Drivers");
			T1 t2 = processStartInfo;
			t2.RedirectStandardOutput = true;
			t2.UseShellExecute = false;
			t2.CreateNoWindow = true;
			Process process = Class20.smethod_1();
			process.StartInfo = t2;
			T2 t3 = process;
			t3.OutputDataReceived += new DataReceivedEventHandler(this.method_10<T4, T5, T6>);
			t3.Start();
			t3.BeginOutputReadLine();
			t3.WaitForExit();
		}
		catch (Exception t4)
		{
			throw new Exception(t4.Message);
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0095F5F8 File Offset: 0x0095D7F8
	public void method_12<T0, T1>(T1 gparam_0)
	{
		T0 t = Class20.smethod_0();
		t.FileName = "cmd.exe";
		t.Verb = "runas";
		t.WorkingDirectory = Path.Combine(Application.StartupPath, "ref\\Divers\\LibusbK");
		t.Arguments = "/C " + gparam_0;
		t.CreateNoWindow = true;
		t.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(t).WaitForExit();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0095F660 File Offset: 0x0095D860
	public void method_13<T0, T1>()
	{
		T0 t = Path.Combine(Application.StartupPath, "ref\\Divers\\LibusbK\\DFU_Mode.vbs");
		this.method_12<T1, T0>("cscript " + t);
		this.method_12<T1, T0>("TIMEOUT 3 >nul");
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0095F69C File Offset: 0x0095D89C
	public T2 method_14<T0, T1, T2>(T2 gparam_0)
	{
		T0 t = Class20.smethod_1();
		Process process = t;
		T1 t2 = Class20.smethod_0();
		t2.UseShellExecute = false;
		t2.CreateNoWindow = true;
		t2.FileName = ".\\ref\\pnputil.exe";
		t2.Verb = "runas";
		t2.Arguments = gparam_0;
		t2.WorkingDirectory = Path.Combine(new T2[] { Application.StartupPath });
		t2.RedirectStandardOutput = true;
		t2.RedirectStandardError = true;
		process.StartInfo = t2;
		T0 t3 = t;
		t3.Start();
		return t3.StandardOutput.ReadToEnd() + t3.StandardError.ReadToEnd();
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0095F734 File Offset: 0x0095D934
	public void method_15<T0, T1, T2, T3>(T3 gparam_0)
	{
		try
		{
			T0[] processes = Process.GetProcesses();
			T0[] array = processes;
			T0[] array2 = array;
			for (T1 t = 0; t < array2.Length; t++)
			{
				T0 t2 = array2[t];
				T2 t3 = t2.ProcessName.ToLower().Contains(gparam_0);
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

	// Token: 0x060000CB RID: 203 RVA: 0x0095F794 File Offset: 0x0095D994
	public T2[][] method_16<T0, T1, T2, T3, T4, T5, T6, T7>()
	{
		T1 t = new ManagementObjectSearcher("root\\CIMV2", "SELECT DeviceID,Name FROM Win32_PnPEntity where Name Like '%Apple Mobile Device%'");
		T0 t2 = t.Get();
		T2[][] array = new string[t2.Count][];
		T3 t3 = t.Get().Count >= 1;
		if (t3 != null)
		{
			try
			{
				T4 t4 = 0;
				foreach (ManagementBaseObject managementBaseObject in t2)
				{
					T6 t5 = (T6)((object)managementBaseObject);
					T2 t6 = t5["DeviceID"].ToString();
					T2 t7 = t5["Name"].ToString();
					array[t4] = new T2[] { t6, t7 };
					t4++;
				}
				return array;
			}
			catch (Exception t8)
			{
				array[0] = new T2[] { t8.Message };
				return array;
			}
		}
		return array;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0095F894 File Offset: 0x0095DA94
	public void method_17<T0, T1, T2, T3, T4>(T0 gparam_0, T1 gparam_1 = true, T1 gparam_2 = true)
	{
		T0 t = this.method_20<T0, ProcessStartInfo, Process, Regex, MatchCollection, RegexOptions>(gparam_0);
		this.method_18<T0, ProcessStartInfo, Process>("pnputil -d " + t + " -f -u");
		if (gparam_2 != null)
		{
			this.method_9<T2, T3, T1, T4>();
		}
		if (gparam_1 != null)
		{
			this.method_18<T0, ProcessStartInfo, Process>("pnputil /scan-devices");
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0095F8DC File Offset: 0x0095DADC
	public T0 method_18<T0, T1, T2>(T0 gparam_0)
	{
		T0 t = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), (!Environment.Is64BitOperatingSystem || Environment.Is64BitProcess) ? "System32\\cmd.exe" : "Sysnative\\cmd.exe");
		T1 t2 = new ProcessStartInfo(t, "/c " + gparam_0);
		t2.RedirectStandardOutput = true;
		t2.UseShellExecute = false;
		t2.CreateNoWindow = true;
		T2 t3 = Class20.smethod_1();
		t3.StartInfo = t2;
		t3.Start();
		T0 t4 = t3.StandardOutput.ReadToEnd();
		Console.WriteLine(t4);
		return t4;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0095F964 File Offset: 0x0095DB64
	public T1 method_19<T0, T1, T2, T3>(T2 gparam_0, T2 gparam_1, T3 gparam_2 = 4)
	{
		T0 t = new Regex(gparam_1, gparam_2);
		return t.Matches(gparam_0);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0095F984 File Offset: 0x0095DB84
	public T0 method_20<T0, T1, T2, T3, T4, T5>(T0 gparam_0)
	{
		T0 t = this.method_18<T0, T1, T2>("pnputil /enum-devices /instanceid \"" + gparam_0 + "\" /connected");
		T0 t3;
		try
		{
			T0 t2 = t;
			t = this.method_19<T3, T4, T0, T5>(t2, "oem(.*?).inf", 4)[0].Value.ToString().Trim();
			t3 = t;
		}
		catch
		{
			t3 = t;
		}
		return t3;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0095F9F0 File Offset: 0x0095DBF0
	public void method_21<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
	{
		T0[][] array = this.method_16<T2, T3, T0, T4, T1, T5, T6, T7>();
		T0[][] array2 = array;
		T0[][] array3 = array2;
		for (T1 t = 0; t < array3.Length; t++)
		{
			T0[] array4 = array3[t];
			this.method_17<T0, T4, T8, T9, T7>(array4[0], 0, 0);
		}
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0095FA28 File Offset: 0x0095DC28
	public T2 method_22<T0, T1, T2>(T1 gparam_0, T1 gparam_1)
	{
		T0 allWinUsbDevices = UsbDevice.AllWinUsbDevices;
		T1 t = 0;
		for (;;)
		{
			T2 t2 = t < allWinUsbDevices.Count;
			if (t2 == null)
			{
				goto IL_48;
			}
			if (allWinUsbDevices[t].Vid == gparam_0 && allWinUsbDevices[t].Pid == gparam_1)
			{
				break;
			}
			t++;
		}
		return 1;
		IL_48:
		return 0;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0095BCC4 File Offset: 0x00959EC4
	static ProcessStartInfo smethod_0()
	{
		return Activator.CreateInstance(typeof(ProcessStartInfo));
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0095BC8C File Offset: 0x00959E8C
	static Process smethod_1()
	{
		return Activator.CreateInstance(typeof(Process));
	}
}

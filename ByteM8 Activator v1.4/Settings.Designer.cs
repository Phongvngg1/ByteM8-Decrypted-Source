using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ByteM8.Properties
{
	// Token: 0x02000033 RID: 51
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600014D RID: 333 RVA: 0x009640B4 File Offset: 0x009622B4
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x04000189 RID: 393
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

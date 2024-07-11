using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace maxcare.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings E3A50997 = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => E3A50997;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string UserName
	{
		get
		{
			return (string)this["UserName"];
		}
		set
		{
			this["UserName"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string PassWord
	{
		get
		{
			return (string)this["PassWord"];
		}
		set
		{
			this["PassWord"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string PathChrome
	{
		get
		{
			return (string)this["PathChrome"];
		}
		set
		{
			this["PathChrome"] = value;
		}
	}
}

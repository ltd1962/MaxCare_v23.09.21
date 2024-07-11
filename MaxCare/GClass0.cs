using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass0
{
	private struct Struct0
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal bool bool_0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal string F02A0C39;

		public bool B6130237
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return F02A0C39;
			}
			[CompilerGenerated]
			set
			{
				F02A0C39 = value;
			}
		}
	}

	private static class BB1BBA2F
	{
		private const string string_0 = "Folders|\n";

		private const BindingFlags B339DF9A = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private static readonly Assembly F98C4DB8 = typeof(FileDialog).Assembly;

		private static readonly Type type_0 = F98C4DB8.GetType("System.Windows.Forms.FileDialogNative+IFileDialog");

		private static readonly MethodInfo methodInfo_0 = typeof(OpenFileDialog).GetMethod("CreateVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo methodInfo_1 = typeof(OpenFileDialog).GetMethod("OnBeforeVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo E6B21C09 = typeof(FileDialog).GetMethod("GetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo D722C885 = type_0.GetMethod("SetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly uint FE882680 = (uint)F98C4DB8.GetType("System.Windows.Forms.FileDialogNative+FOS").GetField("FOS_PICKFOLDERS").GetValue(null);

		private static readonly ConstructorInfo F1B07AA7 = F98C4DB8.GetType("System.Windows.Forms.FileDialog+VistaDialogEvents").GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(FileDialog) }, null);

		private static readonly MethodInfo B393E60C = type_0.GetMethod("Advise");

		private static readonly MethodInfo CF312128 = type_0.GetMethod("Unadvise");

		private static readonly MethodInfo methodInfo_2 = type_0.GetMethod("Show");

		public static Struct0 smethod_0(IntPtr intptr_0, string string_1, string string_2)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				AddExtension = false,
				CheckFileExists = false,
				DereferenceLinks = true,
				Filter = "Folders|\n",
				InitialDirectory = string_1,
				Multiselect = false,
				Title = string_2
			};
			object obj = methodInfo_0.Invoke(openFileDialog, new object[0]);
			methodInfo_1.Invoke(openFileDialog, new object[1] { obj });
			D722C885.Invoke(obj, new object[1] { (uint)E6B21C09.Invoke(openFileDialog, new object[0]) | FE882680 });
			object[] array = new object[2]
			{
				F1B07AA7.Invoke(new object[1] { openFileDialog }),
				0u
			};
			B393E60C.Invoke(obj, array);
			try
			{
				int num = (int)methodInfo_2.Invoke(obj, new object[1] { intptr_0 });
				Struct0 result = default(Struct0);
				result.B6130237 = num == 0;
				result.String_0 = openFileDialog.FileName;
				return result;
			}
			finally
			{
				CF312128.Invoke(obj, new object[1] { array[1] });
			}
		}
	}

	private class Class0 : IWin32Window
	{
		private readonly IntPtr intptr_0;

		public IntPtr Handle => intptr_0;

		public Class0(IntPtr D904E709)
		{
			intptr_0 = D904E709;
		}
	}

	private string string_0;

	private string C4059204;

	private string string_1 = "";

	public string String_0
	{
		get
		{
			return string.IsNullOrEmpty(string_0) ? Environment.CurrentDirectory : string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string FBA11E18
	{
		get
		{
			return C4059204 ?? "Select a folder";
		}
		set
		{
			C4059204 = value;
		}
	}

	public string String_1 => string_1;

	public bool method_0()
	{
		return method_1(IntPtr.Zero);
	}

	public bool method_1(IntPtr F787EA2B)
	{
		Struct0 @struct = ((Environment.OSVersion.Version.Major >= 6) ? BB1BBA2F.smethod_0(F787EA2B, String_0, FBA11E18) : BC8A0B9E(F787EA2B, String_0, FBA11E18));
		string_1 = @struct.String_0;
		return @struct.B6130237;
	}

	private static Struct0 BC8A0B9E(IntPtr intptr_0, string string_2, string string_3)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			Description = string_3,
			SelectedPath = string_2,
			ShowNewFolderButton = false
		};
		Struct0 result = default(Struct0);
		if (folderBrowserDialog.ShowDialog(new Class0(intptr_0)) == DialogResult.OK)
		{
			result.B6130237 = true;
			result.String_0 = folderBrowserDialog.SelectedPath;
		}
		return result;
	}
}

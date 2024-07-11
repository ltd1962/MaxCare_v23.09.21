using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

[CompilerGenerated]
internal static class PackCostura
{
	private static object AB1C64A6 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static string A2BB2833;

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static Dictionary<string, string> BB36E8BE = new Dictionary<string, string>();

	private static List<string> B309CD12 = new List<string>();

	private static List<string> list_0 = new List<string>();

	private static Dictionary<string, string> AC8F35BC = new Dictionary<string, string>();

	private static int B102A0BA;

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return cultureInfo_0.Name;
	}

	private static Assembly EDB8289B(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static Assembly smethod_1(string A035F12E, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		string path = ((IntPtr.Size == 8) ? "64" : "32");
		string path2 = Path.Combine(A035F12E, text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.Combine(Path.Combine(A035F12E, path), text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		return null;
	}

	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static Stream D03D40BF(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(string_0))
			{
				using DeflateStream stream_ = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_2(stream_, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	private static Stream C71467AA(Dictionary<string, string> dictionary_2, string string_0)
	{
		if (dictionary_2.TryGetValue(string_0, out var value))
		{
			return D03D40BF(value);
		}
		return null;
	}

	private static byte[] smethod_3(Stream F504428D)
	{
		byte[] array = new byte[F504428D.Length];
		F504428D.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly E1AD59A2(Dictionary<string, string> F28D2630, Dictionary<string, string> dictionary_2, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = C71467AA(F28D2630, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_3(stream);
		}
		using (Stream stream2 = C71467AA(dictionary_2, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_3(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly AE90CF05(object F82F7FA8, ResolveEventArgs D60F3135)
	{
		lock (AB1C64A6)
		{
			if (dictionary_0.ContainsKey(D60F3135.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(D60F3135.Name);
		Assembly assembly = EDB8289B(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_1(A2BB2833, assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = E1AD59A2(dictionary_1, BB36E8BE, assemblyName);
		if ((object)assembly == null)
		{
			lock (AB1C64A6)
			{
				dictionary_0[D60F3135.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static PackCostura()
	{
		AC8F35BC.Add("costura32.main.dll", "ABAC6D53CD29DEB57D87FE9616C2369A2D262338");
		AC8F35BC.Add("costura64.main.dll", "ABAC6D53CD29DEB57D87FE9616C2369A2D262338");
		dictionary_1.Add("bunifu_ui_v1.52", "costura.bunifu_ui_v1.52.dll.compressed");
		dictionary_1.Add("costura", "costura.costura.dll.compressed");
		BB36E8BE.Add("costura", "costura.costura.pdb.compressed");
		dictionary_1.Add("entityframework", "costura.entityframework.dll.compressed");
		dictionary_1.Add("entityframework.sqlserver", "costura.entityframework.sqlserver.dll.compressed");
		dictionary_1.Add("http", "costura.http.dll.compressed");
		dictionary_1.Add("managedwinapi", "costura.managedwinapi.dll.compressed");
		dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		dictionary_1.Add("system.buffers", "costura.system.buffers.dll.compressed");
		dictionary_1.Add("system.data.sqlite", "costura.system.data.sqlite.dll.compressed");
		dictionary_1.Add("system.data.sqlite.ef6", "costura.system.data.sqlite.ef6.dll.compressed");
		dictionary_1.Add("system.data.sqlite.linq", "costura.system.data.sqlite.linq.dll.compressed");
		dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		dictionary_1.Add("system.memory", "costura.system.memory.dll.compressed");
		dictionary_1.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
		dictionary_1.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
		dictionary_1.Add("webdriver", "costura.webdriver.dll.compressed");
		dictionary_1.Add("webdriver.support", "costura.webdriver.support.dll.compressed");
		dictionary_1.Add("xnet", "costura.xnet.dll.compressed");
		B309CD12.Add("costura32.main.dll");
		list_0.Add("costura64.main.dll");
	}

	private static void smethod_4(string string_0)
	{
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
	}

	private static string CEA5BD82(string string_0)
	{
		string text = ((IntPtr.Size == 8) ? "64" : "32");
		string text2 = string_0;
		if (string_0.StartsWith("costura" + text + "."))
		{
			text2 = Path.Combine(text, string_0.Substring(10));
		}
		else if (string_0.StartsWith("costura."))
		{
			text2 = string_0.Substring(8);
		}
		if (text2.EndsWith(".compressed"))
		{
			text2 = text2.Substring(0, text2.Length - 11);
		}
		return text2;
	}

	private static string smethod_5(string E3814FAE)
	{
		using FileStream stream = new FileStream(E3814FAE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		using BufferedStream inputStream = new BufferedStream(stream);
		using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(inputStream);
		StringBuilder stringBuilder = new StringBuilder(2 * array.Length);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll")]
	private static extern uint SetErrorMode(uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_0, IntPtr EC85AC23, uint uint_0);

	private static void CF16F71C(string A584B587, IList<string> F994498E, Dictionary<string, string> dictionary_2)
	{
		foreach (string item in F994498E)
		{
			string path = CEA5BD82(item);
			string text = Path.Combine(A584B587, path);
			if (File.Exists(text))
			{
				string text2 = smethod_5(text);
				if (text2 != dictionary_2[item])
				{
					File.Delete(text);
				}
			}
			if (File.Exists(text))
			{
				continue;
			}
			using Stream stream_ = D03D40BF(item);
			using FileStream stream_2 = File.OpenWrite(text);
			smethod_2(stream_, stream_2);
		}
		uint errorMode = SetErrorMode(32771u);
		foreach (string item2 in F994498E)
		{
			string path = CEA5BD82(item2);
			if (path.EndsWith(".dll"))
			{
				string string_ = Path.Combine(A584B587, path);
				LoadLibraryEx(string_, IntPtr.Zero, 8u);
			}
		}
		SetErrorMode(errorMode);
	}

	private static void smethod_6(string C3308E98, string A792A82F, List<string> list_1, Dictionary<string, string> dictionary_2)
	{
		string name = "Costura" + C3308E98;
		using Mutex mutex = new Mutex(initiallyOwned: false, name);
		bool flag = false;
		try
		{
			try
			{
				if (!(flag = mutex.WaitOne(60000, exitContext: false)))
				{
					throw new TimeoutException("Timeout waiting for exclusive access");
				}
			}
			catch (AbandonedMutexException)
			{
				flag = true;
			}
			string path = ((IntPtr.Size == 8) ? "64" : "32");
			smethod_4(Path.Combine(A792A82F, path));
			CF16F71C(A792A82F, list_1, dictionary_2);
		}
		finally
		{
			if (flag)
			{
				mutex.ReleaseMutex();
			}
		}
	}

	public static void EF3547AA()
	{
		if (Interlocked.Exchange(ref B102A0BA, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object obj = currentDomain.GetType()?.GetProperty("SetupInformation")?.GetValue(currentDomain);
		PropertyInfo propertyInfo = obj?.GetType()?.GetProperty("TargetFrameworkName");
		if ((object)propertyInfo != null && propertyInfo.GetValue(obj) == null)
		{
			string text = ((TargetFrameworkAttribute)(Assembly.GetCallingAssembly()?.GetCustomAttribute(typeof(TargetFrameworkAttribute))))?.FrameworkName;
			if (text != null)
			{
				currentDomain.SetData("TargetFrameworkName", text);
			}
		}
		string text2 = "7610FAA48864F4A406DEDAA009302F19";
		string path = Path.Combine(Path.GetTempPath(), "Costura");
		A2BB2833 = Path.Combine(path, text2);
		List<string> list_ = ((IntPtr.Size == 8) ? list_0 : B309CD12);
		smethod_6(text2, A2BB2833, list_, AC8F35BC);
		currentDomain.AssemblyResolve += delegate(object F82F7FA8, ResolveEventArgs D60F3135)
		{
			lock (AB1C64A6)
			{
				if (dictionary_0.ContainsKey(D60F3135.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(D60F3135.Name);
			Assembly assembly = EDB8289B(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_1(A2BB2833, assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = E1AD59A2(dictionary_1, BB36E8BE, assemblyName);
			if ((object)assembly == null)
			{
				lock (AB1C64A6)
				{
					dictionary_0[D60F3135.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}

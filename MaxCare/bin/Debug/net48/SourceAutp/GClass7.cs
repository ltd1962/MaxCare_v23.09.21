using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

public class GClass7
{
	private sealed class Class34 : Class33
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override char vmethod_16()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override double vmethod_7()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override byte vmethod_15()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ulong vmethod_22()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override uint vmethod_9()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public override short vmethod_24()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int vmethod_2()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override float vmethod_8()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override Type vmethod_1()
		{
			return typeof(Pointer);
		}

		public override ushort vmethod_14()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override object vmethod_10()
		{
			if (!type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(intptr_0, type_0);
		}

		public override long vmethod_13()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override void vmethod_0(object object_0)
		{
			while (true)
			{
				if (object_0 != null)
				{
					if (type_0.IsValueType)
					{
						break;
					}
					while (true)
					{
						switch (Type.GetTypeCode(object_0.GetType()))
						{
						case TypeCode.Char:
							break;
						case TypeCode.Int64:
							goto end_IL_0013;
						default:
							throw new ArgumentException();
						case TypeCode.SByte:
							Marshal.WriteByte(intptr_0, (byte)Convert.ToSByte(object_0));
							return;
						case TypeCode.Byte:
							Marshal.WriteByte(intptr_0, Convert.ToByte(object_0));
							return;
						case TypeCode.Int16:
							Marshal.WriteInt16(intptr_0, Convert.ToInt16(object_0));
							return;
						case TypeCode.UInt16:
							Marshal.WriteInt16(intptr_0, (short)Convert.ToUInt16(object_0));
							return;
						case TypeCode.Int32:
							Marshal.WriteInt32(intptr_0, Convert.ToInt32(object_0));
							return;
						case TypeCode.UInt32:
							Marshal.WriteInt32(intptr_0, (int)Convert.ToUInt32(object_0));
							return;
						case TypeCode.UInt64:
							Marshal.WriteInt64(intptr_0, (long)Convert.ToUInt64(object_0));
							return;
						case TypeCode.Single:
							Marshal.WriteInt32(intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), 20));
							return;
						case TypeCode.Double:
							Marshal.WriteInt64(intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), 6407417));
							return;
						}
						continue;
						end_IL_0013:
						break;
					}
					Marshal.WriteInt64(intptr_0, Convert.ToInt64(object_0));
					continue;
				}
				throw new ArgumentException();
			}
			Marshal.StructureToPtr(object_0, intptr_0, fDeleteOld: false);
		}

		public override TypeCode vmethod_18()
		{
			return TypeCode.Empty;
		}

		public override UIntPtr vmethod_6()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}

		public override Class19 vmethod_25()
		{
			return new Class34(intptr_0, type_0);
		}

		public Class34(IntPtr intptr_1, Type type_1)
		{
			intptr_0 = intptr_1;
			type_0 = type_1;
		}
	}

	private sealed class Class10 : IDisposable
	{
		private List<GCHandle> list_0 = new List<GCHandle>();

		public void Dispose()
		{
			foreach (GCHandle item in list_0)
			{
				item.Free();
			}
			list_0.Clear();
		}

		public IntPtr method_0(object object_0)
		{
			GCHandle item = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			list_0.Add(item);
			return item.AddrOfPinnedObject();
		}
	}

	private sealed class Class20 : Class19
	{
		private char char_0;

		public override int vmethod_2()
		{
			return char_0;
		}

		public override uint vmethod_9()
		{
			return char_0;
		}

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override byte vmethod_15()
		{
			return (byte)char_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class20(char_0);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)char_0;
		}

		public override void vmethod_0(object object_0)
		{
			char_0 = Convert.ToChar(object_0);
		}

		public override short vmethod_24()
		{
			return (short)char_0;
		}

		public override Type vmethod_1()
		{
			return typeof(char);
		}

		public override object vmethod_10()
		{
			return char_0;
		}

		public override ushort vmethod_14()
		{
			return char_0;
		}

		public Class20(char char_1)
		{
			char_0 = char_1;
		}
	}

	private sealed class Class11
	{
		private Type type_0;

		private Type[] type_1;

		private uint uint_0;

		private Enum2 enum2_0;

		public bool Boolean_0
		{
			get
			{
				switch (enum2_0 & Enum2.const_1)
				{
				default:
					return false;
				case Enum2.const_13:
				case Enum2.const_15:
				case Enum2.const_7:
				case Enum2.const_8:
				case Enum2.const_6:
				case Enum2.const_9:
				case Enum2.const_5:
				case Enum2.const_10:
					return true;
				}
			}
		}

		public CallingConvention CallingConvention_0 => (enum2_0 & Enum2.const_1) switch
		{
			Enum2.const_15 => (CallingConvention)754409723, 
			Enum2.const_7 => (CallingConvention)(-1632887005), 
			Enum2.const_8 => (CallingConvention)(-1630724316), 
			Enum2.const_6 => CallingConvention.FastCall, 
			_ => CallingConvention.Winapi, 
		};

		public Type Type_0 => type_0;

		public void method_0(byte[] byte_0, Module module_0)
		{
			Class12 @class = new Class12(byte_0);
			enum2_0 = (Enum2)@class.method_1();
			if ((enum2_0 & Enum2.const_12) != 0)
			{
				uint_0 = @class.method_2();
			}
			switch (enum2_0 & Enum2.const_1)
			{
			default:
				throw new COMException(null, -2146233799);
			case Enum2.const_3:
				type_0 = @class.method_0(module_0);
				break;
			case Enum2.const_14:
			case Enum2.const_0:
			{
				uint num2 = @class.method_2();
				type_1 = new Type[num2];
				for (int j = 3619; j < num2; j++)
				{
					type_1[j] = @class.method_0(module_0);
				}
				break;
			}
			case Enum2.const_13:
			case Enum2.const_15:
			case Enum2.const_7:
			case Enum2.const_8:
			case Enum2.const_6:
			case Enum2.const_9:
			case Enum2.const_4:
			case Enum2.const_5:
			case Enum2.const_10:
			{
				uint num = @class.method_2();
				type_0 = @class.method_0(module_0);
				type_1 = new Type[num];
				for (int i = 0; i < num; i++)
				{
					type_1[i] = @class.method_0(module_0);
				}
				break;
			}
			}
		}

		public Type[] method_1()
		{
			return type_1;
		}
	}

	private sealed class Class27 : Class26
	{
		private float float_0;

		public override TypeCode vmethod_18()
		{
			return TypeCode.Single;
		}

		public override double vmethod_7()
		{
			return float_0;
		}

		public override uint vmethod_9()
		{
			return (uint)float_0;
		}

		public static Class19 smethod_3(Class19 class19_0, Class19 class19_1)
		{
			float num = class19_0.vmethod_8();
			float num2 = class19_1.vmethod_8();
			int num3 = 0;
			if (num == num2)
			{
				num3 |= 0x40;
			}
			else if (num < num2)
			{
				num3 |= -512411947;
			}
			return new Class41(num3);
		}

		public static Class19 smethod_4(Class19 class19_0)
		{
			return new Class27(class19_0.vmethod_8());
		}

		public override Class19 vmethod_25()
		{
			return new Class27(float_0);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)float_0;
		}

		public override float vmethod_8()
		{
			return float_0;
		}

		public override long vmethod_13()
		{
			return (long)float_0;
		}

		public static Class19 smethod_5(Class19 class19_0, Class19 class19_1)
		{
			float num = class19_0.vmethod_8();
			float num2 = class19_1.vmethod_8();
			return new Class27(num % num2);
		}

		public override char vmethod_16()
		{
			return (char)float_0;
		}

		public override short vmethod_24()
		{
			return (short)float_0;
		}

		public static Class19 smethod_6(Class19 class19_0, Class19 class19_1)
		{
			float num = class19_0.vmethod_8();
			float num2 = class19_1.vmethod_8();
			return new Class27(num + num2);
		}

		public override void vmethod_0(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override object vmethod_10()
		{
			return float_0;
		}

		public static Class19 smethod_7(Class19 class19_0)
		{
			return new Class27(0f - class19_0.vmethod_8());
		}

		public override ushort vmethod_14()
		{
			return (ushort)float_0;
		}

		public override Type vmethod_1()
		{
			return typeof(float);
		}

		public static Class19 smethod_8(Class19 class19_0, Class19 class19_1)
		{
			float num = class19_0.vmethod_8();
			float num2 = class19_1.vmethod_8();
			return new Class27(num / num2);
		}

		public override int vmethod_2()
		{
			return (int)float_0;
		}

		public override UIntPtr vmethod_6()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)float_0) : ((ulong)float_0));
		}

		public static Class19 smethod_9(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			return new Class27((((uint)class19_0.vmethod_3() & 8u) != 0) ? ((float)num) : ((float)(long)num));
		}

		public override byte vmethod_15()
		{
			return (byte)float_0;
		}

		public static Class19 smethod_10(Class19 class19_0, Class19 class19_1)
		{
			float num = class19_0.vmethod_8();
			float num2 = class19_1.vmethod_8();
			return new Class27(num / num2);
		}

		public override bool vmethod_21()
		{
			return Convert.ToBoolean(float_0);
		}

		public override ulong vmethod_22()
		{
			return (ulong)float_0;
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)float_0) : ((long)float_0));
		}

		public Class27(float float_1)
		{
			float_0 = float_1;
		}
	}

	private sealed class Class35 : Class33
	{
		private Class19 class19_0;

		private FieldInfo fieldInfo_0;

		public override Class19 vmethod_25()
		{
			return new Class35(fieldInfo_0, class19_0);
		}

		public override void vmethod_0(object object_0)
		{
			class19_0.vmethod_23(fieldInfo_0, object_0);
		}

		public override Type vmethod_1()
		{
			return fieldInfo_0.FieldType;
		}

		public override object vmethod_10()
		{
			object obj = ((!class19_0.vmethod_1().IsPointer || !fieldInfo_0.DeclaringType.IsValueType) ? class19_0.vmethod_10() : Marshal.PtrToStructure(class19_0.vmethod_4(), fieldInfo_0.DeclaringType));
			return fieldInfo_0.GetValue(obj);
		}

		public Class35(FieldInfo fieldInfo_1, Class19 class19_1)
		{
			fieldInfo_0 = fieldInfo_1;
			class19_0 = class19_1;
		}
	}

	private sealed class Class21 : Class19
	{
		private ushort ushort_0;

		public override sbyte vmethod_17()
		{
			return (sbyte)ushort_0;
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool num2 = (class19_0.vmethod_3() & 8) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 65535L)
				{
					num3 |= 1;
				}
			}
			else if (num > 18446744072319696895uL)
			{
				num3 |= -1774109840;
			}
			class19_0 = new Class21((ushort)num);
			class19_0.vmethod_12(num3);
			return class19_0;
		}

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override void vmethod_0(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override object vmethod_10()
		{
			return ushort_0;
		}

		public override uint vmethod_9()
		{
			return ushort_0;
		}

		public override int vmethod_2()
		{
			return ushort_0;
		}

		public override short vmethod_24()
		{
			return (short)ushort_0;
		}

		public override Type vmethod_1()
		{
			return typeof(ushort);
		}

		public override byte vmethod_15()
		{
			return (byte)ushort_0;
		}

		public override ushort vmethod_14()
		{
			return ushort_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class21(ushort_0);
		}

		public Class21(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}
	}

	private sealed class Class28 : Class26
	{
		private Type type_0;

		private int int_1;

		private Class19 class19_0;

		private object object_0;

		public override void vmethod_0(object object_1)
		{
			object_0 = object_1;
			class19_0 = smethod_3(object_1);
		}

		public override double vmethod_7()
		{
			return class19_0.vmethod_7();
		}

		public override ushort vmethod_14()
		{
			return class19_0.vmethod_14();
		}

		public override Class19 vmethod_25()
		{
			return new Class28(object_0, type_0)
			{
				int_1 = int_1
			};
		}

		public override float vmethod_8()
		{
			return class19_0.vmethod_8();
		}

		private unsafe static Class19 smethod_3(object object_1)
		{
			IntPtr intPtr = ((object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1)));
			if (IntPtr.Size == 4)
			{
				return new Class41(intPtr.ToInt32());
			}
			return new Class44(intPtr.ToInt64());
		}

		public override bool vmethod_21()
		{
			return object_0 != null;
		}

		public override Type vmethod_1()
		{
			return type_0;
		}

		public override long vmethod_13()
		{
			return class19_0.vmethod_13();
		}

		public override UIntPtr vmethod_6()
		{
			return class19_0.vmethod_6();
		}

		public override int vmethod_2()
		{
			return class19_0.vmethod_2();
		}

		public override int vmethod_3()
		{
			return int_1;
		}

		public override byte vmethod_15()
		{
			return class19_0.vmethod_15();
		}

		public unsafe override void* vmethod_19()
		{
			return Pointer.Unbox(object_0);
		}

		public override ulong vmethod_22()
		{
			return class19_0.vmethod_22();
		}

		public override IntPtr vmethod_4()
		{
			return class19_0.vmethod_4();
		}

		public override TypeCode vmethod_18()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public static Class19 smethod_4(Class19 class19_1, Class19 class19_2)
		{
			while (class19_1 is Class28)
			{
			}
			if (((Class28)class19_2).vmethod_18() != TypeCode.UInt32)
			{
				return Class44.smethod_3(class19_1, class19_2);
			}
			return Class41.smethod_12(class19_1, class19_2);
		}

		public override sbyte vmethod_17()
		{
			return class19_0.vmethod_17();
		}

		public override uint vmethod_9()
		{
			return class19_0.vmethod_9();
		}

		public override short vmethod_24()
		{
			return class19_0.vmethod_24();
		}

		public unsafe static Class19 smethod_5(Class19 class19_1, Class19 class19_2)
		{
			Class28 @class = ((class19_1 is Class28) ? ((Class28)class19_1) : ((Class28)class19_2));
			Class19 class2 = ((@class.vmethod_18() == TypeCode.UInt32) ? Class41.smethod_11(class19_1, class19_2) : Class44.smethod_6(class19_1, class19_2));
			return new Class28(Pointer.Box(new IntPtr(class2.vmethod_13()).ToPointer(), @class.vmethod_1()), @class.vmethod_1())
			{
				int_1 = class2.vmethod_3()
			};
		}

		public Class28(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class19_0 = smethod_3(object_1);
		}
	}

	private sealed class Class12
	{
		private enum Enum1
		{
			const_0 = 5,
			const_1 = 28,
			const_2 = 11,
			const_3 = 30,
			const_4 = 18,
			const_5 = 25,
			const_6 = 29,
			const_7 = 1,
			const_8 = 24,
			const_9 = 14,
			const_10 = 13,
			const_11 = 31,
			const_12 = 17,
			const_13 = 7,
			const_14 = 0,
			const_15 = 23,
			const_16 = 3,
			const_17 = 9,
			const_18 = 22,
			const_19 = 6,
			const_20 = 65,
			const_21 = 12,
			const_22 = 4,
			const_23 = 10,
			const_24 = 19,
			const_25 = 20,
			const_26 = 32,
			const_27 = 16,
			const_28 = 69,
			const_29 = 8,
			const_30 = 2,
			const_31 = 26,
			const_32 = 15,
			const_33 = 21,
			const_34 = 27
		}

		private int int_0;

		private byte[] byte_0;

		public Type method_0(Module module_0)
		{
			while (true)
			{
				bool flag = false;
				while (true)
				{
					IL_0112:
					bool flag2 = true;
					while (true)
					{
						if (!flag2)
						{
							Type type;
							switch ((Enum1)method_2())
							{
							case Enum1.const_19:
								break;
							case Enum1.const_12:
							case Enum1.const_4:
								goto IL_00ef;
							case Enum1.const_2:
								type = typeof(ulong);
								goto IL_0112;
							case Enum1.const_0:
								goto IL_0112;
							case Enum1.const_8:
								type = typeof(IntPtr);
								break;
							case Enum1.const_14:
								type = null;
								goto IL_0221;
							case Enum1.const_7:
								type = typeof(void);
								goto IL_0221;
							case Enum1.const_30:
								type = typeof(bool);
								goto IL_0221;
							case Enum1.const_16:
								type = typeof(char);
								goto IL_0221;
							case Enum1.const_22:
								type = typeof(sbyte);
								goto IL_0221;
							case Enum1.const_13:
								type = typeof(ushort);
								goto IL_0221;
							case Enum1.const_29:
								type = typeof(int);
								goto IL_0221;
							case Enum1.const_17:
								type = typeof(uint);
								goto IL_0221;
							case Enum1.const_23:
								type = typeof(long);
								goto IL_0221;
							case Enum1.const_21:
								type = typeof(float);
								goto IL_0221;
							case Enum1.const_10:
								type = typeof(double);
								goto IL_0221;
							case Enum1.const_9:
								type = typeof(string);
								goto IL_0221;
							case Enum1.const_32:
								type = method_0(module_0).MakePointerType();
								goto IL_0221;
							case Enum1.const_5:
								type = typeof(UIntPtr);
								goto IL_0221;
							default:
								throw new COMException(null, -2146233785);
							case Enum1.const_1:
								type = typeof(object);
								goto IL_0221;
							case Enum1.const_6:
								{
									type = method_0(module_0).MakeArrayType();
									goto IL_0221;
								}
								IL_0221:
								if (flag)
								{
									type = type.MakeByRefType();
								}
								return type;
							}
							break;
						}
						goto IL_0008;
						IL_0008:
						switch ((Enum1)method_1())
						{
						case Enum1.const_11:
						case Enum1.const_26:
							method_2();
							break;
						case Enum1.const_27:
							flag = true;
							break;
						default:
							flag2 = false;
							int_0--;
							break;
						case Enum1.const_20:
						case Enum1.const_28:
							break;
						}
						continue;
						IL_00ef:
						method_2();
						goto IL_0008;
					}
					break;
				}
			}
		}

		public byte method_1()
		{
			return byte_0[int_0++];
		}

		public uint method_2()
		{
			byte b = byte_0[int_0];
			if ((b & 0x80) == 0)
			{
				int_0++;
			}
			else if ((b & -1058445891) == 0)
			{
				int_0 += 2;
			}
			else
			{
				int_0 += 4;
			}
			return 0u;
		}

		public Class12(byte[] byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private sealed class Class22 : Class19
	{
		private short short_0;

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool flag = (class19_0.vmethod_3() & 8) != 0;
			int num2 = 0;
			if (num > 32767L || (!flag && (short)num < short.MinValue))
			{
				num2 |= 1;
			}
			class19_0 = new Class22((short)num);
			class19_0.vmethod_12(num2);
			return class19_0;
		}

		public override Type vmethod_1()
		{
			return typeof(short);
		}

		public override void vmethod_0(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override short vmethod_24()
		{
			return short_0;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)short_0;
		}

		public override object vmethod_10()
		{
			return short_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class22(short_0);
		}

		public override byte vmethod_15()
		{
			return (byte)short_0;
		}

		public override ushort vmethod_14()
		{
			return (ushort)short_0;
		}

		public override uint vmethod_9()
		{
			return (uint)short_0;
		}

		public override int vmethod_2()
		{
			return short_0;
		}

		public Class22(short short_1)
		{
			short_0 = short_1;
		}
	}

	private sealed class Class36 : Class33
	{
		private Class19 class19_0;

		public override void vmethod_0(object object_0)
		{
			class19_0.vmethod_0(object_0);
		}

		public override Class19 vmethod_25()
		{
			return new Class36(class19_0);
		}

		public override Type vmethod_1()
		{
			return class19_0.vmethod_1();
		}

		public override object vmethod_10()
		{
			return class19_0.vmethod_10();
		}

		public override void vmethod_23(FieldInfo fieldInfo_0, object object_0)
		{
			class19_0.vmethod_23(fieldInfo_0, object_0);
		}

		public override bool vmethod_21()
		{
			return class19_0 != null;
		}

		public Class36(Class19 class19_1)
		{
			class19_0 = class19_1;
		}
	}

	private sealed class Class29 : Class26
	{
		private Class19 class19_0;

		public override object vmethod_10()
		{
			object result = class19_0.vmethod_10();
			Thread.MemoryBarrier();
			return result;
		}

		public override int vmethod_2()
		{
			int result = class19_0.vmethod_2();
			Thread.MemoryBarrier();
			return result;
		}

		public override Type vmethod_1()
		{
			return class19_0.vmethod_1();
		}

		public override void vmethod_23(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			class19_0.vmethod_23(fieldInfo_0, object_0);
		}

		public override TypeCode vmethod_18()
		{
			return class19_0.vmethod_18();
		}

		public override void vmethod_0(object object_0)
		{
			Thread.MemoryBarrier();
			class19_0.vmethod_0(object_0);
		}

		public override bool vmethod_21()
		{
			bool result = class19_0.vmethod_21();
			Thread.MemoryBarrier();
			return result;
		}

		public override uint vmethod_9()
		{
			uint result = class19_0.vmethod_9();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_20()
		{
			return class19_0.vmethod_20();
		}

		public override long vmethod_13()
		{
			long result = class19_0.vmethod_13();
			Thread.MemoryBarrier();
			return result;
		}

		public override byte vmethod_15()
		{
			byte result = class19_0.vmethod_15();
			Thread.MemoryBarrier();
			return result;
		}

		public override double vmethod_7()
		{
			double result = class19_0.vmethod_7();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class26 vmethod_11()
		{
			return this;
		}

		public override sbyte vmethod_17()
		{
			sbyte result = class19_0.vmethod_17();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class19 vmethod_25()
		{
			throw new InvalidOperationException();
		}

		public override short vmethod_24()
		{
			short result = class19_0.vmethod_24();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong vmethod_22()
		{
			ulong result = class19_0.vmethod_22();
			Thread.MemoryBarrier();
			return result;
		}

		public override float vmethod_8()
		{
			float result = class19_0.vmethod_8();
			Thread.MemoryBarrier();
			return result;
		}

		public override ushort vmethod_14()
		{
			ushort result = class19_0.vmethod_14();
			Thread.MemoryBarrier();
			return result;
		}

		public Class29(Class19 class19_1)
		{
			class19_0 = class19_1;
		}
	}

	private abstract class Class13
	{
		public abstract void vmethod_0(int int_0);

		public abstract int vmethod_1();
	}

	private sealed class Class14 : Class13
	{
		private Stack<int> stack_0 = new Stack<int>();

		private List<Class18> list_0 = new List<Class18>();

		public Class18 method_0()
		{
			return list_0[stack_0.Pop()];
		}

		public override int vmethod_1()
		{
			return 0;
		}

		public Class18 method_1()
		{
			return list_0[stack_0.Peek()];
		}

		public int method_2()
		{
			return stack_0.Count;
		}

		public override void vmethod_0(int int_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].method_0() == int_0)
				{
					stack_0.Push(i);
				}
			}
		}

		public void method_3(int int_0, int int_1, byte byte_0, int int_2, int int_3)
		{
			Class18 @class = null;
			for (int i = 0; i < list_0.Count; i++)
			{
				Class18 class2 = list_0[i];
				if (class2.method_0() == int_0 && class2.method_2() == int_1)
				{
					@class = class2;
					break;
				}
			}
			if (@class == null)
			{
				bool flag = false;
				@class = new Class18(int_0, int_1);
				for (int j = 0; j < list_0.Count; j += -99824826)
				{
					Class18 class18_ = list_0[j];
					if (@class.method_1(class18_) < 0)
					{
						list_0.Insert(j, @class);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list_0.Add(@class);
				}
			}
			@class.method_3(byte_0, int_2, int_3);
		}
	}

	private sealed class Class23 : Class19
	{
		private ulong ulong_0;

		public override sbyte vmethod_17()
		{
			return (sbyte)ulong_0;
		}

		public override Class26 vmethod_11()
		{
			return new Class44(vmethod_13());
		}

		public override void vmethod_0(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class19 vmethod_25()
		{
			return new Class23(ulong_0);
		}

		public override uint vmethod_9()
		{
			return (uint)ulong_0;
		}

		public override short vmethod_24()
		{
			return (short)ulong_0;
		}

		public override Type vmethod_1()
		{
			return typeof(ulong);
		}

		public override ulong vmethod_22()
		{
			return ulong_0;
		}

		public override long vmethod_13()
		{
			return (long)ulong_0;
		}

		public override byte vmethod_15()
		{
			return (byte)ulong_0;
		}

		public override object vmethod_10()
		{
			return ulong_0;
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool num2 = (class19_0.vmethod_3() & 8) != 0;
			int num3 = 0;
			if (!num2 && num > long.MaxValue)
			{
				num3 |= 1;
			}
			class19_0 = new Class23(num);
			class19_0.vmethod_12(num3);
			return class19_0;
		}

		public override ushort vmethod_14()
		{
			return (ushort)ulong_0;
		}

		public override int vmethod_2()
		{
			return (int)ulong_0;
		}

		public Class23(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}
	}

	private sealed class Class24 : Class19
	{
		private byte byte_0;

		public override byte vmethod_15()
		{
			return byte_0;
		}

		public override int vmethod_2()
		{
			return byte_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class24(byte_0);
		}

		public override object vmethod_10()
		{
			return byte_0;
		}

		public override uint vmethod_9()
		{
			return byte_0;
		}

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)byte_0;
		}

		public override void vmethod_0(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override ushort vmethod_14()
		{
			return byte_0;
		}

		public override short vmethod_24()
		{
			return byte_0;
		}

		public override Type vmethod_1()
		{
			return typeof(byte);
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool num2 = (class19_0.vmethod_3() & 8) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 255L)
				{
					num3 |= 1;
				}
			}
			else if (num > 1523267359L)
			{
				num3 |= 0x1D047520;
			}
			class19_0 = new Class24((byte)num);
			class19_0.vmethod_12(num3);
			return class19_0;
		}

		public Class24(byte byte_1)
		{
			byte_0 = byte_1;
		}
	}

	private sealed class Class25 : Class19
	{
		private bool bool_0;

		public override Class19 vmethod_25()
		{
			return new Class25(bool_0);
		}

		public override object vmethod_10()
		{
			return bool_0;
		}

		public override void vmethod_0(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override int vmethod_2()
		{
			if (!bool_0)
			{
				return 0;
			}
			return -1052768123;
		}

		public override Type vmethod_1()
		{
			return typeof(bool);
		}

		public Class25(bool bool_1)
		{
			bool_0 = bool_1;
		}
	}

	private sealed class Class37 : Class33
	{
		private object object_0;

		private FieldInfo fieldInfo_0;

		public override Class19 vmethod_25()
		{
			return new Class37(fieldInfo_0, object_0);
		}

		public override Type vmethod_1()
		{
			return typeof(int);
		}

		public override void vmethod_0(object object_1)
		{
			((Class13)fieldInfo_0.GetValue(object_0)).vmethod_0((int)object_1);
		}

		public override object vmethod_10()
		{
			return ((Class13)fieldInfo_0.GetValue(object_0)).vmethod_1();
		}

		public Class37(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}
	}

	private sealed class Class30 : Class26
	{
		private Class19 class19_0;

		private Enum enum_0;

		public override long vmethod_13()
		{
			return class19_0.vmethod_13();
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr((IntPtr.Size == 4) ? vmethod_2() : vmethod_13());
		}

		public override TypeCode vmethod_18()
		{
			return class19_0.vmethod_18();
		}

		private static Class19 smethod_3(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			default:
				throw new InvalidOperationException();
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new Class41(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new Class41((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new Class44(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new Class44((long)Convert.ToUInt64(enum_1));
			}
		}

		public override double vmethod_7()
		{
			return class19_0.vmethod_7();
		}

		public override Class19 vmethod_5()
		{
			return class19_0.vmethod_5();
		}

		public override object vmethod_10()
		{
			return enum_0;
		}

		public override sbyte vmethod_17()
		{
			return class19_0.vmethod_17();
		}

		public override ushort vmethod_14()
		{
			return class19_0.vmethod_14();
		}

		public override Type vmethod_1()
		{
			return enum_0.GetType();
		}

		public override uint vmethod_9()
		{
			return class19_0.vmethod_9();
		}

		public override ulong vmethod_22()
		{
			return class19_0.vmethod_22();
		}

		public override int vmethod_2()
		{
			return class19_0.vmethod_2();
		}

		public override byte vmethod_15()
		{
			return class19_0.vmethod_15();
		}

		public override float vmethod_8()
		{
			return class19_0.vmethod_8();
		}

		public override short vmethod_24()
		{
			return class19_0.vmethod_24();
		}

		public override Class19 vmethod_25()
		{
			return new Class30(enum_0);
		}

		public override UIntPtr vmethod_6()
		{
			return new UIntPtr((IntPtr.Size == 4) ? vmethod_9() : vmethod_22());
		}

		public override void vmethod_0(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = (Enum)object_0;
			class19_0 = smethod_3(enum_0);
		}

		public Class30(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			enum_0 = enum_1;
			class19_0 = smethod_3(enum_0);
		}
	}

	private static class Class17
	{
		public static int smethod_0(IntPtr intptr_0, uint uint_0)
		{
			return (int)GClass8.smethod_0(intptr_0, uint_0);
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}

		public static IntPtr smethod_2(uint uint_0)
		{
			return Class49.smethod_1(uint_0);
		}

		public unsafe static object smethod_3(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}
	}

	private sealed class Class15 : Class13
	{
		private int int_0;

		private List<Class19> list_0 = new List<Class19>();

		public Class19 method_0()
		{
			int index = list_0.Count - 1;
			return list_0[index];
		}

		public Class19 method_1(int int_1, Class19 class19_0)
		{
			if (int_1 < 0)
			{
				int_1 += list_0.Count - 1;
			}
			return list_0[int_1] = class19_0;
		}

		public Class19 method_2()
		{
			int index = list_0.Count - 1;
			Class19 result = list_0[index];
			list_0.RemoveAt(index);
			return result;
		}

		public override void vmethod_0(int int_1)
		{
			int_0 = int_1;
			for (int i = 0; i < int_0; i++)
			{
				list_0.Insert(0, null);
			}
		}

		public void method_3()
		{
			while (list_0.Count > int_0)
			{
				list_0.RemoveAt(int_0);
			}
		}

		public Class19 method_4(int int_1)
		{
			if (int_1 < 0)
			{
				int_1 += list_0.Count - 1;
			}
			return list_0[int_1];
		}

		public void method_5(Class19 class19_0)
		{
			list_0.Add(class19_0.vmethod_11());
		}

		public override int vmethod_1()
		{
			return list_0.Count;
		}
	}

	private sealed class Class31 : Class26
	{
		private double double_0;

		public override bool vmethod_21()
		{
			return Convert.ToBoolean(double_0);
		}

		public override char vmethod_16()
		{
			return (char)double_0;
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			double num = class19_0.vmethod_7();
			ulong num2 = (ulong)(long)num;
			int num3 = 0;
			if (((uint)class19_0.vmethod_3() & 8u) != 0)
			{
				if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
				{
					num3 |= 1;
				}
				if (!((double)num2 < 9.223372036854776E+18))
				{
					num2 = (ulong)((double)(long)num2 - 9.223372036854776E+18) + 9223372036854775808uL;
				}
			}
			else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
			{
				num3 |= 1;
			}
			class19_0 = new Class44((long)num2);
			class19_0.vmethod_12(num3);
			return class19_0;
		}

		public override int vmethod_2()
		{
			return (int)double_0;
		}

		public override object vmethod_10()
		{
			return double_0;
		}

		public static Class19 smethod_4(Class19 class19_0)
		{
			return new Class31(class19_0.vmethod_7());
		}

		public override ushort vmethod_14()
		{
			return (ushort)double_0;
		}

		public override byte vmethod_15()
		{
			return (byte)double_0;
		}

		public override uint vmethod_9()
		{
			return (uint)double_0;
		}

		public override IntPtr vmethod_4()
		{
			if (IntPtr.Size != 4)
			{
			}
			return new IntPtr((long)double_0);
		}

		public override TypeCode vmethod_18()
		{
			return TypeCode.Double;
		}

		public static Class19 smethod_5(Class19 class19_0, Class19 class19_1)
		{
			double num = class19_0.vmethod_7();
			double num2 = class19_1.vmethod_7();
			return new Class31(num + num2);
		}

		public override Type vmethod_1()
		{
			return typeof(double);
		}

		public override ulong vmethod_22()
		{
			return (ulong)double_0;
		}

		public static Class19 smethod_6(Class19 class19_0, Class19 class19_1)
		{
			double num = class19_0.vmethod_7();
			double num2 = class19_1.vmethod_7();
			return new Class31(num * num2);
		}

		public static Class19 smethod_7(Class19 class19_0, Class19 class19_1)
		{
			double num = class19_0.vmethod_7();
			double num2 = class19_1.vmethod_7();
			return new Class31(num % num2);
		}

		public override double vmethod_7()
		{
			return double_0;
		}

		public static Class19 smethod_8(Class19 class19_0, Class19 class19_1)
		{
			double num = class19_0.vmethod_7();
			double num2 = class19_1.vmethod_7();
			return new Class31(num / num2);
		}

		public static Class19 smethod_9(Class19 class19_0)
		{
			return new Class31(0.0 - class19_0.vmethod_7());
		}

		public override Class19 vmethod_25()
		{
			return new Class31(double_0);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)double_0;
		}

		public static Class19 smethod_10(Class19 class19_0, Class19 class19_1)
		{
			double num;
			double num2;
			int num3;
			do
			{
				num = class19_0.vmethod_7();
				num2 = class19_1.vmethod_7();
				num3 = 0;
			}
			while (num != num2);
			num3 |= 0x40;
			return new Class41(num3);
		}

		public override UIntPtr vmethod_6()
		{
			if (IntPtr.Size != 4)
			{
			}
			return new UIntPtr((ulong)double_0);
		}

		public override short vmethod_24()
		{
			return (short)double_0;
		}

		public override long vmethod_13()
		{
			return (long)double_0;
		}

		public static Class19 smethod_11(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			return new Class31((((uint)class19_0.vmethod_3() & 8u) != 0) ? ((double)num) : ((double)(long)num));
		}

		public override void vmethod_0(object object_0)
		{
			double_0 = (double)object_0;
		}

		public override float vmethod_8()
		{
			return (float)double_0;
		}

		public Class31(double double_1)
		{
			double_0 = double_1;
		}
	}

	private sealed class Class38 : Class33
	{
		private int int_1;

		private Array array_0;

		public override void vmethod_23(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_10();
			fieldInfo_0.SetValue(obj, object_0);
			if (obj is ValueType)
			{
				vmethod_0(obj);
			}
		}

		public override void vmethod_0(object object_0)
		{
			switch (Type.GetTypeCode(array_0.GetType().GetElementType()))
			{
			case TypeCode.Char:
				object_0 = Convert.ToChar(object_0);
				break;
			case TypeCode.SByte:
				object_0 = Convert.ToSByte(object_0);
				break;
			case TypeCode.Byte:
				object_0 = Convert.ToByte(object_0);
				break;
			case TypeCode.Int16:
				object_0 = Convert.ToInt16(object_0);
				break;
			case TypeCode.UInt16:
				object_0 = Convert.ToUInt16(object_0);
				break;
			case TypeCode.Int32:
				object_0 = Convert.ToInt32(object_0);
				break;
			case TypeCode.UInt32:
				object_0 = Convert.ToUInt32(object_0);
				break;
			case TypeCode.Int64:
				object_0 = Convert.ToInt64(object_0);
				break;
			case TypeCode.UInt64:
				object_0 = Convert.ToUInt64(object_0);
				break;
			}
			array_0.SetValue(object_0, int_1);
		}

		public override object vmethod_10()
		{
			return array_0.GetValue(int_1);
		}

		public override Type vmethod_1()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class19 vmethod_25()
		{
			return new Class38(array_0, int_1);
		}

		public Class38(Array array_1, int int_2)
		{
			array_0 = array_1;
			int_1 = int_2;
		}
	}

	private sealed class Class18
	{
		private List<Class48> list_0 = new List<Class48>();

		private int int_0;

		private int int_1;

		public int method_0()
		{
			return int_1;
		}

		public int method_1(Class18 class18_0)
		{
			if (class18_0 == null)
			{
				return 1;
			}
			int num = int_1.CompareTo(class18_0.method_0());
			if (num == 0)
			{
				num = class18_0.method_2().CompareTo(int_0);
			}
			return num;
		}

		public int method_2()
		{
			return int_0;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class48(byte_0, int_2, int_3));
		}

		public List<Class48> method_4()
		{
			return list_0;
		}

		public Class18(int int_2, int int_3)
		{
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	internal delegate void Delegate1();

	private sealed class Class16 : Class13
	{
		private uint uint_0;

		private Stack<int> stack_0 = new Stack<int>();

		private uint uint_1;

		public void method_0()
		{
			stack_0.Clear();
			uint_1 = 0u;
			uint_0 = 0u;
		}

		public unsafe byte method_1()
		{
			byte b = *(byte*)(void*)Class49.smethod_1(uint_0);
			uint_0++;
			b = (byte)(b ^ uint_1);
			b = (byte)(~(((uint)(b << 1) | ((uint)b >> 7)) - 1) - 249);
			uint_1 ^= b;
			return b;
		}

		public void method_2(int int_0)
		{
			stack_0.Push(int_0);
		}

		public unsafe long method_3()
		{
			long result = *(long*)(void*)Class49.smethod_1(uint_0);
			uint_0 += 8u;
			return result;
		}

		public void method_4()
		{
			vmethod_0(stack_0.Pop());
		}

		public double method_5()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_3()), 0);
		}

		public override void vmethod_0(int int_0)
		{
			uint_0 = (uint)int_0;
			uint_1 = uint_0;
		}

		public unsafe int method_6()
		{
			uint num = *(uint*)(void*)Class49.smethod_1(uint_0);
			uint_0 += 4u;
			num ^= uint_1;
			num = (((num & 0xFF000000u) >> 24) | ((num & 0xFF0000) >> 8) | ((num & 0xFF00) << 8) | ((num & 0xFF) << 24)) + 1;
			num = ((num << 1) | (num >> 31)) + 1;
			uint_1 ^= num;
			return (int)num;
		}

		public unsafe byte method_7()
		{
			byte b = *(byte*)(void*)Class49.smethod_1(uint_0);
			uint_0++;
			b = (byte)(b ^ uint_1);
			b -= 153;
			b = (byte)(0 - (((uint)(b << 1) | ((uint)b >> 7)) - 249));
			uint_1 ^= b;
			return b;
		}

		public int method_8()
		{
			return stack_0.Count;
		}

		public float method_9()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(method_6()), 0);
		}

		public unsafe short method_10()
		{
			ushort num = *(ushort*)(void*)Class49.smethod_1(uint_0);
			uint_0 += 2u;
			num = (ushort)(num ^ uint_1);
			num = (ushort)((~num ^ 0x6294) + 9371);
			num = (ushort)(((uint)num >> 1) | (uint)(num << 15));
			uint_1 ^= num;
			return (short)num;
		}

		public override int vmethod_1()
		{
			return (int)uint_0;
		}
	}

	private abstract class Class19
	{
		private int int_0;

		public abstract void vmethod_0(object object_0);

		public virtual Type vmethod_1()
		{
			throw new InvalidOperationException();
		}

		public static Class19 smethod_0(Class19 class19_0, Type type_0)
		{
			object obj = class19_0.vmethod_10();
			int num = 0;
			if (obj == null)
			{
				num |= 0x40;
			}
			else
			{
				Type type = obj.GetType();
				if (type == type_0 || type_0.IsAssignableFrom(type))
				{
					num |= 0x40;
				}
			}
			return new Class41(num);
		}

		public virtual int vmethod_2()
		{
			return Convert.ToInt32(vmethod_10());
		}

		public virtual int vmethod_3()
		{
			return int_0;
		}

		public virtual IntPtr vmethod_4()
		{
			object obj = vmethod_10();
			if (!(obj?.GetType() == typeof(IntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (IntPtr)obj;
		}

		public override string ToString()
		{
			object obj = vmethod_10();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		public virtual Class19 vmethod_5()
		{
			return this;
		}

		public static Class19 smethod_1(Class19 class19_0)
		{
			int num = 0;
			if (((uint)class19_0.vmethod_3() & 8u) != 0)
			{
				float f = class19_0.vmethod_8();
				if (float.IsNaN(f) || float.IsInfinity(f))
				{
					num |= 1;
				}
			}
			else
			{
				double d = class19_0.vmethod_7();
				if (double.IsNaN(d) || double.IsInfinity(d))
				{
					num |= -692437007;
				}
			}
			return new Class41(num);
		}

		public virtual UIntPtr vmethod_6()
		{
			object obj = vmethod_10();
			if (!(obj?.GetType() == typeof(UIntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		public virtual double vmethod_7()
		{
			return Convert.ToDouble(vmethod_10());
		}

		public virtual float vmethod_8()
		{
			return Convert.ToSingle(vmethod_10());
		}

		public virtual uint vmethod_9()
		{
			return Convert.ToUInt32(vmethod_10());
		}

		public abstract object vmethod_10();

		public Class19 method_0(Type type_0)
		{
			object obj = default(object);
			if (type_0.IsEnum)
			{
				obj = vmethod_10();
				if (obj == null)
				{
					goto IL_00c5;
				}
			}
			else
			{
				switch (Type.GetTypeCode(type_0))
				{
				case (TypeCode)7813:
					return new Class25(vmethod_21());
				case (TypeCode)7814:
					return new Class20(vmethod_16());
				case (TypeCode)7815:
					return new Class47(vmethod_17());
				case (TypeCode)7816:
					return new Class24(vmethod_15());
				case (TypeCode)7817:
					return new Class22(vmethod_24());
				case (TypeCode)7818:
					return new Class21(vmethod_14());
				case (TypeCode)7819:
					return new Class41(vmethod_2());
				case (TypeCode)7820:
					return new Class46(vmethod_9());
				case (TypeCode)7821:
					return new Class44(vmethod_13());
				case (TypeCode)7822:
					return new Class23(vmethod_22());
				case (TypeCode)7823:
					return new Class27(vmethod_8());
				case (TypeCode)7824:
					return new Class31(vmethod_7());
				}
				if (type_0 == typeof(IntPtr))
				{
					return new Class43(vmethod_4());
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new Class42(vmethod_6());
				}
				if (type_0.IsValueType)
				{
					return new Class45(vmethod_10());
				}
				if (!type_0.IsPointer)
				{
					return new Class40(vmethod_10());
				}
			}
			if (!(obj is Enum))
			{
				obj = Enum.ToObject(type_0, obj);
			}
			goto IL_00c5;
			IL_00c5:
			return new Class30((Enum)obj);
		}

		public virtual Class26 vmethod_11()
		{
			throw new InvalidOperationException();
		}

		public virtual void vmethod_12(int int_1)
		{
			int_0 = int_1;
		}

		public virtual long vmethod_13()
		{
			return Convert.ToInt64(vmethod_10());
		}

		public virtual ushort vmethod_14()
		{
			return Convert.ToUInt16(vmethod_10());
		}

		public virtual byte vmethod_15()
		{
			return Convert.ToByte(vmethod_10());
		}

		public virtual char vmethod_16()
		{
			return Convert.ToChar(vmethod_10());
		}

		public virtual sbyte vmethod_17()
		{
			return Convert.ToSByte(vmethod_10());
		}

		public virtual TypeCode vmethod_18()
		{
			throw new InvalidOperationException();
		}

		public unsafe virtual void* vmethod_19()
		{
			throw new InvalidOperationException();
		}

		public virtual bool vmethod_20()
		{
			return false;
		}

		public static Class19 smethod_2(object object_0, Type type_0)
		{
			while (true)
			{
				if (!type_0.IsEnum)
				{
					switch (Type.GetTypeCode(type_0))
					{
					case (TypeCode)(-218418109):
					case (TypeCode)(-218418102):
						continue;
					case (TypeCode)(-218418113):
						return new Class25(Convert.ToBoolean(object_0));
					case (TypeCode)(-218418112):
						return new Class20(Convert.ToChar(object_0));
					case (TypeCode)(-218418111):
						return new Class47(Convert.ToSByte(object_0));
					case (TypeCode)(-218418110):
						return new Class24(Convert.ToByte(object_0));
					case (TypeCode)(-218418108):
						return new Class21(Convert.ToUInt16(object_0));
					case (TypeCode)(-218418107):
						return new Class41(Convert.ToInt32(object_0));
					case (TypeCode)(-218418106):
						return new Class46(Convert.ToUInt32(object_0));
					case (TypeCode)(-218418105):
						return new Class44(Convert.ToInt64(object_0));
					case (TypeCode)(-218418104):
						return new Class23(Convert.ToUInt64(object_0));
					case (TypeCode)(-218418103):
						return new Class27(Convert.ToSingle(object_0));
					}
					if (type_0 == typeof(IntPtr))
					{
						return new Class43((object_0 != null) ? ((IntPtr)object_0) : IntPtr.Zero);
					}
					if (!(type_0 == typeof(UIntPtr)) && type_0.IsValueType)
					{
						break;
					}
				}
				if (object_0 != null && !(object_0 is Enum))
				{
					object_0 = Enum.ToObject(type_0, object_0);
				}
				return new Class30((Enum)object_0);
			}
			return new Class45(object_0);
		}

		public virtual bool vmethod_21()
		{
			return Convert.ToBoolean(vmethod_10());
		}

		public virtual ulong vmethod_22()
		{
			return Convert.ToUInt64(vmethod_10());
		}

		public virtual void vmethod_23(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = vmethod_10();
			fieldInfo_0.SetValue(obj, object_0);
		}

		public virtual short vmethod_24()
		{
			return Convert.ToInt16(vmethod_10());
		}

		public abstract Class19 vmethod_25();
	}

	private sealed class Class32 : Class26
	{
		private MethodBase methodBase_0;

		public override void vmethod_0(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override object vmethod_10()
		{
			return methodBase_0;
		}

		public override Type vmethod_1()
		{
			return typeof(MethodBase);
		}

		public override Class19 vmethod_25()
		{
			return new Class32(methodBase_0);
		}

		public override IntPtr vmethod_4()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}

		public override bool vmethod_21()
		{
			return methodBase_0 != null;
		}

		public Class32(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}
	}

	private abstract class Class26 : Class19
	{
		public override TypeCode vmethod_18()
		{
			return TypeCode.Empty;
		}

		public override Class26 vmethod_11()
		{
			return this;
		}
	}

	private abstract class Class33 : Class26
	{
		public override bool vmethod_20()
		{
			return true;
		}
	}

	private sealed class Class40 : Class26
	{
		private object object_0;

		public override Type vmethod_1()
		{
			return typeof(object);
		}

		public static Class19 smethod_3(Class19 class19_0, Class19 class19_1)
		{
			object obj = class19_0.vmethod_10();
			object obj2 = class19_1.vmethod_10();
			int num = 0;
			if (obj == obj2)
			{
				num |= 0x40;
			}
			else if (obj == null)
			{
				num |= -1355953714;
			}
			return new Class41(num);
		}

		public override void vmethod_0(object object_1)
		{
			object_0 = object_1;
		}

		public override Class19 vmethod_25()
		{
			return new Class40(object_0);
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public override TypeCode vmethod_18()
		{
			return TypeCode.Object;
		}

		public override bool vmethod_21()
		{
			return object_0 != null;
		}

		public Class40(object object_1)
		{
			object_0 = object_1;
		}
	}

	private sealed class Class48
	{
		private int int_0;

		private int int_1;

		private byte byte_0;

		public int method_0()
		{
			return int_0;
		}

		public byte method_1()
		{
			return byte_0;
		}

		public int method_2()
		{
			return int_1;
		}

		public Class48(byte byte_1, int int_2, int int_3)
		{
			byte_0 = byte_1;
			int_1 = int_2;
			int_0 = int_3;
		}
	}

	private sealed class Class46 : Class19
	{
		private uint uint_0;

		public override uint vmethod_9()
		{
			return uint_0;
		}

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override void vmethod_0(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override int vmethod_2()
		{
			return (int)uint_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class46(uint_0);
		}

		public override ushort vmethod_14()
		{
			return (ushort)uint_0;
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool num2 = (class19_0.vmethod_3() & 8) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 4294967295L)
				{
					num3 |= 1;
				}
			}
			else if (num > 677450482L)
			{
				num3 |= 0x579EED0C;
			}
			class19_0 = new Class46((uint)num);
			class19_0.vmethod_12(num3);
			return class19_0;
		}

		public override object vmethod_10()
		{
			return uint_0;
		}

		public override short vmethod_24()
		{
			return (short)uint_0;
		}

		public override Type vmethod_1()
		{
			return typeof(uint);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_15()
		{
			return (byte)uint_0;
		}

		public Class46(uint uint_1)
		{
			uint_0 = uint_1;
		}
	}

	private enum Enum2
	{
		const_0 = 10,
		const_1 = 15,
		const_2 = 32,
		const_3 = 6,
		const_4 = 8,
		const_5 = 9,
		const_6 = 4,
		const_7 = 2,
		const_8 = 3,
		const_9 = 5,
		const_10 = 11,
		const_11 = 64,
		const_12 = 16,
		const_13 = 0,
		const_14 = 7,
		const_15 = 1
	}

	private sealed class Class41 : Class26
	{
		private int int_1;

		public static Class19 smethod_3(Class19 class19_0, Class19 class19_1)
		{
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				uint num = class19_0.vmethod_9();
				int num2 = class19_1.vmethod_2();
				return new Class41((int)(num >> num2));
			}
			int num3 = class19_0.vmethod_2();
			int num4 = class19_1.vmethod_2();
			return new Class41(num3 >> (num4 & 0x43F));
		}

		public static Class19 smethod_4(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool flag = (class19_0.vmethod_3() & 8) != 0;
			int num2 = 0;
			if (num <= 2147483647L)
			{
				if (flag)
				{
				}
			}
			else
			{
				num2 |= 1;
			}
			class19_0 = new Class41((int)num);
			class19_0.vmethod_12(num2);
			return class19_0;
		}

		public override float vmethod_8()
		{
			return int_1;
		}

		public static Class19 smethod_5(Class19 class19_0, Class19 class19_1)
		{
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				uint num = class19_0.vmethod_9();
				uint num2 = class19_1.vmethod_9();
				return new Class41((int)(num / num2));
			}
			int num3 = class19_0.vmethod_2();
			int num4 = class19_1.vmethod_2();
			return new Class41(num3 / num4);
		}

		public static Class19 smethod_6(Class19 class19_0, Class19 class19_1)
		{
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				uint num = class19_0.vmethod_9();
				uint num2 = class19_1.vmethod_9();
				return new Class41((int)(num % num2));
			}
			int num3 = class19_0.vmethod_2();
			int num4 = class19_1.vmethod_2();
			return new Class41(num3 % num4);
		}

		public override bool vmethod_21()
		{
			return int_1 != 0;
		}

		public override object vmethod_10()
		{
			return int_1;
		}

		public override Class19 vmethod_5()
		{
			return new Class46((uint)int_1);
		}

		public override short vmethod_24()
		{
			return (short)int_1;
		}

		public override ulong vmethod_22()
		{
			return (uint)int_1;
		}

		public static Class19 smethod_7(Class19 class19_0, Class19 class19_1)
		{
			uint num = ~class19_0.vmethod_9();
			_ = ~class19_1.vmethod_9();
			uint num2 = num & 0xFFFFFFFFu;
			Class41 @class = new Class41((int)num2);
			int num3 = 0;
			if (num2 == 0)
			{
				num3 |= 0x40;
			}
			else if (num2 >> 874459250 != 0)
			{
				num3 |= 6;
			}
			@class.vmethod_12(num3);
			return @class;
		}

		public override Type vmethod_1()
		{
			return typeof(int);
		}

		public override UIntPtr vmethod_6()
		{
			return new UIntPtr((uint)int_1);
		}

		public static Class19 smethod_8(Class19 class19_0, Class19 class19_1)
		{
			uint num = class19_0.vmethod_9();
			uint num2 = class19_1.vmethod_9();
			ulong num3 = num * num2;
			uint num4 = (uint)num3;
			Class41 @class = new Class41((int)num4);
			int num5 = 0;
			if (((num ^ num4) & (num2 ^ num4) & 0x80000000u) != 0)
			{
				num5 |= 1;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num4))) & 0x80000000u) != 0)
			{
				num5 |= 2;
			}
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				if ((num3 & 0xFFFFFFFFL) != 0L)
				{
					num5 |= 2;
				}
			}
			else
			{
				num3 = (ulong)(int)(num * num2);
				if (num3 >> 262319 != num4 >> 742250495)
				{
					num5 |= -335685631;
				}
			}
			@class.vmethod_12(num5);
			return @class;
		}

		public override Class19 vmethod_25()
		{
			Class41 @class = new Class41(int_1);
			@class.vmethod_12(vmethod_3());
			return @class;
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)int_1;
		}

		public static Class19 smethod_9(Class19 class19_0, Class19 class19_1)
		{
			uint num = ~class19_0.vmethod_9();
			uint num2 = ~class19_1.vmethod_9();
			_ = num | num2;
			Class41 @class = new Class41(-1);
			int num3 = 0;
			if (uint.MaxValue >> 443102741 != 0)
			{
				num3 |= 0x20871A04;
			}
			@class.vmethod_12(num3);
			return @class;
		}

		public override int vmethod_2()
		{
			return int_1;
		}

		public override void vmethod_0(object object_0)
		{
			int_1 = Convert.ToInt32(object_0);
		}

		public override char vmethod_16()
		{
			return (char)int_1;
		}

		public static Class19 smethod_10(Class19 class19_0, Class19 class19_1)
		{
			int num = class19_0.vmethod_2();
			int num2 = class19_1.vmethod_2();
			return new Class41(num << num2);
		}

		public static Class19 smethod_11(Class19 class19_0, Class19 class19_1)
		{
			uint num = class19_0.vmethod_9();
			uint num2 = class19_1.vmethod_9();
			_ = num + num2;
			Class41 @class = new Class41(0);
			int num3 = 0;
			uint num4 = 2147483648u;
			if (((num ^ (false ? 1u : 0u)) & (num2 ^ (false ? 1u : 0u)) & 0x80000000u) != 0)
			{
				num3 |= 1;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ (false ? 1u : 0u)))) & num4) != 0)
			{
				num3 |= 2;
			}
			@class.vmethod_12(num3);
			return @class;
		}

		public override long vmethod_13()
		{
			return int_1;
		}

		public override double vmethod_7()
		{
			return int_1;
		}

		public override byte vmethod_15()
		{
			return (byte)int_1;
		}

		public override TypeCode vmethod_18()
		{
			return TypeCode.Int32;
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr(int_1);
		}

		public override ushort vmethod_14()
		{
			return (ushort)int_1;
		}

		public static Class19 smethod_12(Class19 class19_0, Class19 class19_1)
		{
			int num = 0;
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				uint num2 = class19_0.vmethod_9();
				uint num3 = class19_1.vmethod_9();
				if (num2 == num3)
				{
					num |= 0x40;
				}
				else if (num2 < num3)
				{
					num |= 0x3FF800D;
				}
			}
			else
			{
				int num4 = class19_0.vmethod_2();
				int num5 = class19_1.vmethod_2();
				if (num4 == num5)
				{
					num |= -98306;
				}
				else if (num4 < num5)
				{
					num |= -1915142150;
				}
			}
			return new Class41(num);
		}

		public override uint vmethod_9()
		{
			return (uint)int_1;
		}

		public Class41(int int_2)
		{
			int_1 = int_2;
		}
	}

	private sealed class Class42 : Class26
	{
		private Class19 class19_0;

		private UIntPtr uintptr_0;

		public override object vmethod_10()
		{
			return uintptr_0;
		}

		public override short vmethod_24()
		{
			return class19_0.vmethod_24();
		}

		public override sbyte vmethod_17()
		{
			return class19_0.vmethod_17();
		}

		public static Class19 smethod_3(Class19 class19_1)
		{
			ulong num = class19_1.vmethod_22();
			bool flag = (class19_1.vmethod_3() & 8) != 0;
			int num2 = 0;
			if (IntPtr.Size == 4)
			{
				if (!flag && num > 2147483647L)
				{
					num2 |= 1;
				}
			}
			else if (!flag && num > long.MaxValue)
			{
				num2 |= 0x1000001;
			}
			class19_1 = new Class42(new UIntPtr(num));
			class19_1.vmethod_12(num2);
			return class19_1;
		}

		public override double vmethod_7()
		{
			return class19_0.vmethod_7();
		}

		public override byte vmethod_15()
		{
			return class19_0.vmethod_15();
		}

		public override uint vmethod_9()
		{
			return class19_0.vmethod_9();
		}

		private static Class19 smethod_4(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class41((int)uintptr_1.ToUInt32());
			}
			return new Class44((long)uintptr_1.ToUInt64());
		}

		public override Class19 vmethod_25()
		{
			return new Class42(uintptr_0);
		}

		public override TypeCode vmethod_18()
		{
			return class19_0.vmethod_18();
		}

		public override UIntPtr vmethod_6()
		{
			return uintptr_0;
		}

		public override bool vmethod_21()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override IntPtr vmethod_4()
		{
			return class19_0.vmethod_4();
		}

		public override long vmethod_13()
		{
			return class19_0.vmethod_13();
		}

		public override int vmethod_2()
		{
			return class19_0.vmethod_2();
		}

		public override ulong vmethod_22()
		{
			return class19_0.vmethod_22();
		}

		public override float vmethod_8()
		{
			return class19_0.vmethod_8();
		}

		public override void vmethod_0(object object_0)
		{
			uintptr_0 = (UIntPtr)object_0;
			class19_0 = smethod_4(uintptr_0);
		}

		public override Type vmethod_1()
		{
			return typeof(UIntPtr);
		}

		public override ushort vmethod_14()
		{
			return class19_0.vmethod_14();
		}

		public unsafe override void* vmethod_19()
		{
			return uintptr_0.ToPointer();
		}

		public Class42(UIntPtr uintptr_1)
		{
			uintptr_0 = uintptr_1;
			class19_0 = smethod_4(uintptr_0);
		}
	}

	private sealed class Class47 : Class19
	{
		private sbyte sbyte_0;

		public override Class26 vmethod_11()
		{
			return new Class41(vmethod_2());
		}

		public override short vmethod_24()
		{
			return sbyte_0;
		}

		public override sbyte vmethod_17()
		{
			return sbyte_0;
		}

		public override byte vmethod_15()
		{
			return (byte)sbyte_0;
		}

		public override Class19 vmethod_25()
		{
			return new Class47(sbyte_0);
		}

		public override int vmethod_2()
		{
			return sbyte_0;
		}

		public override void vmethod_0(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Type vmethod_1()
		{
			return typeof(sbyte);
		}

		public override uint vmethod_9()
		{
			return (uint)sbyte_0;
		}

		public override ushort vmethod_14()
		{
			return (ushort)sbyte_0;
		}

		public static Class19 smethod_3(Class19 class19_0)
		{
			ulong num = class19_0.vmethod_22();
			bool flag = (class19_0.vmethod_3() & 8) != 0;
			int num2 = 0;
			if (num > 127L || (!flag && (sbyte)num < sbyte.MinValue))
			{
				num2 |= 1;
			}
			class19_0 = new Class47((sbyte)num);
			class19_0.vmethod_12(num2);
			return class19_0;
		}

		public override object vmethod_10()
		{
			return sbyte_0;
		}

		public Class47(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}
	}

	private sealed class Class43 : Class26
	{
		private Class19 class19_0;

		private IntPtr intptr_0;

		public unsafe override void* vmethod_19()
		{
			return intptr_0.ToPointer();
		}

		public override Class19 vmethod_25()
		{
			return new Class43(intptr_0);
		}

		public override float vmethod_8()
		{
			return class19_0.vmethod_8();
		}

		public override double vmethod_7()
		{
			return class19_0.vmethod_7();
		}

		public override long vmethod_13()
		{
			return class19_0.vmethod_13();
		}

		public override Type vmethod_1()
		{
			return typeof(IntPtr);
		}

		public override UIntPtr vmethod_6()
		{
			return class19_0.vmethod_6();
		}

		private static Class19 smethod_3(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class41(intptr_1.ToInt32());
			}
			return new Class44(intptr_1.ToInt64());
		}

		public override uint vmethod_9()
		{
			return class19_0.vmethod_9();
		}

		public override bool vmethod_21()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override short vmethod_24()
		{
			return class19_0.vmethod_24();
		}

		public override TypeCode vmethod_18()
		{
			return class19_0.vmethod_18();
		}

		public static Class19 smethod_4(Class19 class19_1)
		{
			ulong num = class19_1.vmethod_22();
			bool flag = (class19_1.vmethod_3() & 8) != 0;
			int num2 = 0;
			if (IntPtr.Size == 4)
			{
				if (num <= 2147483647L)
				{
					if (flag)
					{
					}
				}
				else
				{
					num2 |= 1;
				}
			}
			else if (num <= long.MaxValue)
			{
				if (flag)
				{
				}
			}
			else
			{
				num2 |= 0x1A6EF3F7;
			}
			class19_1 = new Class43(new IntPtr((long)num));
			class19_1.vmethod_12(num2);
			return class19_1;
		}

		public override byte vmethod_15()
		{
			return class19_0.vmethod_15();
		}

		public override ulong vmethod_22()
		{
			return class19_0.vmethod_22();
		}

		public override sbyte vmethod_17()
		{
			return class19_0.vmethod_17();
		}

		public override void vmethod_0(object object_0)
		{
			intptr_0 = (IntPtr)object_0;
			class19_0 = smethod_3(intptr_0);
		}

		public override IntPtr vmethod_4()
		{
			return intptr_0;
		}

		public override object vmethod_10()
		{
			return intptr_0;
		}

		public override ushort vmethod_14()
		{
			return class19_0.vmethod_14();
		}

		public override int vmethod_2()
		{
			return class19_0.vmethod_2();
		}

		public Class43(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class19_0 = smethod_3(intptr_0);
		}
	}

	private sealed class Class39 : Class33
	{
		private Class19 class19_0;

		private Class19 class19_1;

		public override Class19 vmethod_25()
		{
			return new Class39(class19_1, class19_0);
		}

		public override object vmethod_10()
		{
			return class19_1.vmethod_10();
		}

		public override void vmethod_0(object object_0)
		{
			class19_1.vmethod_0(object_0);
			class19_0.vmethod_0(class19_1.vmethod_10());
		}

		public override Type vmethod_1()
		{
			return class19_1.vmethod_1();
		}

		public override bool vmethod_21()
		{
			return class19_1 != null;
		}

		public Class39(Class19 class19_2, Class19 class19_3)
		{
			class19_1 = class19_2;
			class19_0 = class19_3;
		}
	}

	private sealed class Class44 : Class26
	{
		private long long_0;

		public static Class19 smethod_3(Class19 class19_0, Class19 class19_1)
		{
			int num = 0;
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				ulong num2 = class19_0.vmethod_22();
				ulong num3 = class19_1.vmethod_22();
				if (num2 == num3)
				{
					num |= 0x40;
				}
				else if (num2 < num3)
				{
					num |= -525148;
				}
			}
			else
			{
				long num4 = class19_0.vmethod_13();
				long num5 = class19_1.vmethod_13();
				if (num4 == num5)
				{
					num |= 0x40;
				}
				else if (num4 < num5)
				{
					num |= -69756736;
				}
			}
			return new Class41(num);
		}

		public override sbyte vmethod_17()
		{
			return (sbyte)long_0;
		}

		public override object vmethod_10()
		{
			return long_0;
		}

		public override short vmethod_24()
		{
			return (short)long_0;
		}

		public override bool vmethod_21()
		{
			return (ulong)long_0 > 0uL;
		}

		public static Class19 smethod_4(Class19 class19_0, Class19 class19_1)
		{
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				ulong num = class19_0.vmethod_22();
				ulong num2 = class19_1.vmethod_22();
				return new Class44((long)(num % num2));
			}
			long num3 = class19_0.vmethod_13();
			long num4 = class19_1.vmethod_13();
			return new Class44(num3 % num4);
		}

		public override Class19 vmethod_5()
		{
			return new Class23((ulong)long_0);
		}

		public override byte vmethod_15()
		{
			return (byte)long_0;
		}

		public override IntPtr vmethod_4()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)long_0) : long_0);
		}

		public static Class19 smethod_5(Class19 class19_0)
		{
			return new Class44((long)class19_0.vmethod_22());
		}

		public override void vmethod_0(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override char vmethod_16()
		{
			return (char)long_0;
		}

		public static Class19 smethod_6(Class19 class19_0, Class19 class19_1)
		{
			ulong num = class19_0.vmethod_22();
			ulong num2 = class19_1.vmethod_22();
			ulong num3 = num + num2;
			Class44 @class = new Class44((long)num3);
			int num4 = 0;
			if (((num ^ num3) & (num2 ^ num3) & 0x80000000L) != 0L)
			{
				num4 |= 1;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num3))) & 0x80000000L) != 0L)
			{
				num4 |= 2;
			}
			@class.vmethod_12(num4);
			return @class;
		}

		public override UIntPtr vmethod_6()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)long_0) : long_0));
		}

		public override float vmethod_8()
		{
			return long_0;
		}

		public static Class19 smethod_7(Class19 class19_0, Class19 class19_1)
		{
			long num = class19_0.vmethod_13();
			int num2 = class19_1.vmethod_2();
			return new Class44(num << num2);
		}

		public static Class19 smethod_8(Class19 class19_0, Class19 class19_1)
		{
			long long_;
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				ulong num = class19_0.vmethod_22();
				ulong num2 = class19_1.vmethod_22();
				long_ = (long)(num / num2);
			}
			else
			{
				long num3 = class19_0.vmethod_13();
				long num4 = class19_1.vmethod_13();
				long_ = num3 / num4;
			}
			return new Class44(long_);
		}

		public static Class19 smethod_9(Class19 class19_0, Class19 class19_1)
		{
			ulong num = ~class19_0.vmethod_22();
			ulong num2 = ~class19_1.vmethod_22();
			ulong num3 = num | num2;
			Class44 @class = new Class44((long)num3);
			int num4 = 0;
			if (num3 == 0L)
			{
				num4 |= 0x40;
			}
			else if (num3 >> 565 != 0L)
			{
				num4 |= 0x20E;
			}
			@class.vmethod_12(num4);
			return @class;
		}

		public override double vmethod_7()
		{
			return long_0;
		}

		public override Class19 vmethod_25()
		{
			Class44 @class = new Class44(long_0);
			@class.vmethod_12(vmethod_3());
			return @class;
		}

		public override ulong vmethod_22()
		{
			return (ulong)long_0;
		}

		public unsafe override void* vmethod_19()
		{
			return vmethod_4().ToPointer();
		}

		public override int vmethod_2()
		{
			return (int)long_0;
		}

		public override TypeCode vmethod_18()
		{
			return TypeCode.Int64;
		}

		public static Class19 smethod_10(Class19 class19_0, Class19 class19_1)
		{
			ulong num = class19_0.vmethod_22();
			ulong num2 = class19_1.vmethod_22();
			ulong num3 = num * num2;
			Class44 @class = new Class44((long)num3);
			int num4 = 0;
			if (((num ^ num3) & (num2 ^ num3) & 0x80000000L) != 0L)
			{
				num4 |= 1;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num3))) & 0x80000000L) != 0L)
			{
				num4 |= 2;
			}
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				ulong num5 = num & 0xFFFFFFFFuL;
				ulong num6 = num >> 32;
				ulong num7 = num2 & 0xFFFFFFFFuL;
				ulong num8 = num2 >> 32;
				ulong num9 = num5 * num7;
				num9 = num6 * num7 + (num9 >> 32);
				ulong num10 = num9 & 0xFFFFFFFFL;
				ulong num11 = num9 >> 32;
				num9 = num10 + num5 * num8;
				num9 = num11 + num6 * num8 + (num9 >> 32);
				if (num9 != 0L)
				{
					num4 |= 2;
				}
			}
			@class.vmethod_12(num4);
			return @class;
		}

		public static Class19 smethod_11(Class19 class19_0, Class19 class19_1)
		{
			ulong num = ~class19_0.vmethod_22();
			ulong num2 = ~class19_1.vmethod_22();
			ulong num3 = num & num2;
			Class44 @class = new Class44((long)num3);
			int num4 = 0;
			if (num3 == 0L)
			{
				num4 |= 0x40;
			}
			else if (num3 >> 447817835 != 0L)
			{
				num4 |= 4;
			}
			@class.vmethod_12(num4);
			return @class;
		}

		public static Class19 smethod_12(Class19 class19_0, Class19 class19_1)
		{
			if (((uint)class19_1.vmethod_3() & 8u) != 0)
			{
				ulong num = class19_0.vmethod_22();
				int num2 = class19_1.vmethod_2();
				return new Class44((long)(num >> num2));
			}
			long num3 = class19_0.vmethod_13();
			int num4 = class19_1.vmethod_2();
			return new Class44(num3 >> (num4 & -449));
		}

		public override ushort vmethod_14()
		{
			return (ushort)long_0;
		}

		public override long vmethod_13()
		{
			return long_0;
		}

		public override Type vmethod_1()
		{
			return typeof(long);
		}

		public override uint vmethod_9()
		{
			return (uint)long_0;
		}

		public Class44(long long_1)
		{
			long_0 = long_1;
		}
	}

	private sealed class Class45 : Class26
	{
		private object object_0;

		public override Class19 vmethod_25()
		{
			while (object_0 != null)
			{
			}
			object object_ = null;
			return new Class45(object_);
		}

		public override void vmethod_0(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}

		public override object vmethod_10()
		{
			return object_0;
		}

		public override Type vmethod_1()
		{
			return typeof(ValueType);
		}

		public Class45(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}
	}

	private static readonly Module module_0 = typeof(GClass7).Module;

	private Class15 class15_0 = new Class15();

	private Class16 class16_0 = new Class16();

	private Class14 class14_0 = new Class14();

	private static readonly Dictionary<object, DynamicMethod> dictionary_0 = new Dictionary<object, DynamicMethod>();

	private List<IntPtr> list_0 = new List<IntPtr>();

	private Class48 class48_0;

	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	private Exception exception_0;

	private readonly Dictionary<uint, Delegate1> dictionary_2 = new Dictionary<uint, Delegate1>();

	private void method_0()
	{
		class15_0.method_5(new Class40(null));
	}

	private void method_1()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 @class = class15_0.method_2();
		switch (@class.vmethod_18())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_12(@class, class19_));
			break;
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_3(@class, class19_));
			break;
		}
	}

	private void method_2()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class27.smethod_9(class19_));
	}

	private void method_3()
	{
		method_50(class16_0.method_6());
		Array array;
		do
		{
			class15_0.method_2();
			array = class15_0.method_2().vmethod_10() as Array;
		}
		while (array != null);
		throw new ArgumentException();
	}

	private void method_4()
	{
		Type type = method_50(class16_0.method_6());
		object obj = class15_0.method_2().vmethod_10();
		Type type2 = obj.GetType();
		if (type2 != type && !type.IsAssignableFrom(type2))
		{
			throw new InvalidCastException();
		}
		class15_0.method_5(Class19.smethod_2(obj, type));
	}

	public object method_5(object[] object_0, int int_0)
	{
		class16_0.vmethod_0(int_0);
		class15_0.method_5(new Class40(object_0));
		try
		{
			while (true)
			{
				try
				{
					dictionary_2[class16_0.method_7()]();
					if (class16_0.vmethod_1() == 0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					if (class48_0 == null)
					{
						exception_0 = ex;
					}
					method_77();
				}
			}
			return class15_0.method_2().vmethod_10();
		}
		finally
		{
			foreach (IntPtr item in list_0)
			{
				Marshal.FreeHGlobal(item);
			}
			list_0.Clear();
		}
	}

	private void method_6()
	{
		FieldInfo fieldInfo_ = method_76(class16_0.method_6());
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(new Class35(fieldInfo_, class19_));
	}

	private void method_7()
	{
		MethodBase methodBase = method_8(class16_0.method_6());
		object obj = class15_0.method_2().vmethod_10();
		if (obj != null)
		{
			Type type = obj.GetType();
			Type declaringType = methodBase.DeclaringType;
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			while (type != null && type != declaringType)
			{
				MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
				if (!(method != null) || !(method.GetBaseDefinition() == methodBase))
				{
					type = type.BaseType;
					continue;
				}
				methodBase = method;
				break;
			}
		}
		class15_0.method_5(new Class32(methodBase));
	}

	private MethodBase method_8(int int_0)
	{
		lock (dictionary_1)
		{
			if (dictionary_1.TryGetValue(int_0, out var value))
			{
				return (MethodBase)value;
			}
			MethodBase methodBase = module_0.ResolveMethod(int_0);
			dictionary_1.Add(int_0, methodBase);
			return methodBase;
		}
	}

	private void method_9()
	{
		short int_ = class16_0.method_10();
		Class19 @class = class15_0.method_4(int_);
		class15_0.method_5(@class.vmethod_25());
	}

	private void method_10()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class41.smethod_4(class19_));
	}

	private void method_11()
	{
		Class11 @class = method_73(class16_0.method_6());
		if (!@class.Boolean_0)
		{
			throw new ArgumentException();
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		Type[] array = @class.method_1();
		Type[] array2 = new Type[array.Length + 1];
		array.CopyTo(array2, 0);
		array2[array.Length] = typeof(IntPtr);
		object[] array3 = new object[array2.Length];
		Dictionary<int, Class19> dictionary = new Dictionary<int, Class19>();
		Class10 class2 = new Class10();
		try
		{
			for (int num = array3.Length - 1; num >= 0; num--)
			{
				Type type = array2[num];
				Class19 class3 = class15_0.method_2();
				if (class3.vmethod_20())
				{
					if (!type.IsByRef)
					{
						array3[num] = class2.method_0(class3.vmethod_10());
						continue;
					}
					dictionary[num] = class3;
				}
				array3[num] = class3.method_0(type).vmethod_10();
			}
			DynamicMethod value;
			lock (dictionary_0)
			{
				if (!dictionary_0.TryGetValue(@class, out value))
				{
					value = new DynamicMethod("", (@class.Type_0 != typeof(void)) ? @class.Type_0 : null, array2, typeof(GClass7).Module, skipVisibility: true);
					ILGenerator iLGenerator = value.GetILGenerator();
					for (int i = 0; i < array2.Length; i++)
					{
						iLGenerator.Emit(dictionary.ContainsKey(i) ? OpCodes.Ldarga : OpCodes.Ldarg, i);
					}
					iLGenerator.EmitCalli(OpCodes.Calli, @class.CallingConvention_0, @class.Type_0, array);
					iLGenerator.Emit(OpCodes.Ret);
					dictionary_0.Add(@class, value);
				}
			}
			object object_ = value.Invoke(null, invokeAttr, null, array3, null);
			foreach (KeyValuePair<int, Class19> item in dictionary)
			{
				item.Value.vmethod_0(array3[item.Key]);
			}
			if (@class.Type_0 != typeof(void))
			{
				class15_0.method_5(Class19.smethod_2(object_, @class.Type_0));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	private void method_12()
	{
		Type type_ = method_50(class16_0.method_6());
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class19.smethod_0(class19_, type_));
	}

	private void method_13()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 class19_2 = class15_0.method_2();
		switch (method_27(class19_2, class19_))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_9(class19_2, class19_));
			break;
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_9(class19_2, class19_));
			break;
		}
	}

	private void method_14()
	{
		Type type = method_50(class16_0.method_6());
		Class19 @class = class15_0.method_2();
		Class19 class2 = class15_0.method_2();
		Array obj = (class15_0.method_2().vmethod_10() as Array) ?? throw new ArgumentException();
		@class = @class.method_0(type);
		Type elementType = obj.GetType().GetElementType();
		if (type != elementType)
		{
			@class = @class.method_0(elementType);
		}
		obj.SetValue(@class.vmethod_10(), class2.vmethod_2());
	}

	private void method_15()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class42.smethod_3(class19_));
	}

	private void method_16()
	{
		int num = class16_0.method_10();
		Class19 @class = class15_0.method_2();
		if (num < 0)
		{
			class15_0.method_1(num + class15_0.vmethod_1(), @class);
			return;
		}
		Class19 class2 = class15_0.method_4(num);
		if (class2 == null)
		{
			if (!@class.vmethod_20())
			{
				throw new ArgumentException();
			}
			class15_0.method_1(num, @class);
		}
		else
		{
			class2.vmethod_0(@class.method_0(class2.vmethod_1()).vmethod_10());
		}
	}

	private void method_17()
	{
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void method_18()
	{
		int num = class16_0.method_6();
		int num2 = num >> 24;
		if (num2 <= 10)
		{
			switch (num2)
			{
			case 10:
				break;
			case 4:
				class15_0.method_5(new Class45(module_0.ModuleHandle.ResolveFieldHandle(num)));
				return;
			default:
				goto IL_00dc;
			case 6:
				goto IL_00e2;
			case 1:
			case 2:
				goto IL_010b;
			}
			if (method_73(num).Boolean_0)
			{
				class15_0.method_5(new Class45(module_0.ModuleHandle.ResolveMethodHandle(num)));
			}
			else
			{
				class15_0.method_5(new Class45(module_0.ModuleHandle.ResolveFieldHandle(num)));
			}
			return;
		}
		if (num2 != -1049979151)
		{
			if (num2 != -1802279744)
			{
				goto IL_00dc;
			}
			goto IL_00e2;
		}
		goto IL_010b;
		IL_00dc:
		throw new InvalidOperationException();
		IL_010b:
		class15_0.method_5(new Class45(module_0.ModuleHandle.ResolveTypeHandle(num)));
		return;
		IL_00e2:
		class15_0.method_5(new Class45(module_0.ModuleHandle.ResolveMethodHandle(num)));
	}

	private object method_19(int int_0)
	{
		lock (dictionary_1)
		{
			object value;
			while (!dictionary_1.TryGetValue(int_0, out value))
			{
			}
			return value;
		}
	}

	private void method_20()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class31.smethod_11(class19_));
	}

	private void method_21()
	{
		Type elementType = method_50(class16_0.method_6());
		class15_0.method_5(new Class40(Array.CreateInstance(elementType, class15_0.method_2().vmethod_2())));
	}

	private void method_22()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class24.smethod_3(class19_));
	}

	private void method_23()
	{
		if (class15_0.method_2().vmethod_2() != 0)
		{
			class14_0.method_0();
			class15_0.method_5(new Class40(exception_0));
			class16_0.vmethod_0(class48_0.method_2());
			class48_0 = null;
		}
		else
		{
			method_77();
		}
	}

	private void method_24()
	{
		if (!(class15_0.method_2().vmethod_10() is Array array))
		{
			throw new ArgumentException();
		}
		class15_0.method_5(new Class41(array.Length));
	}

	private void method_25()
	{
		Type type = method_50(class16_0.method_6());
		DynamicMethod value;
		lock (dictionary_0)
		{
			if (!dictionary_0.TryGetValue(type, out value))
			{
				value = new DynamicMethod("", typeof(int), null, typeof(GClass7).Module, skipVisibility: true);
				ILGenerator iLGenerator = value.GetILGenerator();
				iLGenerator.Emit(OpCodes.Sizeof, type);
				iLGenerator.Emit(OpCodes.Ret);
				dictionary_0.Add(type, value);
			}
		}
		class15_0.method_5(new Class41((int)value.Invoke(null, null)));
	}

	private void method_26()
	{
		Type type_ = method_50(class16_0.method_6());
		Class19 @class = class15_0.method_2();
		class15_0.method_5(new Class40(@class.method_0(type_).vmethod_10()));
	}

	private TypeCode method_27(Class19 class19_0, Class19 class19_1)
	{
		while (true)
		{
			TypeCode typeCode = class19_0.vmethod_18();
			TypeCode typeCode2 = class19_1.vmethod_18();
			if (typeCode == TypeCode.Empty || typeCode2 == TypeCode.Empty)
			{
				break;
			}
			if (typeCode != (TypeCode)1246904299 && typeCode2 != (TypeCode)1246904299)
			{
				if (typeCode != (TypeCode)(-1217055869))
				{
					if (typeCode2 == (TypeCode)(-1231558404))
					{
						continue;
					}
					if (typeCode == TypeCode.Single)
					{
						if (typeCode2 != (TypeCode)(-1843800045) && typeCode2 != (TypeCode)68818957 && typeCode2 != TypeCode.UInt64)
						{
							return TypeCode.Empty;
						}
						return typeCode;
					}
					if (typeCode2 == TypeCode.UInt64)
					{
						if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Int64 && typeCode != TypeCode.UInt64)
						{
							return TypeCode.Empty;
						}
						return typeCode2;
					}
					if (typeCode != (TypeCode)138954282 && typeCode2 != (TypeCode)2077050626)
					{
						if (typeCode != (TypeCode)(-68157439) && typeCode2 != TypeCode.SByte)
						{
							if (typeCode != (TypeCode)2208 && typeCode2 != (TypeCode)663983024)
							{
								return (TypeCode)(-2020620202);
							}
							return TypeCode.UInt32;
						}
						return TypeCode.SByte;
					}
					return (TypeCode)2077050626;
				}
				if (typeCode2 != (TypeCode)(-377642283) && typeCode2 != (TypeCode)780295998)
				{
					return TypeCode.Empty;
				}
				return typeCode;
			}
			return (TypeCode)409641;
		}
		return TypeCode.Empty;
	}

	private void method_28()
	{
		Class19 @class = class15_0.method_2();
		class15_0.method_5(@class.method_0(@class.vmethod_1()));
	}

	private void method_29()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class21.smethod_3(class19_));
	}

	private void method_30()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 @class = class15_0.method_2();
		switch (@class.vmethod_18())
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_7(@class, class19_));
			break;
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_10(@class, class19_));
			break;
		}
	}

	private void method_31()
	{
		object object_ = method_19(class16_0.method_6());
		class15_0.method_5(new Class40(object_));
	}

	private void method_32()
	{
		Class19 @class = class15_0.method_2();
		Class19 class2 = class15_0.method_2();
		@class.vmethod_0(class2.method_0(@class.vmethod_1()).vmethod_10());
	}

	private void method_33()
	{
		int num = class16_0.method_6();
		class16_0.method_2(class15_0.method_2().vmethod_2());
		List<int> list = new List<int>();
		while (class14_0.method_2() != 0 && num > class14_0.method_1().method_2())
		{
			List<Class48> list2 = class14_0.method_0().method_4();
			for (int i = 0; i < list2.Count; i++)
			{
				Class48 @class = list2[i];
				if (@class.method_1() == 2)
				{
					list.Add(@class.method_2());
				}
			}
		}
		for (int num2 = list.Count; num2 > 0; num2--)
		{
			class16_0.method_2(list[num2 - 1]);
		}
		exception_0 = null;
		class15_0.method_3();
		class16_0.method_4();
	}

	private void method_34()
	{
		Type type = method_50(class16_0.method_6());
		Class19 @class = class15_0.method_2();
		object object_ = null;
		if (type.IsValueType && Nullable.GetUnderlyingType(type) == null)
		{
			object_ = FormatterServices.GetUninitializedObject(type);
		}
		@class.vmethod_0(object_);
	}

	private void method_35()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class44.smethod_5(class19_));
	}

	private void method_36()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class27.smethod_4(class19_));
	}

	private void method_37()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class27.smethod_7(class19_));
	}

	private void method_38()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class19.smethod_1(class19_));
	}

	private void method_39()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class46.smethod_3(class19_));
	}

	private unsafe void method_40()
	{
		Type type = method_50(class16_0.method_6());
		Class19 @class = class15_0.method_2();
		if (!@class.vmethod_20())
		{
			@class = new Class34((@class.vmethod_10() is Pointer) ? new IntPtr(Pointer.Unbox(@class.vmethod_10())) : @class.vmethod_4(), type);
		}
		class15_0.method_5(@class.method_0(type));
	}

	private void method_41()
	{
		short int_ = class16_0.method_10();
		Type type = method_50(class15_0.method_2().vmethod_2());
		Class19 @class = class15_0.method_2();
		Class19 class2 = class15_0.method_2();
		object obj = class2.vmethod_10();
		if (obj == null && type.IsValueType)
		{
			obj = Activator.CreateInstance(type);
		}
		class2 = Class19.smethod_2(obj, type);
		if (@class.vmethod_20())
		{
			class2 = new Class39(class2, @class);
		}
		class15_0.method_1(int_, class2);
	}

	private void method_42()
	{
		class15_0.method_5(class15_0.method_0().vmethod_25());
	}

	private void method_43()
	{
		class15_0.method_5(new Class31(class16_0.method_5()));
	}

	private void method_44()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 class19_2 = class15_0.method_2();
		switch (method_27(class19_2, class19_))
		{
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_5(class19_2, class19_));
			break;
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_8(class19_2, class19_));
			break;
		default:
			throw new InvalidOperationException();
		case TypeCode.Single:
			class15_0.method_5(Class27.smethod_10(class19_2, class19_));
			break;
		case TypeCode.Double:
			class15_0.method_5(Class31.smethod_8(class19_2, class19_));
			break;
		}
	}

	private void method_45()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class31.smethod_4(class19_));
	}

	private void method_46()
	{
		int int_ = class16_0.method_1();
		class15_0.method_0().vmethod_12(int_);
	}

	private void method_47()
	{
		while (true)
		{
			Class19 class19_ = class15_0.method_2();
			Class19 class19_2 = class15_0.method_2();
			switch (method_27(class19_2, class19_))
			{
			case TypeCode.Int64:
				break;
			case TypeCode.Int32:
				class15_0.method_5(Class41.smethod_8(class19_2, class19_));
				return;
			default:
				throw new InvalidOperationException();
			case TypeCode.Single:
				class15_0.method_5(Class27.smethod_8(class19_2, class19_));
				return;
			case TypeCode.Double:
				class15_0.method_5(Class31.smethod_6(class19_2, class19_));
				return;
			}
			class15_0.method_5(Class44.smethod_10(class19_2, class19_));
		}
	}

	private void method_48()
	{
		throw (class15_0.method_2().vmethod_10() as Exception) ?? throw new ArgumentException();
	}

	private void method_49()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class31.smethod_9(class19_));
	}

	private Type method_50(int int_0)
	{
		Dictionary<int, object> obj = dictionary_1;
		bool lockTaken = false;
		try
		{
			object value;
			do
			{
				Monitor.Enter(obj, ref lockTaken);
			}
			while (!dictionary_1.TryGetValue(int_0, out value));
			return (Type)value;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private void method_51()
	{
		short int_ = class16_0.method_10();
		Class19 @class = class15_0.method_4(int_);
		if (@class.vmethod_20())
		{
			throw new ArgumentException();
		}
		class15_0.method_5(new Class36(@class));
	}

	private void method_52()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 class19_2 = class15_0.method_2();
		switch (method_27(class19_2, class19_))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_11(class19_2, class19_));
			break;
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_7(class19_2, class19_));
			break;
		}
	}

	private void method_53()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class47.smethod_3(class19_));
	}

	private void method_54()
	{
		Class19 @class = class15_0.method_2();
		if (!(class15_0.method_2().vmethod_10() is Array array_))
		{
			throw new ArgumentException();
		}
		class15_0.method_5(new Class38(array_, @class.vmethod_2()));
	}

	private void method_55()
	{
		Class19 @class = class15_0.method_2();
		Class19 class2 = class15_0.method_2();
		switch (method_27(class2, @class))
		{
		default:
			throw new InvalidOperationException();
		case TypeCode.Int32:
			class15_0.method_5(Class41.smethod_12(class2, @class));
			break;
		case TypeCode.Int64:
			class15_0.method_5(Class44.smethod_3(class2, @class));
			break;
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			class15_0.method_5(Class28.smethod_4(class2, @class));
			break;
		case TypeCode.Single:
			class15_0.method_5(Class27.smethod_3(class2, @class));
			break;
		case TypeCode.Double:
			class15_0.method_5(Class31.smethod_10(class2, @class));
			break;
		case TypeCode.Object:
			class15_0.method_5(Class40.smethod_3(class2, @class));
			break;
		}
	}

	private void method_56()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(class15_0.method_2().vmethod_4());
		list_0.Add(intPtr);
		class15_0.method_5(new Class43(intPtr));
	}

	private unsafe void method_57()
	{
		Type type = method_50(class16_0.method_6());
		Class19 @class = class15_0.method_2();
		Class19 class2 = class15_0.method_2();
		@class = @class.method_0(type);
		if (class2.vmethod_20())
		{
			@class = @class.method_0(class2.vmethod_1());
		}
		else
		{
			class2 = new Class34((class2.vmethod_10() is Pointer) ? new IntPtr(Pointer.Unbox(class2.vmethod_10())) : class2.vmethod_4(), type);
		}
		class2.vmethod_0(@class.vmethod_10());
	}

	private void method_58()
	{
		FieldInfo fieldInfo_ = method_76(class16_0.method_6());
		class15_0.method_5(new Class37(fieldInfo_, this));
	}

	private void method_59()
	{
		class15_0.method_2();
	}

	private void method_60()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class23.smethod_3(class19_));
	}

	private void method_61()
	{
		if (exception_0 == null)
		{
			class16_0.method_4();
		}
		else
		{
			method_77();
		}
	}

	private void method_62()
	{
		while (true)
		{
			Class19 @class = class15_0.method_2();
			while (true)
			{
				Class19 class2 = class15_0.method_2();
				switch (method_27(class2, @class))
				{
				case TypeCode.Single:
					goto IL_0003;
				case TypeCode.Int32:
					break;
				case TypeCode.Int64:
					class15_0.method_5(Class44.smethod_6(class2, @class));
					goto default;
				default:
					throw new InvalidOperationException();
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					class15_0.method_5(Class28.smethod_5(class2, @class));
					return;
				case TypeCode.Double:
					class15_0.method_5(Class31.smethod_5(class2, @class));
					return;
				}
				break;
				IL_0003:
				class15_0.method_5(Class27.smethod_6(class2, @class));
			}
		}
	}

	private void method_63()
	{
		class15_0.method_5(new Class44(class16_0.method_3()));
	}

	private void method_64()
	{
		Class19 class19_ = class15_0.method_2();
		Class19 @class = class15_0.method_2();
		TypeCode typeCode = @class.vmethod_18();
		while (true)
		{
			switch (typeCode)
			{
			case TypeCode.Double:
				break;
			case TypeCode.Int32:
				class15_0.method_5(Class41.smethod_6(@class, class19_));
				return;
			case TypeCode.Int64:
				class15_0.method_5(Class44.smethod_4(@class, class19_));
				return;
			default:
				throw new InvalidOperationException();
			case TypeCode.Single:
				class15_0.method_5(Class27.smethod_5(@class, class19_));
				return;
			}
			class15_0.method_5(Class31.smethod_7(@class, class19_));
		}
	}

	private void method_65()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class22.smethod_3(class19_));
	}

	private void method_66()
	{
		Class19 @class = class15_0.method_2();
		Class16 class2 = new Class16();
		class2.vmethod_0(@class.vmethod_2());
		int num = @class.vmethod_3();
		ushort num2 = (ushort)class2.method_10();
		Dictionary<int, Class19> dictionary = new Dictionary<int, Class19>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[num2];
			for (int num3 = num2 - 1; num3 >= 0; num3--)
			{
				@class = class15_0.method_2();
				if (@class.vmethod_20())
				{
					dictionary[num3] = @class;
				}
				array[num3] = @class.method_0(method_50(class2.method_6())).vmethod_10();
			}
		}
		int num4 = class2.method_6();
		if (((uint)num & 0x20u) != 0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		class2.method_6();
		object object_ = new GClass7().method_5(array, class2.vmethod_1());
		foreach (KeyValuePair<int, Class19> item in dictionary)
		{
			item.Value.vmethod_0(array[item.Key]);
		}
		if (num4 != 0)
		{
			Type type = method_50(num4);
			if (type != typeof(void))
			{
				class15_0.method_5(Class19.smethod_2(object_, type));
			}
		}
	}

	private bool method_67(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (Nullable.GetUnderlyingType(declaringType) != null)
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", (StringComparison)134221860))
			{
				object_1 = object_0 != null;
				return true;
			}
			if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					throw new InvalidOperationException();
				}
				object_1 = object_0;
				return true;
			}
			if (methodBase_0.Name.Equals("GetValueOrDefault", (StringComparison)(-411050049)))
			{
				if (object_0 == null)
				{
					object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_1 = object_0;
				return true;
			}
		}
		return true;
	}

	private void method_68()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class31.smethod_3(class19_));
	}

	private void method_69()
	{
		byte byte_ = class16_0.method_1();
		int int_ = class16_0.method_6();
		int int_2 = class16_0.method_6();
		int int_3 = class16_0.method_6();
		int int_4 = class16_0.method_6();
		class14_0.method_3(int_, int_2, byte_, int_3, int_4);
	}

	private void method_70()
	{
		Class19 @class = class15_0.method_2();
		int num = @class.vmethod_2();
		MethodBase methodBase = method_8(num);
		int num2 = @class.vmethod_3();
		Type[] array;
		if (methodBase.CallingConvention == CallingConventions.VarArgs)
		{
			Class11 class2 = method_73(num);
			if (!class2.Boolean_0)
			{
				throw new ArgumentException();
			}
			array = class2.method_1();
		}
		else
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			array = new Type[parameters.Length];
			for (int i = 134004737; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
		}
		bool flag = (uint)(num2 & 0xB74CBF8) > 3772345139u;
		if (((uint)num2 & 0x10u) != 0)
		{
			MethodInfo method = method_50(class15_0.method_2().vmethod_2()).GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		MethodInfo methodInfo = methodBase as MethodInfo;
		Dictionary<int, Class19> dictionary = new Dictionary<int, Class19>();
		object[] array2 = new object[array.Length];
		Class10 class3 = new Class10();
		try
		{
			for (int num3 = array2.Length - 1; num3 >= 0; num3--)
			{
				Type type = array[num3];
				@class = class15_0.method_2();
				if (@class.vmethod_20())
				{
					if (!type.IsByRef)
					{
						array2[num3] = class3.method_0(@class.vmethod_10());
						continue;
					}
					dictionary[num3] = @class;
				}
				array2[num3] = @class.method_0(type).vmethod_10();
			}
			@class = (methodBase.IsStatic ? null : class15_0.method_2());
			object obj;
			if (@class == null)
			{
				obj = null;
			}
			else
			{
				obj = @class.vmethod_10();
				if (obj != null)
				{
					goto IL_019a;
				}
			}
			obj = null;
			goto IL_019a;
			IL_019a:
			object obj2 = obj;
			if (flag && obj2 == null)
			{
				throw new NullReferenceException();
			}
			object object_ = null;
			if (methodBase.CallingConvention == CallingConventions.VarArgs)
			{
				DynamicMethod value;
				lock (dictionary_0)
				{
					if (!dictionary_0.TryGetValue(num, out value))
					{
						int num4 = methodInfo.GetParameters().Length;
						Type[] array3 = new Type[array.Length - num4];
						Array.Copy(array, num4, array3, 0, array.Length - num4);
						value = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array, typeof(GClass7).Module, skipVisibility: true);
						ILGenerator iLGenerator = value.GetILGenerator();
						for (int j = 0; j < array.Length; j++)
						{
							iLGenerator.Emit(OpCodes.Ldarg, j);
						}
						iLGenerator.EmitCall(OpCodes.Call, methodInfo, array3);
						iLGenerator.Emit(OpCodes.Ret);
						dictionary_0.Add(num, value);
					}
				}
				object_ = value.Invoke(null, invokeAttr, null, array2, null);
			}
			else if (methodBase.IsConstructor && methodBase.DeclaringType.IsValueType)
			{
				methodBase.Invoke(obj2, invokeAttr, null, array2, null);
				if (@class != null && @class.vmethod_20())
				{
					@class.vmethod_0(Class19.smethod_2(obj2, methodBase.DeclaringType).vmethod_10());
				}
			}
			else if (!method_67(methodBase, obj2, ref object_, array2) && !flag && methodBase.IsVirtual && !methodBase.IsFinal)
			{
				object[] array4 = new object[array.Length + 1];
				array4[0] = obj2;
				for (int k = 0; k < array.Length; k++)
				{
					array4[k + 1] = array2[k];
				}
				DynamicMethod value2;
				lock (dictionary_0)
				{
					if (!dictionary_0.TryGetValue(methodBase, out value2))
					{
						Type[] array5 = new Type[array4.Length];
						array5[0] = methodBase.DeclaringType;
						for (int l = 0; l < array.Length; l++)
						{
							array5[l + 1] = array[l];
						}
						value2 = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array5, typeof(GClass7).Module, skipVisibility: true);
						ILGenerator iLGenerator2 = value2.GetILGenerator();
						iLGenerator2.Emit(@class.vmethod_20() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
						for (int m = 1; m < array5.Length; m++)
						{
							iLGenerator2.Emit(dictionary.ContainsKey(m - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, m);
						}
						iLGenerator2.Emit(OpCodes.Call, methodInfo);
						iLGenerator2.Emit(OpCodes.Ret);
						dictionary_0.Add(methodBase, value2);
					}
				}
				object_ = value2.Invoke(null, invokeAttr, null, array4, null);
				foreach (KeyValuePair<int, Class19> item in dictionary)
				{
					item.Value.vmethod_0(array4[item.Key + 1]);
				}
				dictionary.Clear();
			}
			foreach (KeyValuePair<int, Class19> item2 in dictionary)
			{
				item2.Value.vmethod_0(array2[item2.Key]);
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				class15_0.method_5(Class19.smethod_2(object_, methodInfo.ReturnType));
			}
		}
		finally
		{
			class3.Dispose();
		}
	}

	private void method_71()
	{
		MethodBase methodBase = method_8(class16_0.method_6());
		ParameterInfo[] parameters = methodBase.GetParameters();
		Dictionary<int, Class19> dictionary = new Dictionary<int, Class19>();
		object[] array = new object[parameters.Length];
		Class10 @class = new Class10();
		try
		{
			for (int num = parameters.Length - 1; num >= 0; num--)
			{
				Type parameterType = parameters[num].ParameterType;
				Class19 class2 = class15_0.method_2();
				if (class2.vmethod_20())
				{
					if (!parameterType.IsByRef)
					{
						array[num] = @class.method_0(class2.vmethod_10());
						continue;
					}
					dictionary[num] = class2;
				}
				array[num] = class2.method_0(parameterType).vmethod_10();
			}
			object object_ = ((ConstructorInfo)methodBase).Invoke(array);
			foreach (KeyValuePair<int, Class19> item in dictionary)
			{
				item.Value.vmethod_0(array[item.Key]);
			}
			class15_0.method_5(Class19.smethod_2(object_, methodBase.DeclaringType));
		}
		finally
		{
			@class.Dispose();
		}
	}

	private void method_72()
	{
		class15_0.method_5(new Class29(class15_0.method_2()));
	}

	private Class11 method_73(int int_0)
	{
		lock (dictionary_1)
		{
			int key = int_0 | 0x40000000;
			if (dictionary_1.TryGetValue(key, out var value))
			{
				return (Class11)value;
			}
			byte[] byte_ = module_0.ResolveSignature(int_0);
			Class11 @class = new Class11();
			@class.method_0(byte_, module_0);
			dictionary_1.Add(key, @class);
			return @class;
		}
	}

	private void method_74()
	{
		Class19 class19_ = class15_0.method_2();
		class15_0.method_5(Class43.smethod_4(class19_));
	}

	private void method_75()
	{
		class15_0.method_5(new Class27(class16_0.method_9()));
	}

	private FieldInfo method_76(int int_0)
	{
		lock (dictionary_1)
		{
			if (dictionary_1.TryGetValue(int_0, out var value))
			{
				return (FieldInfo)value;
			}
			FieldInfo fieldInfo = module_0.ResolveField(int_0);
			dictionary_1.Add(int_0, fieldInfo);
			return fieldInfo;
		}
	}

	private void method_77()
	{
		class15_0.method_3();
		class16_0.method_0();
		do
		{
			if (class14_0.method_2() != 0)
			{
				List<Class48> list = class14_0.method_1().method_4();
				int num = ((class48_0 == null) ? 852133384 : (list.IndexOf(class48_0) + 1));
				class48_0 = null;
				for (int i = num; i < list.Count; i++)
				{
					Class48 @class = list[i];
					switch (@class.method_1())
					{
					case 0:
					{
						Type type = exception_0.GetType();
						Type type2 = method_50(@class.method_0());
						if (type == type2 || type.IsSubclassOf(type2))
						{
							class14_0.method_0();
							class15_0.method_5(new Class40(exception_0));
							class16_0.vmethod_0(@class.method_2());
							return;
						}
						break;
					}
					case 1:
						class48_0 = @class;
						class15_0.method_5(new Class40(exception_0));
						class16_0.vmethod_0(@class.method_0());
						return;
					}
				}
				class14_0.method_0();
				for (int num2 = list.Count; num2 > 0; num2--)
				{
					Class48 class2 = list[num2 - 1];
					if (class2.method_1() == 2 || class2.method_1() == 4)
					{
						class16_0.method_2(class2.method_2());
					}
				}
				continue;
			}
			throw exception_0;
		}
		while (class16_0.method_8() == 0);
		class16_0.method_4();
	}

	private void method_78()
	{
		class15_0.method_5(new Class41(class16_0.method_6()));
	}

	private void method_79()
	{
		Class19 @class = class15_0.method_2();
		class15_0.method_5(new Class41(@class.vmethod_3()));
	}

	public GClass7()
	{
		dictionary_2[0u] = method_20;
		dictionary_2[1u] = method_31;
		dictionary_2[2u] = method_52;
		dictionary_2[3u] = method_55;
		dictionary_2[4u] = method_11;
		dictionary_2[5u] = method_48;
		dictionary_2[6u] = method_79;
		dictionary_2[7u] = method_36;
		dictionary_2[8u] = method_43;
		dictionary_2[9u] = method_66;
		dictionary_2[10u] = method_60;
		dictionary_2[11u] = method_1;
		dictionary_2[12u] = method_40;
		dictionary_2[13u] = method_53;
		dictionary_2[14u] = method_14;
		dictionary_2[15u] = method_4;
		dictionary_2[16u] = method_28;
		dictionary_2[17u] = method_39;
		dictionary_2[18u] = method_3;
		dictionary_2[19u] = method_70;
		dictionary_2[20u] = method_59;
		dictionary_2[21u] = method_37;
		dictionary_2[22u] = method_16;
		dictionary_2[23u] = method_35;
		dictionary_2[24u] = method_13;
		dictionary_2[25u] = method_49;
		dictionary_2[26u] = method_57;
		dictionary_2[27u] = method_65;
		dictionary_2[28u] = method_9;
		dictionary_2[29u] = method_34;
		dictionary_2[30u] = method_51;
		dictionary_2[31u] = method_47;
		dictionary_2[32u] = method_41;
		dictionary_2[33u] = method_68;
		dictionary_2[34u] = method_2;
		dictionary_2[35u] = method_0;
		dictionary_2[36u] = method_72;
		dictionary_2[37u] = method_32;
		dictionary_2[38u] = method_12;
		dictionary_2[39u] = method_24;
		dictionary_2[40u] = method_71;
		dictionary_2[41u] = method_10;
		dictionary_2[42u] = method_54;
		dictionary_2[43u] = method_23;
		dictionary_2[44u] = method_30;
		dictionary_2[45u] = method_62;
		dictionary_2[46u] = method_26;
		dictionary_2[47u] = method_63;
		dictionary_2[48u] = method_64;
		dictionary_2[49u] = method_58;
		dictionary_2[50u] = method_25;
		dictionary_2[51u] = method_29;
		dictionary_2[52u] = method_46;
		dictionary_2[53u] = method_21;
		dictionary_2[54u] = method_69;
		dictionary_2[55u] = method_6;
		dictionary_2[56u] = method_61;
		dictionary_2[57u] = method_42;
		dictionary_2[58u] = method_15;
		dictionary_2[59u] = method_33;
		dictionary_2[60u] = method_18;
		dictionary_2[61u] = method_56;
		dictionary_2[62u] = method_22;
		dictionary_2[63u] = method_7;
		dictionary_2[64u] = method_44;
		dictionary_2[65u] = method_45;
		dictionary_2[66u] = method_75;
		dictionary_2[67u] = method_74;
		dictionary_2[68u] = method_38;
		dictionary_2[69u] = method_17;
		dictionary_2[70u] = method_78;
		dictionary_2[71u] = method_46;
		dictionary_2[72u] = method_4;
		dictionary_2[73u] = method_62;
		dictionary_2[74u] = method_12;
		dictionary_2[75u] = method_47;
		dictionary_2[76u] = method_17;
		dictionary_2[77u] = method_55;
		dictionary_2[78u] = method_49;
		dictionary_2[79u] = method_17;
		dictionary_2[80u] = method_72;
		dictionary_2[81u] = method_15;
		dictionary_2[82u] = method_14;
		dictionary_2[83u] = method_70;
		dictionary_2[84u] = method_9;
		dictionary_2[85u] = method_53;
		dictionary_2[86u] = method_60;
		dictionary_2[87u] = method_62;
		dictionary_2[88u] = method_3;
		dictionary_2[89u] = method_3;
		dictionary_2[90u] = method_23;
		dictionary_2[91u] = method_33;
		dictionary_2[92u] = method_21;
		dictionary_2[93u] = method_17;
		dictionary_2[94u] = method_46;
		dictionary_2[95u] = method_4;
		dictionary_2[96u] = method_3;
		dictionary_2[97u] = method_3;
		dictionary_2[98u] = method_75;
		dictionary_2[99u] = method_53;
		dictionary_2[100u] = method_65;
		dictionary_2[101u] = method_51;
		dictionary_2[102u] = method_65;
		dictionary_2[103u] = method_53;
		dictionary_2[104u] = method_74;
		dictionary_2[105u] = method_53;
		dictionary_2[106u] = method_70;
		dictionary_2[107u] = method_43;
		dictionary_2[108u] = method_55;
		dictionary_2[109u] = method_17;
		dictionary_2[110u] = method_39;
		dictionary_2[111u] = method_43;
		dictionary_2[112u] = method_16;
		dictionary_2[113u] = method_55;
		dictionary_2[114u] = method_4;
		dictionary_2[115u] = method_54;
		dictionary_2[116u] = method_47;
		dictionary_2[117u] = method_43;
		dictionary_2[118u] = method_17;
		dictionary_2[119u] = method_12;
		dictionary_2[120u] = method_43;
		dictionary_2[121u] = method_17;
		dictionary_2[122u] = method_66;
		dictionary_2[123u] = method_40;
		dictionary_2[124u] = method_17;
		dictionary_2[125u] = method_48;
		dictionary_2[126u] = method_43;
		dictionary_2[127u] = method_15;
		dictionary_2[128u] = method_33;
		dictionary_2[129u] = method_9;
		dictionary_2[130u] = method_23;
		dictionary_2[131u] = method_26;
		dictionary_2[132u] = method_53;
		dictionary_2[133u] = method_29;
		dictionary_2[134u] = method_32;
		dictionary_2[135u] = method_33;
		dictionary_2[136u] = method_55;
		dictionary_2[137u] = method_17;
		dictionary_2[138u] = method_62;
		dictionary_2[139u] = method_53;
		dictionary_2[140u] = method_43;
		dictionary_2[141u] = method_55;
		dictionary_2[142u] = method_17;
		dictionary_2[143u] = method_17;
		dictionary_2[144u] = method_63;
		dictionary_2[145u] = method_32;
		dictionary_2[146u] = method_62;
		dictionary_2[147u] = method_12;
		dictionary_2[148u] = method_47;
		dictionary_2[149u] = method_62;
		dictionary_2[150u] = method_54;
		dictionary_2[151u] = method_25;
		dictionary_2[152u] = method_13;
		dictionary_2[153u] = method_43;
		dictionary_2[154u] = method_29;
		dictionary_2[155u] = method_15;
		dictionary_2[156u] = method_17;
		dictionary_2[157u] = method_74;
		dictionary_2[158u] = method_30;
		dictionary_2[159u] = method_39;
		dictionary_2[160u] = method_41;
		dictionary_2[161u] = method_14;
		dictionary_2[162u] = method_4;
		dictionary_2[163u] = method_63;
		dictionary_2[164u] = method_53;
		dictionary_2[165u] = method_53;
		dictionary_2[166u] = method_41;
		dictionary_2[167u] = method_7;
		dictionary_2[168u] = method_21;
		dictionary_2[169u] = method_41;
		dictionary_2[170u] = method_43;
		dictionary_2[171u] = method_63;
		dictionary_2[172u] = method_4;
		dictionary_2[173u] = method_49;
		dictionary_2[174u] = method_68;
		dictionary_2[175u] = method_33;
		dictionary_2[176u] = method_10;
		dictionary_2[177u] = method_47;
		dictionary_2[178u] = method_15;
		dictionary_2[179u] = method_17;
		dictionary_2[180u] = method_29;
		dictionary_2[181u] = method_12;
		dictionary_2[182u] = method_52;
		dictionary_2[183u] = method_68;
		dictionary_2[184u] = method_12;
		dictionary_2[185u] = method_29;
		dictionary_2[186u] = method_3;
		dictionary_2[187u] = method_29;
		dictionary_2[188u] = method_55;
		dictionary_2[189u] = method_54;
		dictionary_2[190u] = method_57;
		dictionary_2[191u] = method_17;
		dictionary_2[192u] = method_53;
		dictionary_2[193u] = method_48;
		dictionary_2[194u] = method_62;
		dictionary_2[195u] = method_29;
		dictionary_2[196u] = method_63;
		dictionary_2[197u] = method_3;
		dictionary_2[198u] = method_47;
		dictionary_2[199u] = method_41;
		dictionary_2[200u] = method_23;
		dictionary_2[201u] = method_16;
		dictionary_2[202u] = method_68;
		dictionary_2[203u] = method_69;
		dictionary_2[204u] = method_47;
		dictionary_2[205u] = method_68;
		dictionary_2[206u] = method_46;
		dictionary_2[207u] = method_7;
		dictionary_2[208u] = method_33;
		dictionary_2[209u] = method_2;
		dictionary_2[210u] = method_62;
		dictionary_2[211u] = method_43;
		dictionary_2[212u] = method_17;
		dictionary_2[213u] = method_43;
		dictionary_2[214u] = method_2;
		dictionary_2[215u] = method_63;
		dictionary_2[216u] = method_22;
		dictionary_2[217u] = method_33;
		dictionary_2[218u] = method_32;
		dictionary_2[219u] = method_3;
		dictionary_2[220u] = method_60;
		dictionary_2[221u] = method_75;
		dictionary_2[222u] = method_14;
		dictionary_2[223u] = method_32;
		dictionary_2[224u] = method_46;
		dictionary_2[225u] = method_29;
		dictionary_2[226u] = method_32;
		dictionary_2[227u] = method_46;
		dictionary_2[228u] = method_53;
		dictionary_2[229u] = method_12;
		dictionary_2[230u] = method_49;
		dictionary_2[231u] = method_42;
		dictionary_2[232u] = method_10;
		dictionary_2[233u] = method_12;
		dictionary_2[234u] = method_61;
		dictionary_2[235u] = method_4;
		dictionary_2[236u] = method_40;
		dictionary_2[237u] = method_39;
		dictionary_2[238u] = method_68;
		dictionary_2[239u] = method_47;
		dictionary_2[240u] = method_54;
		dictionary_2[241u] = method_23;
		dictionary_2[242u] = method_58;
		dictionary_2[243u] = method_25;
		dictionary_2[244u] = method_32;
		dictionary_2[245u] = method_61;
		dictionary_2[246u] = method_10;
		dictionary_2[247u] = method_33;
		dictionary_2[248u] = method_29;
		dictionary_2[249u] = method_49;
		dictionary_2[250u] = method_13;
		dictionary_2[251u] = method_70;
		dictionary_2[252u] = method_63;
		dictionary_2[253u] = method_41;
		dictionary_2[254u] = method_41;
		dictionary_2[255u] = method_74;
	}
}

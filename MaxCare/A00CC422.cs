using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ <>h__TransparentIdentifier0 = {<>h__TransparentIdentifier0}, value = {value} }", Type = "<Anonymous Type>")]
internal sealed class A00CC422<F21CF329, FB86E39A>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly F21CF329 gparam_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly FB86E39A A31D961E;

	public F21CF329 Prop_0 => gparam_0;

	public FB86E39A Prop_1 => A31D961E;

	[DebuggerHidden]
	public A00CC422(F21CF329 gparam_1, FB86E39A gparam_2)
	{
		gparam_0 = gparam_1;
		A31D961E = gparam_2;
	}

	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		global::A00CC422<F21CF329, FB86E39A> a00CC = obj as global::A00CC422<F21CF329, FB86E39A>;
		return this == a00CC || (a00CC != null && EqualityComparer<F21CF329>.Default.Equals(gparam_0, a00CC.gparam_0) && EqualityComparer<FB86E39A>.Default.Equals(A31D961E, a00CC.A31D961E));
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1251718248 + EqualityComparer<F21CF329>.Default.GetHashCode(gparam_0)) * -1521134295 + EqualityComparer<FB86E39A>.Default.GetHashCode(A31D961E);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		F21CF329 val = gparam_0;
		array[0] = ((val != null) ? val.ToString() : null);
		FB86E39A a31D961E = A31D961E;
		array[1] = ((a31D961E != null) ? a31D961E.ToString() : null);
		return string.Format(null, "{{ <>h__TransparentIdentifier0 = {0}, value = {1} }}", array);
	}
}

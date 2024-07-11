using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ r = {r}, key = {key} }", Type = "<Anonymous Type>")]
internal sealed class B8A27D05<DD0F8F09, T>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly DD0F8F09 BB933080;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T E79F439F;

	public DD0F8F09 Prop_0 => BB933080;

	public T Prop_1 => E79F439F;

	[DebuggerHidden]
	public B8A27D05(DD0F8F09 gparam_0, T gparam_1)
	{
		BB933080 = gparam_0;
		E79F439F = gparam_1;
	}

	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		global::B8A27D05<DD0F8F09, T> b8A27D = obj as global::B8A27D05<DD0F8F09, T>;
		return this == b8A27D || (b8A27D != null && EqualityComparer<DD0F8F09>.Default.Equals(BB933080, b8A27D.BB933080) && EqualityComparer<T>.Default.Equals(E79F439F, b8A27D.E79F439F));
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (822916899 + EqualityComparer<DD0F8F09>.Default.GetHashCode(BB933080)) * -1521134295 + EqualityComparer<T>.Default.GetHashCode(E79F439F);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		DD0F8F09 bB = BB933080;
		array[0] = ((bB != null) ? bB.ToString() : null);
		T e79F439F = E79F439F;
		array[1] = ((e79F439F != null) ? e79F439F.ToString() : null);
		return string.Format(null, "{{ r = {0}, key = {1} }}", array);
	}
}

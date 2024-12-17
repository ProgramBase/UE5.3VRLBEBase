using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FFloatRangeImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatRange_FFloatRangeImplementation(FFloatRange InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatRange_FFloatRange1Implementation(FFloatRange InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatRange_FFloatRange2Implementation(FFloatRange InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatRange_SetLowerBoundValueImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_GetLowerBoundValueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatRange_SetUpperBoundValueImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_GetUpperBoundValueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_HasLowerBoundImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_HasUpperBoundImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_IsDegenerateImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_IsEmptyImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_SplitImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_UnionImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_AllImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_AtLeastImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_AtMostImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatRange_EmptyImplementation(nint InObject);
	}
}
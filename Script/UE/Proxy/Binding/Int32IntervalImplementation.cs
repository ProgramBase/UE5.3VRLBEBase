using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FInt32IntervalImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FInt32Interval_FInt32IntervalImplementation(FInt32Interval InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32Interval_SizeImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32Interval_IsValidImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32Interval_ContainsImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FInt32Interval_ExpandImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FInt32Interval_IncludeImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32Interval_InterpolateImplementation(nint InObject, params object[] InValue);
	}
}
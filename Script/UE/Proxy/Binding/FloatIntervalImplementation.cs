using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FFloatIntervalImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatInterval_FFloatIntervalImplementation(FFloatInterval InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatInterval_SizeImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatInterval_IsValidImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatInterval_ContainsImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatInterval_ExpandImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FFloatInterval_IncludeImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FFloatInterval_InterpolateImplementation(nint InObject, params object[] InValue);
	}
}
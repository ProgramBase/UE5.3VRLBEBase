using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FInt32RangeBoundImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FInt32RangeBound_FInt32RangeBoundImplementation(FInt32RangeBound InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_GetValueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FInt32RangeBound_SetValueImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_IsClosedImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_IsExclusiveImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_IsInclusiveImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_IsOpenImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_ExclusiveImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_InclusiveImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_OpenImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_FlipInclusionImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_MaxLowerImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_MaxUpperImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_MinLowerImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FInt32RangeBound_MinUpperImplementation(nint InObject, params object[] InValue);
	}
}
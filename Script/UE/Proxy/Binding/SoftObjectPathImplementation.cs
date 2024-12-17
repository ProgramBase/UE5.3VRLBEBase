using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FSoftObjectPathImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_FSoftObjectPathImplementation(FSoftObjectPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_FSoftObjectPath1Implementation(FSoftObjectPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_FSoftObjectPath2Implementation(FSoftObjectPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_ToStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetAssetPathNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetAssetPathStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetSubPathStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_SetSubPathStringImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetLongPackageNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetLongPackageFNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetAssetNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_SetPathImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_ResolveObjectImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_ResetImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_IsValidImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_IsNullImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_IsAssetImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_IsSubobjectImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_FixupCoreRedirectsImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetCurrentTagImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_InvalidateTagImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftObjectPath_GetOrCreateIDForObjectImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_AddPIEPackageNameImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftObjectPath_ClearPIEPackageNamesImplementation(nint InObject);
	}
}
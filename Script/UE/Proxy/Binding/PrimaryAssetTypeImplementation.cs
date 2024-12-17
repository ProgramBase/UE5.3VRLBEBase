using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FPrimaryAssetTypeImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPrimaryAssetType_FPrimaryAssetTypeImplementation(FPrimaryAssetType InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetType_GetNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetType_IsValidImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetType_ToStringImplementation(nint InObject);
	}
}
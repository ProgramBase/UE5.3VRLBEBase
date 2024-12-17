using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FPrimaryAssetIdImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName FPrimaryAssetId_GetPrimaryAssetTypeTagImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName FPrimaryAssetId_GetPrimaryAssetNameTagImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPrimaryAssetId_FPrimaryAssetIdImplementation(FPrimaryAssetId InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPrimaryAssetId_FPrimaryAssetId1Implementation(FPrimaryAssetId InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetId_ParseTypeAndNameImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetId_ParseTypeAndName1Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetId_IsValidImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetId_ToStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPrimaryAssetId_FromStringImplementation(nint InObject, params object[] InValue);
	}
}
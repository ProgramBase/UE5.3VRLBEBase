using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FAssetBundleDataImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FAssetBundleData_FAssetBundleDataImplementation(FAssetBundleData InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FAssetBundleData_FindEntryImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FAssetBundleData_ResetImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FAssetBundleData_ToDebugStringImplementation(nint InObject);
	}
}
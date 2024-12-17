using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FAssetBundleEntryImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FAssetBundleEntry_FAssetBundleEntryImplementation(FAssetBundleEntry InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FAssetBundleEntry_FAssetBundleEntry1Implementation(FAssetBundleEntry InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FAssetBundleEntry_IsValidImplementation(nint InObject);
	}
}
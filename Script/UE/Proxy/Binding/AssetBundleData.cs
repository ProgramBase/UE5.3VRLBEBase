using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FAssetBundleData
	{
		public FAssetBundleData(FAssetBundleData InValue0)
		{
			if (GetType() == typeof(FAssetBundleData))
			{
				FAssetBundleDataImplementation.FAssetBundleData_FAssetBundleDataImplementation(this, InValue0?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FAssetBundleEntry FindEntry(FName SearchName)
		{
			return FAssetBundleDataImplementation.FAssetBundleData_FindEntryImplementation(GarbageCollectionHandle, SearchName?.GarbageCollectionHandle ?? nint.Zero) as FAssetBundleEntry;
		}

		public void Reset()
		{
			FAssetBundleDataImplementation.FAssetBundleData_ResetImplementation(GarbageCollectionHandle);
		}

		public FString ToDebugString()
		{
			return FAssetBundleDataImplementation.FAssetBundleData_ToDebugStringImplementation(GarbageCollectionHandle) as FString;
		}
	}
}
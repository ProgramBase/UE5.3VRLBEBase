using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FAssetBundleEntry
	{
		public FAssetBundleEntry(FAssetBundleEntry OldEntry)
		{
			if (GetType() == typeof(FAssetBundleEntry))
			{
				FAssetBundleEntryImplementation.FAssetBundleEntry_FAssetBundleEntryImplementation(this, OldEntry?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FAssetBundleEntry(FName InBundleName)
		{
			if (GetType() == typeof(FAssetBundleEntry))
			{
				FAssetBundleEntryImplementation.FAssetBundleEntry_FAssetBundleEntry1Implementation(this, InBundleName?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public bool IsValid()
		{
			return (bool)FAssetBundleEntryImplementation.FAssetBundleEntry_IsValidImplementation(GarbageCollectionHandle);
		}
	}
}
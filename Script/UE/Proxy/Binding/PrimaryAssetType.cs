using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FPrimaryAssetType
	{
		public FPrimaryAssetType(FName InName)
		{
			if (GetType() == typeof(FPrimaryAssetType))
			{
				FPrimaryAssetTypeImplementation.FPrimaryAssetType_FPrimaryAssetTypeImplementation(this, InName?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FName GetName()
		{
			return FPrimaryAssetTypeImplementation.FPrimaryAssetType_GetNameImplementation(GarbageCollectionHandle) as FName;
		}

		public bool IsValid()
		{
			return (bool)FPrimaryAssetTypeImplementation.FPrimaryAssetType_IsValidImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FPrimaryAssetTypeImplementation.FPrimaryAssetType_ToStringImplementation(GarbageCollectionHandle) as FString;
		}
	}
}
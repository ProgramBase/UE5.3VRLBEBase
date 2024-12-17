using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FPrimaryAssetId
	{
		public static FName PrimaryAssetTypeTag
		{
			get => FPrimaryAssetIdImplementation.FPrimaryAssetId_GetPrimaryAssetTypeTagImplementation(nint.Zero);
		}

		public static FName PrimaryAssetNameTag
		{
			get => FPrimaryAssetIdImplementation.FPrimaryAssetId_GetPrimaryAssetNameTagImplementation(nint.Zero);
		}

		public FPrimaryAssetId(FPrimaryAssetType InAssetType, FName InAssetName)
		{
			if (GetType() == typeof(FPrimaryAssetId))
			{
				FPrimaryAssetIdImplementation.FPrimaryAssetId_FPrimaryAssetIdImplementation(this, InAssetType?.GarbageCollectionHandle ?? nint.Zero, InAssetName?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FPrimaryAssetId(FString TypeAndName)
		{
			if (GetType() == typeof(FPrimaryAssetId))
			{
				FPrimaryAssetIdImplementation.FPrimaryAssetId_FPrimaryAssetId1Implementation(this, TypeAndName?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FPrimaryAssetId ParseTypeAndName(FName TypeAndName)
		{
			return FPrimaryAssetIdImplementation.FPrimaryAssetId_ParseTypeAndNameImplementation(nint.Zero, TypeAndName?.GarbageCollectionHandle ?? nint.Zero) as FPrimaryAssetId;
		}

		public static FPrimaryAssetId ParseTypeAndName(FString TypeAndName)
		{
			return FPrimaryAssetIdImplementation.FPrimaryAssetId_ParseTypeAndName1Implementation(nint.Zero, TypeAndName?.GarbageCollectionHandle ?? nint.Zero) as FPrimaryAssetId;
		}

		public bool IsValid()
		{
			return (bool)FPrimaryAssetIdImplementation.FPrimaryAssetId_IsValidImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FPrimaryAssetIdImplementation.FPrimaryAssetId_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public static FPrimaryAssetId FromString(FString InValue0)
		{
			return FPrimaryAssetIdImplementation.FPrimaryAssetId_FromStringImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FPrimaryAssetId;
		}
	}
}
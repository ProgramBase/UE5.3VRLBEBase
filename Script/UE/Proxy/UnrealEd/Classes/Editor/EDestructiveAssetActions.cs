using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EDestructiveAssetActions")]
	public enum EDestructiveAssetActions : long
	{
		AssetDelete = 0,
		AssetRename = 1,
		AssetMove = 2,
		AssetPrivatize = 4,
	}
}
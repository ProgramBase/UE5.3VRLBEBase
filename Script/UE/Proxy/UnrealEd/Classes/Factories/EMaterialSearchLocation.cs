using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EMaterialSearchLocation")]
	public enum EMaterialSearchLocation : byte
	{
		Local = 0,
		UnderParent = 1,
		UnderRoot = 2,
		AllAssets = 3,
		DoNotSearch = 4,
	}
}
using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ETextAssetCommandletMode")]
	public enum ETextAssetCommandletMode : long
	{
		ResaveText = 0,
		ResaveBinary = 1,
		RoundTrip = 2,
		LoadBinary = 3,
		LoadText = 4,
		FindMismatchedSerializers = 5,
		GenerateSchema = 6,
	}
}
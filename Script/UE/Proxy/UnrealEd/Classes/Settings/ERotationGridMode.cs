using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ERotationGridMode")]
	public enum ERotationGridMode : byte
	{
		GridMode_DivisionsOf360 = 0,
		GridMode_Common = 1,
	}
}
using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayOnPakFileMode")]
	public enum EPlayOnPakFileMode : byte
	{
		NoPak = 0,
		PakNoCompress = 1,
		PakCompress = 2,
	}
}
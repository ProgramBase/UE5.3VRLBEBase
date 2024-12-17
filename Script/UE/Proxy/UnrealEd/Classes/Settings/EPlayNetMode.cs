using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayNetMode")]
	public enum EPlayNetMode : byte
	{
		PIE_Standalone = 0,
		PIE_ListenServer = 1,
		PIE_Client = 2,
	}
}
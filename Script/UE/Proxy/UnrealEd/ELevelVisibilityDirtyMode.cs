using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ELevelVisibilityDirtyMode")]
	public enum ELevelVisibilityDirtyMode : byte
	{
		ModifyOnChange = 0,
		DontModify = 1,
	}
}
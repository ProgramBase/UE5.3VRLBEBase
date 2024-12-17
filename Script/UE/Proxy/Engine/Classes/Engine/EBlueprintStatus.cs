using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlueprintStatus")]
	public enum EBlueprintStatus : byte
	{
		BS_Unknown = 0,
		BS_Dirty = 1,
		BS_Error = 2,
		BS_UpToDate = 3,
		BS_BeingCreated = 4,
		BS_UpToDateWithWarnings = 5,
	}
}
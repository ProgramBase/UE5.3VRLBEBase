using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeDirtyingMode")]
	public enum ELandscapeDirtyingMode : byte
	{
		Auto = 0,
		InLandscapeModeOnly = 1,
		InLandscapeModeAndUserTriggeredChanges = 2,
	}
}
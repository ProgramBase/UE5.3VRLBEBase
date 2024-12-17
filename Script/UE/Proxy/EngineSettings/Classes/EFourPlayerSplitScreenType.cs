using Script.CoreUObject;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.EFourPlayerSplitScreenType")]
	public enum EFourPlayerSplitScreenType : byte
	{
		Grid = 0,
		Vertical = 1,
		Horizontal = 2,
	}
}
using Script.CoreUObject;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.EThreePlayerSplitScreenType")]
	public enum EThreePlayerSplitScreenType : byte
	{
		FavorTop = 0,
		FavorBottom = 1,
		Vertical = 2,
		Horizontal = 3,
	}
}
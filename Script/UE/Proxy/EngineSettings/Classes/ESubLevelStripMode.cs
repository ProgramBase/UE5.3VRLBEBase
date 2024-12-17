using Script.CoreUObject;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.ESubLevelStripMode")]
	public enum ESubLevelStripMode : long
	{
		ExactClass = 0,
		IsChildOf = 1,
	}
}
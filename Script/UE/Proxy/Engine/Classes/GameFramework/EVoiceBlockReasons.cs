using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVoiceBlockReasons")]
	public enum EVoiceBlockReasons : long
	{
		None = 0,
		Muted = 1,
		Gameplay = 2,
		Blocked = 4,
		BlockedBy = 8,
	}
}
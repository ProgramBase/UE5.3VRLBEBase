using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVirtualizationMode")]
	public enum EVirtualizationMode : byte
	{
		Disabled = 0,
		PlayWhenSilent = 1,
		Restart = 2,
	}
}
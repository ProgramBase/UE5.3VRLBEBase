using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENaturalSoundFalloffMode")]
	public enum ENaturalSoundFalloffMode : byte
	{
		Continues = 0,
		Silent = 1,
		Hold = 2,
	}
}
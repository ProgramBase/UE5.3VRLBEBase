using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioComponentPlayState")]
	public enum EAudioComponentPlayState : byte
	{
		Playing = 0,
		Stopped = 1,
		Paused = 2,
		FadingIn = 3,
		FadingOut = 4,
		Count = 5,
	}
}
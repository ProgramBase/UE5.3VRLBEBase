using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWindowMode")]
	public enum EWindowMode : byte
	{
		Fullscreen = 0,
		WindowedFullscreen = 1,
		Windowed = 2,
	}
}
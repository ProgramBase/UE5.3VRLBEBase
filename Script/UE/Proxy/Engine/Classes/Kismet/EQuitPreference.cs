using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuitPreference")]
	public enum EQuitPreference : byte
	{
		Quit = 0,
		Background = 1,
	}
}
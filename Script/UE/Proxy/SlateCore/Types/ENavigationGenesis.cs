using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ENavigationGenesis")]
	public enum ENavigationGenesis : byte
	{
		Keyboard = 0,
		Controller = 1,
		User = 2,
	}
}
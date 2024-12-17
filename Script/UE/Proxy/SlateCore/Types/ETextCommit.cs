using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ETextCommit")]
	public enum ETextCommit : byte
	{
		Default = 0,
		OnEnter = 1,
		OnUserMovedFocus = 2,
		OnCleared = 3,
	}
}
using Script.CoreUObject;

namespace Script.InputCore
{
	[PathName("/Script/InputCore.ETouchType")]
	public enum ETouchType : long
	{
		Began = 0,
		Moved = 1,
		Stationary = 2,
		ForceChanged = 3,
		FirstMove = 4,
		Ended = 5,
		NumTypes = 6,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESlateGesture")]
	public enum ESlateGesture : byte
	{
		None = 0,
		Scroll = 1,
		Magnify = 2,
		Swipe = 3,
		Rotate = 4,
		LongPress = 5,
	}
}
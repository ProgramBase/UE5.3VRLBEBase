using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPinHidingMode")]
	public enum EPinHidingMode : long
	{
		NeverAsPin = 0,
		PinHiddenByDefault = 1,
		PinShownByDefault = 2,
		AlwaysAsPin = 3,
	}
}
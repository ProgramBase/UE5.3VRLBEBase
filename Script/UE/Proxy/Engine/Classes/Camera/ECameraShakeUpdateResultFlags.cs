using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECameraShakeUpdateResultFlags")]
	public enum ECameraShakeUpdateResultFlags : long
	{
		ApplyAsAbsolute = 1,
		SkipAutoScale = 2,
		SkipAutoPlaySpace = 4,
		Default = 0,
	}
}
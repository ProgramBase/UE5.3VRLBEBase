using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EScreenPercentageMode")]
	public enum EScreenPercentageMode : int
	{
		Manual = 0,
		BasedOnDisplayResolution = 1,
		BasedOnDPIScale = 2,
	}
}
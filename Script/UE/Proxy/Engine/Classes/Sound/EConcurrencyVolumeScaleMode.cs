using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EConcurrencyVolumeScaleMode")]
	public enum EConcurrencyVolumeScaleMode : int
	{
		Default = 0,
		Distance = 1,
		Priority = 2,
	}
}
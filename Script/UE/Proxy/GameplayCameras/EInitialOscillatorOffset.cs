using Script.CoreUObject;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.EInitialOscillatorOffset")]
	public enum EInitialOscillatorOffset : byte
	{
		EOO_OffsetRandom = 0,
		EOO_OffsetZero = 1,
	}
}
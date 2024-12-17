using Script.CoreUObject;

namespace Script.AudioPlatformConfiguration
{
	[PathName("/Script/AudioPlatformConfiguration.ESoundwaveSampleRateSettings")]
	public enum ESoundwaveSampleRateSettings : byte
	{
		Max = 0,
		High = 1,
		Medium = 2,
		Low = 3,
		Min = 4,
		MatchDevice_DEPRECATED = 5,
	}
}
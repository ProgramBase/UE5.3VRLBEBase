using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESubmixEffectDynamicsPeakMode")]
	public enum ESubmixEffectDynamicsPeakMode : byte
	{
		MeanSquared = 0,
		RootMeanSquared = 1,
		Peak = 2,
		Count = 3,
	}
}
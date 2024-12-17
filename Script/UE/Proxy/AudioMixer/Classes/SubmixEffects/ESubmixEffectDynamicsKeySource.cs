using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESubmixEffectDynamicsKeySource")]
	public enum ESubmixEffectDynamicsKeySource : byte
	{
		Default = 0,
		AudioBus = 1,
		Submix = 2,
		Count = 3,
	}
}
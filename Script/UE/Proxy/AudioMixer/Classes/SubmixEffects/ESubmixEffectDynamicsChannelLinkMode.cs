using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESubmixEffectDynamicsChannelLinkMode")]
	public enum ESubmixEffectDynamicsChannelLinkMode : byte
	{
		Disabled = 0,
		Average = 1,
		Peak = 2,
		Count = 3,
	}
}
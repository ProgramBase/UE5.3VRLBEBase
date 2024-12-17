using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.EAudioMixerStreamDataFormatType")]
	public enum EAudioMixerStreamDataFormatType : byte
	{
		Unknown = 0,
		Float = 1,
		Int16 = 2,
		Unsupported = 3,
	}
}
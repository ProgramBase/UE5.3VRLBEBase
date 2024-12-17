using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESubmixEffectDynamicsProcessorType")]
	public enum ESubmixEffectDynamicsProcessorType : byte
	{
		Compressor = 0,
		Limiter = 1,
		Expander = 2,
		Gate = 3,
		UpwardsCompressor = 4,
		Count = 5,
	}
}
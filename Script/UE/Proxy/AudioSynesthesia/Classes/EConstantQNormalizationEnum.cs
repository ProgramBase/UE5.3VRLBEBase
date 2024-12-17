using Script.CoreUObject;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.EConstantQNormalizationEnum")]
	public enum EConstantQNormalizationEnum : byte
	{
		EqualEuclideanNorm = 0,
		EqualEnergy = 1,
		EqualAmplitude = 2,
	}
}
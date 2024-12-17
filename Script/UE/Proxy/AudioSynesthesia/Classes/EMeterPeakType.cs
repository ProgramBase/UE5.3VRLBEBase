using Script.CoreUObject;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.EMeterPeakType")]
	public enum EMeterPeakType : byte
	{
		MeanSquared = 0,
		RootMeanSquared = 1,
		Peak = 2,
		Count = 3,
	}
}
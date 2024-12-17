using Script.CoreUObject;

namespace Script.WaveTable
{
	[PathName("/Script/WaveTable.EWaveTableSamplingMode")]
	public enum EWaveTableSamplingMode : byte
	{
		FixedSampleRate = 0,
		FixedResolution = 1,
		COUNT = 2,
	}
}
using Script.CoreUObject;

namespace Script.WaveTable
{
	[PathName("/Script/WaveTable.EWaveTableBitDepth")]
	public enum EWaveTableBitDepth : byte
	{
		PCM_16 = 0,
		IEEE_Float = 1,
		COUNT = 2,
	}
}
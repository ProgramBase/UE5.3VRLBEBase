using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBloomMethod")]
	public enum EBloomMethod : byte
	{
		BM_SOG = 0,
		BM_FFT = 1,
	}
}
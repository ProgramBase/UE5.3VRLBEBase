using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESubmixEffectConvolutionReverbBlockSize")]
	public enum ESubmixEffectConvolutionReverbBlockSize : byte
	{
		BlockSize256 = 0,
		BlockSize512 = 1,
		BlockSize1024 = 2,
	}
}
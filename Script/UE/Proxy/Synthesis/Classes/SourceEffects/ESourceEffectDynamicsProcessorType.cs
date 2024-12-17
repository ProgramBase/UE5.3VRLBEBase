using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESourceEffectDynamicsProcessorType")]
	public enum ESourceEffectDynamicsProcessorType : byte
	{
		Compressor = 0,
		Limiter = 1,
		Expander = 2,
		Gate = 3,
		UpwardsCompressor = 4,
		Count = 5,
	}
}
using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthModEnvPatch")]
	public enum ESynthModEnvPatch : byte
	{
		PatchToNone = 0,
		PatchToOscFreq = 1,
		PatchToFilterFreq = 2,
		PatchToFilterQ = 3,
		PatchToLFO1Gain = 4,
		PatchToLFO2Gain = 5,
		PatchToLFO1Freq = 6,
		PatchToLFO2Freq = 7,
		Count = 8,
	}
}
using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthLFOPatchType")]
	public enum ESynthLFOPatchType : byte
	{
		PatchToNone = 0,
		PatchToGain = 1,
		PatchToOscFreq = 2,
		PatchToFilterFreq = 3,
		PatchToFilterQ = 4,
		PatchToOscPulseWidth = 5,
		PatchToOscPan = 6,
		PatchLFO1ToLFO2Frequency = 7,
		PatchLFO1ToLFO2Gain = 8,
		Count = 9,
	}
}
using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynth1PatchSource")]
	public enum ESynth1PatchSource : byte
	{
		LFO1 = 0,
		LFO2 = 1,
		Envelope = 2,
		BiasEnvelope = 3,
		Count = 4,
	}
}
using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynth1OscType")]
	public enum ESynth1OscType : byte
	{
		Sine = 0,
		Saw = 1,
		Triangle = 2,
		Square = 3,
		Noise = 4,
		Count = 5,
	}
}
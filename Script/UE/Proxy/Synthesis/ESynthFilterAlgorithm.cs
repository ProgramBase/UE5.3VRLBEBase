using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthFilterAlgorithm")]
	public enum ESynthFilterAlgorithm : byte
	{
		OnePole = 0,
		StateVariable = 1,
		Ladder = 2,
		Count = 3,
	}
}
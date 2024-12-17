using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESubmixFilterAlgorithm")]
	public enum ESubmixFilterAlgorithm : byte
	{
		OnePole = 0,
		StateVariable = 1,
		Ladder = 2,
		Count = 3,
	}
}
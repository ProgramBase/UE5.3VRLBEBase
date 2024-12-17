using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EWaveFunctionType")]
	public enum EWaveFunctionType : byte
	{
		Field_Wave_Cosine = 0,
		Field_Wave_Gaussian = 1,
		Field_Wave_Falloff = 2,
		Field_Wave_Decay = 3,
		Field_Wave_Max = 4,
	}
}
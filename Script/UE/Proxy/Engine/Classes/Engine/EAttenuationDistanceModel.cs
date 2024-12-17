using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAttenuationDistanceModel")]
	public enum EAttenuationDistanceModel : byte
	{
		Linear = 0,
		Logarithmic = 1,
		Inverse = 2,
		LogReverse = 3,
		NaturalSound = 4,
		Custom = 5,
	}
}
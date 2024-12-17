using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ECSGOperation")]
	public enum ECSGOperation : byte
	{
		DifferenceAB = 0,
		DifferenceBA = 1,
		Intersect = 2,
		Union = 3,
	}
}
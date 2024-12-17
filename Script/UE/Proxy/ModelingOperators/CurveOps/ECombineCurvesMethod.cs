using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ECombineCurvesMethod")]
	public enum ECombineCurvesMethod : byte
	{
		LeaveSeparate = 0,
		Union = 1,
		Intersect = 2,
		Difference = 3,
		ExclusiveOr = 4,
	}
}
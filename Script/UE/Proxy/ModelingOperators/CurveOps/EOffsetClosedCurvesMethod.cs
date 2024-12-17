using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EOffsetClosedCurvesMethod")]
	public enum EOffsetClosedCurvesMethod : byte
	{
		DoNotOffset = 0,
		OffsetOuterSide = 1,
		OffsetBothSides = 2,
	}
}
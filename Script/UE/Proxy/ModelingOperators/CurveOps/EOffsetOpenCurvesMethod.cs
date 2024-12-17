using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EOffsetOpenCurvesMethod")]
	public enum EOffsetOpenCurvesMethod : byte
	{
		TreatAsClosed = 0,
		Offset = 1,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESplinePointType")]
	public enum ESplinePointType : byte
	{
		Linear = 0,
		Curve = 1,
		Constant = 2,
		CurveClamped = 3,
		CurveCustomTangent = 4,
	}
}
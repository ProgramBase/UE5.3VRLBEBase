using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimCurveType")]
	public enum EAnimCurveType : byte
	{
		AttributeCurve = 0,
		MaterialCurve = 1,
		MorphTargetCurve = 2,
		MaxAnimCurveType = 3,
	}
}
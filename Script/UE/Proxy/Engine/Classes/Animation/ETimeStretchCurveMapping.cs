using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETimeStretchCurveMapping")]
	public enum ETimeStretchCurveMapping : long
	{
		T_Original = 0,
		T_TargetMin = 1,
		T_TargetMax = 2,
	}
}
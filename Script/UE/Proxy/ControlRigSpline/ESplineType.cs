using Script.CoreUObject;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.ESplineType")]
	public enum ESplineType : byte
	{
		BSpline = 0,
		Hermite = 1,
		Max = 2,
	}
}
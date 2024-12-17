using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.CurveInterpolationType")]
	public enum CurveInterpolationType : byte
	{
		AUTOINTERP = 0,
		LINEAR = 1,
		CONSTANT = 2,
	}
}
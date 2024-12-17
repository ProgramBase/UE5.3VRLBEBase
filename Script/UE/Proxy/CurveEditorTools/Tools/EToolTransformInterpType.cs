using Script.CoreUObject;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.EToolTransformInterpType")]
	public enum EToolTransformInterpType : byte
	{
		Linear = 0,
		Sinusoidal = 1,
		Cubic = 2,
		CircularIn = 3,
		CircularOut = 4,
		ExpIn = 5,
		ExpOut = 6,
	}
}
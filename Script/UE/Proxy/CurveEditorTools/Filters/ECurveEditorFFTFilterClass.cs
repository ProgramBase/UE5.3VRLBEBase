using Script.CoreUObject;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.ECurveEditorFFTFilterClass")]
	public enum ECurveEditorFFTFilterClass : byte
	{
		Butterworth = 0,
		Chebyshev = 1,
	}
}
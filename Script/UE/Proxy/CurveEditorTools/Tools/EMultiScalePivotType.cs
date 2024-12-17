using Script.CoreUObject;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.EMultiScalePivotType")]
	public enum EMultiScalePivotType : byte
	{
		Average = 0,
		BoundCenter = 1,
		FirstKey = 2,
		LastKey = 3,
	}
}
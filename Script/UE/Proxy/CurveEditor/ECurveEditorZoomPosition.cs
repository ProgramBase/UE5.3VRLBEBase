using Script.CoreUObject;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.ECurveEditorZoomPosition")]
	public enum ECurveEditorZoomPosition : byte
	{
		CurrentTime = 0,
		MousePosition = 1,
	}
}
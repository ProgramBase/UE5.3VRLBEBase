using Script.CoreUObject;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.ECurveEditorTangentVisibility")]
	public enum ECurveEditorTangentVisibility : byte
	{
		AllTangents = 0,
		SelectedKeys = 1,
		NoTangents = 2,
	}
}
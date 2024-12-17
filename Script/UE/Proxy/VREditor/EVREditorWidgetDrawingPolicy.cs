using Script.CoreUObject;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.EVREditorWidgetDrawingPolicy")]
	public enum EVREditorWidgetDrawingPolicy : byte
	{
		Always = 0,
		Hovering = 1,
	}
}
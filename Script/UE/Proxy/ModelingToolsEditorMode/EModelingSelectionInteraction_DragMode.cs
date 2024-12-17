using Script.CoreUObject;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.EModelingSelectionInteraction_DragMode")]
	public enum EModelingSelectionInteraction_DragMode : long
	{
		NoDragInteraction = 0,
		PathInteraction = 1,
		RectangleMarqueeInteraction = 2,
	}
}
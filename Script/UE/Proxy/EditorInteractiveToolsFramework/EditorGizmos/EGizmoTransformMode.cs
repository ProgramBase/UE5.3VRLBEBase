using Script.CoreUObject;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EGizmoTransformMode")]
	public enum EGizmoTransformMode : byte
	{
		None = 0,
		Translate = 1,
		Rotate = 2,
		Scale = 3,
		Max = 4,
	}
}
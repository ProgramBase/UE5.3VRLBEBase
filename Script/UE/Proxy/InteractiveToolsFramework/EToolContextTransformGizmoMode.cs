using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EToolContextTransformGizmoMode")]
	public enum EToolContextTransformGizmoMode : byte
	{
		NoGizmo = 0,
		Translation = 1,
		Rotation = 2,
		Scale = 3,
		Combined = 8,
	}
}
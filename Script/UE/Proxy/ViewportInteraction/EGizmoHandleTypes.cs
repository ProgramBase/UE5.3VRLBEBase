using Script.CoreUObject;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.EGizmoHandleTypes")]
	public enum EGizmoHandleTypes : byte
	{
		All = 0,
		Translate = 1,
		Rotate = 2,
		Scale = 3,
	}
}
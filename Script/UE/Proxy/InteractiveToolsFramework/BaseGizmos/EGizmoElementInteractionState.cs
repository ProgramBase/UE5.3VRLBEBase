using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EGizmoElementInteractionState")]
	public enum EGizmoElementInteractionState : int
	{
		None = 0,
		Hovering = 1,
		Interacting = 2,
	}
}
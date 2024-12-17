using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EGizmoElementState")]
	public enum EGizmoElementState : byte
	{
		None = 0,
		Visible = 2,
		Hittable = 4,
		VisibleAndHittable = 6,
	}
}
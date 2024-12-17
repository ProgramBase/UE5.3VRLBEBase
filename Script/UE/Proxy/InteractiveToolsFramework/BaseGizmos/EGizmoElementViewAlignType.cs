using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EGizmoElementViewAlignType")]
	public enum EGizmoElementViewAlignType : int
	{
		None = 0,
		PointOnly = 1,
		PointEye = 2,
		PointScreen = 3,
		Axial = 4,
	}
}
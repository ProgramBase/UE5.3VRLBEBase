using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EInputCaptureSide")]
	public enum EInputCaptureSide : long
	{
		None = 0,
		Left = 1,
		Right = 2,
		Both = 3,
		Any = 99,
	}
}
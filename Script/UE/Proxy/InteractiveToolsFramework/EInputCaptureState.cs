using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EInputCaptureState")]
	public enum EInputCaptureState : long
	{
		Begin = 1,
		Continue = 2,
		End = 3,
		Ignore = 4,
	}
}
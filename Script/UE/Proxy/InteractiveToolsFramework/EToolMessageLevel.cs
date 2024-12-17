using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EToolMessageLevel")]
	public enum EToolMessageLevel : long
	{
		Internal = 0,
		UserMessage = 1,
		UserNotification = 2,
		UserWarning = 3,
		UserError = 4,
	}
}
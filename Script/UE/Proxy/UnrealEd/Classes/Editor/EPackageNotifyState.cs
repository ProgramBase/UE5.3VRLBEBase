using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPackageNotifyState")]
	public enum EPackageNotifyState : long
	{
		NS_Updating = 0,
		NS_BalloonPrompted = 1,
		NS_DialogPrompted = 2,
		NS_PendingPrompt = 3,
		NS_PendingWarning = 4,
	}
}
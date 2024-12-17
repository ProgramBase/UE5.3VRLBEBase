using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EToolChangeTrackingMode")]
	public enum EToolChangeTrackingMode : long
	{
		NoChangeTracking = 1,
		UndoToExit = 2,
		FullUndoRedo = 3,
	}
}
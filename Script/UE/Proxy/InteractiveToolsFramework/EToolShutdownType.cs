using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EToolShutdownType")]
	public enum EToolShutdownType : long
	{
		Completed = 0,
		Accept = 1,
		Cancel = 2,
	}
}
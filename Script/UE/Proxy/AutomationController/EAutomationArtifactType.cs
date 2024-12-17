using Script.CoreUObject;

namespace Script.AutomationController
{
	[PathName("/Script/AutomationController.EAutomationArtifactType")]
	public enum EAutomationArtifactType : byte
	{
		None = 0,
		Image = 1,
		Comparison = 2,
	}
}
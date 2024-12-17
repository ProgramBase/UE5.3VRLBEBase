using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EBlueprintComponentDataCookingMethod")]
	public enum EBlueprintComponentDataCookingMethod : int
	{
		Disabled = 0,
		AllBlueprints = 1,
		EnabledBlueprintsOnly = 2,
	}
}
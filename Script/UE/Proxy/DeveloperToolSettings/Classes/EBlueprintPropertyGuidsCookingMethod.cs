using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EBlueprintPropertyGuidsCookingMethod")]
	public enum EBlueprintPropertyGuidsCookingMethod : int
	{
		Disabled = 0,
		AllBlueprints = 1,
		EnabledBlueprintsOnly = 2,
	}
}
using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.ECookProgressDisplayMode")]
	public enum ECookProgressDisplayMode : int
	{
		Nothing = 0,
		RemainingPackages = 1,
		PackageNames = 2,
		NamesAndRemainingPackages = 3,
		Instigators = 4,
		InstigatorsAndCount = 5,
		InstigatorsAndNames = 6,
		InstigatorsAndNamesAndCount = 7,
		Max = 8,
	}
}
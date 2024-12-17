using Script.CoreUObject;

namespace Script.Localization
{
	[PathName("/Script/Localization.ELocalizationGatherPathRoot")]
	public enum ELocalizationGatherPathRoot : byte
	{
		Auto = 0,
		Engine = 1,
		Project = 2,
	}
}
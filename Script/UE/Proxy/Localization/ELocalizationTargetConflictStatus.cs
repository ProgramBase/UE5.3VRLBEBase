using Script.CoreUObject;

namespace Script.Localization
{
	[PathName("/Script/Localization.ELocalizationTargetConflictStatus")]
	public enum ELocalizationTargetConflictStatus : byte
	{
		Unknown = 0,
		ConflictsPresent = 1,
		Clear = 2,
	}
}
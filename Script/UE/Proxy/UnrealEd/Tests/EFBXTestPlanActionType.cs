using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXTestPlanActionType")]
	public enum EFBXTestPlanActionType : byte
	{
		Import = 0,
		Reimport = 1,
		AddLOD = 2,
		ReimportLOD = 3,
		ImportReload = 4,
		AddAlternateSkinnig = 5,
	}
}
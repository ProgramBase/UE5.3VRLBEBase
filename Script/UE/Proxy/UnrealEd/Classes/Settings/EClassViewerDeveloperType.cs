using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EClassViewerDeveloperType")]
	public enum EClassViewerDeveloperType : byte
	{
		CVDT_None = 0,
		CVDT_CurrentUser = 1,
		CVDT_All = 2,
		CVDT_Max = 3,
	}
}
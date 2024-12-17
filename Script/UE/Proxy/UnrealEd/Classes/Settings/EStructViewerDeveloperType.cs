using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EStructViewerDeveloperType")]
	public enum EStructViewerDeveloperType : byte
	{
		SVDT_None = 0,
		SVDT_CurrentUser = 1,
		SVDT_All = 2,
		SVDT_Max = 3,
	}
}
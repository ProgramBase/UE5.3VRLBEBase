using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeImportExportMode")]
	public enum ELandscapeImportExportMode : int
	{
		LoadedOnly = 0,
		All = 1,
	}
}
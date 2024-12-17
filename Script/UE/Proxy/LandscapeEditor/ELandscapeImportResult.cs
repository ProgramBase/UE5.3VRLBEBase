using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeImportResult")]
	public enum ELandscapeImportResult : byte
	{
		Success = 0,
		Warning = 1,
		Error = 2,
	}
}
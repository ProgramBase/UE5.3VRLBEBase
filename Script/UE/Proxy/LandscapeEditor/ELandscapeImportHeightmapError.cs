using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeImportHeightmapError")]
	public enum ELandscapeImportHeightmapError : long
	{
		None = 0,
		FileNotFound = 1,
		InvalidSize = 2,
		CorruptFile = 3,
		ColorPng = 4,
		LowBitDepth = 5,
	}
}
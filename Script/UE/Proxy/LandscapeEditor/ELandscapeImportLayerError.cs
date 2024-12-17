using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeImportLayerError")]
	public enum ELandscapeImportLayerError : long
	{
		None = 0,
		MissingLayerInfo = 1,
		FileNotFound = 2,
		FileSizeMismatch = 3,
		CorruptFile = 4,
		ColorPng = 5,
	}
}
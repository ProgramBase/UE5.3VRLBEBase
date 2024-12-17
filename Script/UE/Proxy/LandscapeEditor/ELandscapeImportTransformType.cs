using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeImportTransformType")]
	public enum ELandscapeImportTransformType : sbyte
	{
		None = 0,
		ExpandOffset = 1,
		ExpandCentered = 2,
		Resample = 3,
		Subregion = 4,
	}
}
using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.EBakeTextureSamplesPerPixel")]
	public enum EBakeTextureSamplesPerPixel : int
	{
		Sample1 = 1,
		Sample4 = 4,
		Sample16 = 16,
		Sample64 = 64,
		Sample256 = 256,
	}
}
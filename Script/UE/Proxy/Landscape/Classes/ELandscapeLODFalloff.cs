using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeLODFalloff")]
	public enum ELandscapeLODFalloff : long
	{
		Linear = 0,
		SquareRoot = 1,
	}
}
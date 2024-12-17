using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENaniteFallbackTarget")]
	public enum ENaniteFallbackTarget : byte
	{
		Auto = 0,
		PercentTriangles = 1,
		RelativeError = 2,
	}
}
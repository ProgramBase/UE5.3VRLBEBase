using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERefractionMode")]
	public enum ERefractionMode : byte
	{
		RM_IndexOfRefraction = 0,
		RM_PixelNormalOffset = 1,
		RM_2DOffset = 2,
		RM_None = 3,
	}
}
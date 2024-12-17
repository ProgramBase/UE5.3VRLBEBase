using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EReflectionSourceType")]
	public enum EReflectionSourceType : byte
	{
		CapturedScene = 0,
		SpecifiedCubemap = 1,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESkyLightSourceType")]
	public enum ESkyLightSourceType : byte
	{
		SLS_CapturedScene = 0,
		SLS_SpecifiedCubemap = 1,
	}
}
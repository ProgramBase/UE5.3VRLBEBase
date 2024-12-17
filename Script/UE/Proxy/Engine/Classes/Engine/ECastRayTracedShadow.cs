using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECastRayTracedShadow")]
	public enum ECastRayTracedShadow : byte
	{
		Disabled = 0,
		UseProjectSetting = 1,
		Enabled = 2,
	}
}
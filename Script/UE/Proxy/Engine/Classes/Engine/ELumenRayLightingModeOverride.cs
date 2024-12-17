using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELumenRayLightingModeOverride")]
	public enum ELumenRayLightingModeOverride : byte
	{
		Default = 0,
		SurfaceCache = 1,
		HitLighting = 2,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELumenRayLightingMode")]
	public enum ELumenRayLightingMode : byte
	{
		SurfaceCache = 0,
		HitLighting = 2,
	}
}
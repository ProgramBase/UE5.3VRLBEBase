using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EReflectedAndRefractedRayTracedShadows")]
	public enum EReflectedAndRefractedRayTracedShadows : byte
	{
		Disabled = 0,
		Hard_shadows = 1,
		Area_shadows = 2,
	}
}
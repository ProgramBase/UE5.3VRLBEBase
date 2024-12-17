using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESkyAtmosphereTransformMode")]
	public enum ESkyAtmosphereTransformMode : byte
	{
		PlanetTopAtAbsoluteWorldOrigin = 0,
		PlanetTopAtComponentTransform = 1,
		PlanetCenterAtComponentTransform = 2,
	}
}
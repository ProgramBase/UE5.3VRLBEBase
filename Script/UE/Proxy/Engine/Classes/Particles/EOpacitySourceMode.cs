using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOpacitySourceMode")]
	public enum EOpacitySourceMode : byte
	{
		OSM_Alpha = 0,
		OSM_ColorBrightness = 1,
		OSM_RedChannel = 2,
		OSM_GreenChannel = 3,
		OSM_BlueChannel = 4,
	}
}
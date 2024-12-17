using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETranslucencyLightingMode")]
	public enum ETranslucencyLightingMode : byte
	{
		TLM_VolumetricNonDirectional = 0,
		TLM_VolumetricDirectional = 1,
		TLM_VolumetricPerVertexNonDirectional = 2,
		TLM_VolumetricPerVertexDirectional = 3,
		TLM_Surface = 4,
		TLM_SurfacePerPixelLighting = 5,
	}
}
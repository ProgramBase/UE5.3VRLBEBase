using Script.CoreUObject;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.EInterchangeMaterialXShaders")]
	public enum EInterchangeMaterialXShaders : byte
	{
		StandardSurface = 0,
		StandardSurfaceTransmission = 1,
		SurfaceUnlit = 2,
		UsdPreviewSurface = 3,
		MaxShaderCount = 4,
	}
}
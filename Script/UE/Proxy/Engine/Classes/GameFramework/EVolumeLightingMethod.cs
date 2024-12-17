using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVolumeLightingMethod")]
	public enum EVolumeLightingMethod : byte
	{
		VLM_VolumetricLightmap = 0,
		VLM_SparseVolumeLightingSamples = 1,
	}
}
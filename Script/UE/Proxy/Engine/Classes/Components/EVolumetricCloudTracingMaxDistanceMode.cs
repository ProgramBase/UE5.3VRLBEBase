using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVolumetricCloudTracingMaxDistanceMode")]
	public enum EVolumetricCloudTracingMaxDistanceMode : byte
	{
		DistanceFromCloudLayerEntryPoint = 0,
		DistanceFromPointOfView = 1,
	}
}
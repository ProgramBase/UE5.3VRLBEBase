using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETrailsRenderAxisOption")]
	public enum ETrailsRenderAxisOption : byte
	{
		Trails_CameraUp = 0,
		Trails_SourceUp = 1,
		Trails_WorldUp = 2,
	}
}
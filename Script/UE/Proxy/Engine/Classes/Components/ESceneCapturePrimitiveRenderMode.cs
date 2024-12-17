using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESceneCapturePrimitiveRenderMode")]
	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		PRM_LegacySceneCapture = 0,
		PRM_RenderScenePrimitives = 1,
		PRM_UseShowOnlyList = 2,
	}
}
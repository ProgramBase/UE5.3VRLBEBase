using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESceneCaptureSource")]
	public enum ESceneCaptureSource : byte
	{
		SCS_SceneColorHDR = 0,
		SCS_SceneColorHDRNoAlpha = 1,
		SCS_FinalColorLDR = 2,
		SCS_SceneColorSceneDepth = 3,
		SCS_SceneDepth = 4,
		SCS_DeviceDepth = 5,
		SCS_Normal = 6,
		SCS_BaseColor = 7,
		SCS_FinalColorHDR = 8,
		SCS_FinalToneCurveHDR = 9,
	}
}
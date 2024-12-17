using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESceneCaptureCompositeMode")]
	public enum ESceneCaptureCompositeMode : byte
	{
		SCCM_Overwrite = 0,
		SCCM_Additive = 1,
		SCCM_Composite = 2,
	}
}
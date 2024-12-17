using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERichCurveTangentMode")]
	public enum ERichCurveTangentMode : byte
	{
		RCTM_Auto = 0,
		RCTM_User = 1,
		RCTM_Break = 2,
		RCTM_None = 3,
		RCTM_SmartAuto = 4,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERichCurveInterpMode")]
	public enum ERichCurveInterpMode : byte
	{
		RCIM_Linear = 0,
		RCIM_Constant = 1,
		RCIM_Cubic = 2,
		RCIM_None = 3,
	}
}
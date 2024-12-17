using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EViewStatusForScreenPercentage")]
	public enum EViewStatusForScreenPercentage : long
	{
		NonRealtime = 0,
		Desktop = 1,
		Mobile = 2,
		VR = 3,
		PathTracer = 4,
	}
}
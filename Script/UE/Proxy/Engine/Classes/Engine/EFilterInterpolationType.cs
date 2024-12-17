using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFilterInterpolationType")]
	public enum EFilterInterpolationType : byte
	{
		BSIT_Average = 0,
		BSIT_Linear = 1,
		BSIT_Cubic = 2,
		BSIT_EaseInOut = 3,
		BSIT_ExponentialDecay = 4,
		BSIT_SpringDamper = 5,
	}
}
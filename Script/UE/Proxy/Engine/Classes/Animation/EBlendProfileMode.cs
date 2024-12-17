using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlendProfileMode")]
	public enum EBlendProfileMode : byte
	{
		TimeFactor = 0,
		WeightFactor = 1,
		BlendMask = 2,
	}
}
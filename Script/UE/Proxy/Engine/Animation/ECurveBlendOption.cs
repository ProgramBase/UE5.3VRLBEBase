using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECurveBlendOption")]
	public enum ECurveBlendOption : byte
	{
		Override = 0,
		DoNotOverride = 1,
		NormalizeByWeight = 2,
		BlendByWeight = 3,
		UseBasePose = 4,
		UseMaxValue = 5,
		UseMinValue = 6,
	}
}
using Script.CoreUObject;

namespace Script.InterchangeCommonParser
{
	[PathName("/Script/InterchangeCommonParser.EInterchangeCurveInterpMode")]
	public enum EInterchangeCurveInterpMode : byte
	{
		Linear = 0,
		Constant = 1,
		Cubic = 2,
		None = 3,
	}
}
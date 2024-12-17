using Script.CoreUObject;

namespace Script.InterchangeCommonParser
{
	[PathName("/Script/InterchangeCommonParser.EInterchangeCurveTangentWeightMode")]
	public enum EInterchangeCurveTangentWeightMode : byte
	{
		WeightedNone = 0,
		WeightedArrive = 1,
		WeightedLeave = 2,
		WeightedBoth = 3,
	}
}
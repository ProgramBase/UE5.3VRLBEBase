using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERichCurveCompressionFormat")]
	public enum ERichCurveCompressionFormat : long
	{
		RCCF_Empty = 0,
		RCCF_Constant = 1,
		RCCF_Linear = 2,
		RCCF_Cubic = 3,
		RCCF_Mixed = 4,
		RCCF_Weighted = 5,
	}
}
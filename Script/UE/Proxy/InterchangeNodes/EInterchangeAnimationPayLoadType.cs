using Script.CoreUObject;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.EInterchangeAnimationPayLoadType")]
	public enum EInterchangeAnimationPayLoadType : byte
	{
		NONE = 0,
		CURVE = 1,
		MORPHTARGETCURVE = 2,
		STEPCURVE = 3,
		BAKED = 4,
		MORPHTARGETCURVEWEIGHTINSTANCE = 5,
	}
}
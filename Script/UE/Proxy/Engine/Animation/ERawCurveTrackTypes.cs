using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERawCurveTrackTypes")]
	public enum ERawCurveTrackTypes : byte
	{
		RCT_Float = 0,
		RCT_Vector = 1,
		RCT_Transform = 2,
	}
}
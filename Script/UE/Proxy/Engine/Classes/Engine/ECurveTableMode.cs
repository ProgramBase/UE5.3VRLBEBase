using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECurveTableMode")]
	public enum ECurveTableMode : long
	{
		Empty = 0,
		SimpleCurves = 1,
		RichCurves = 2,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EUIScalingRule")]
	public enum EUIScalingRule : byte
	{
		ShortestSide = 0,
		LongestSide = 1,
		Horizontal = 2,
		Vertical = 3,
		ScaleToFit = 4,
		Custom = 5,
	}
}
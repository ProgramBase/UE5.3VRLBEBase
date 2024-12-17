using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFFTPeakInterpolationMethod")]
	public enum EFFTPeakInterpolationMethod : byte
	{
		NearestNeighbor = 0,
		Linear = 1,
		Quadratic = 2,
		ConstantQ = 3,
	}
}
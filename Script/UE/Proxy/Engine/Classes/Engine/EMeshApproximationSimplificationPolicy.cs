using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshApproximationSimplificationPolicy")]
	public enum EMeshApproximationSimplificationPolicy : byte
	{
		FixedTriangleCount = 0,
		TrianglesPerArea = 1,
		GeometricTolerance = 2,
	}
}
using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EClusterUnionMethod")]
	public enum EClusterUnionMethod : byte
	{
		PointImplicit = 0,
		DelaunayTriangulation = 1,
		MinimalSpanningSubsetDelaunayTriangulation = 2,
		PointImplicitAugmentedWithMinimalDelaunay = 3,
		BoundsOverlapFilteredDelaunayTriangulation = 4,
		None = 5,
	}
}
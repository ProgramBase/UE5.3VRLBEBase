using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshApproximationBaseCappingType")]
	public enum EMeshApproximationBaseCappingType : byte
	{
		NoBaseCapping = 0,
		ConvexPolygon = 1,
		ConvexSolid = 2,
	}
}
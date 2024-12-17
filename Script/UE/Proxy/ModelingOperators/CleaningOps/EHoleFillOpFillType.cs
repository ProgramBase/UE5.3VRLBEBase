using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EHoleFillOpFillType")]
	public enum EHoleFillOpFillType : byte
	{
		TriangleFan = 0,
		PolygonEarClipping = 1,
		Planar = 2,
		Minimal = 3,
		Smooth = 4,
	}
}
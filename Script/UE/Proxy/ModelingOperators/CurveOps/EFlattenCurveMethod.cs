using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EFlattenCurveMethod")]
	public enum EFlattenCurveMethod : byte
	{
		DoNotFlatten = 0,
		ToBestFitPlane = 1,
		AlongX = 2,
		AlongY = 3,
		AlongZ = 4,
	}
}
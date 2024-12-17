using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ENormalCalculationMethod")]
	public enum ENormalCalculationMethod : byte
	{
		AreaWeighted = 0,
		AngleWeighted = 1,
		AreaAngleWeighting = 2,
	}
}
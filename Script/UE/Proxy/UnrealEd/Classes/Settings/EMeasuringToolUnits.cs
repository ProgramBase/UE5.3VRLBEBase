using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EMeasuringToolUnits")]
	public enum EMeasuringToolUnits : byte
	{
		MeasureUnits_Centimeters = 0,
		MeasureUnits_Meters = 1,
		MeasureUnits_Kilometers = 2,
	}
}
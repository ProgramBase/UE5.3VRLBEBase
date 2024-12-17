using Script.CoreUObject;

namespace Script.LocationServicesBPLibrary
{
	[PathName("/Script/LocationServicesBPLibrary.ELocationAccuracy")]
	public enum ELocationAccuracy : byte
	{
		LA_ThreeKilometers = 0,
		LA_OneKilometer = 1,
		LA_HundredMeters = 2,
		LA_TenMeters = 3,
		LA_Best = 4,
		LA_Navigation = 5,
	}
}
using Script.CoreUObject;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.EPIEPreviewDeviceType")]
	public enum EPIEPreviewDeviceType : byte
	{
		Unset = 0,
		Android = 1,
		IOS = 2,
		TVOS = 3,
		Switch = 4,
	}
}
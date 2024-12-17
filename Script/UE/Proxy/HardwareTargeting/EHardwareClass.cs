using Script.CoreUObject;

namespace Script.HardwareTargeting
{
	[PathName("/Script/HardwareTargeting.EHardwareClass")]
	public enum EHardwareClass : byte
	{
		Unspecified = 0,
		Desktop = 1,
		Mobile = 2,
	}
}
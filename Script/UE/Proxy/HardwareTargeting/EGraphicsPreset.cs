using Script.CoreUObject;

namespace Script.HardwareTargeting
{
	[PathName("/Script/HardwareTargeting.EGraphicsPreset")]
	public enum EGraphicsPreset : byte
	{
		Unspecified = 0,
		Maximum = 1,
		Scalable = 2,
	}
}
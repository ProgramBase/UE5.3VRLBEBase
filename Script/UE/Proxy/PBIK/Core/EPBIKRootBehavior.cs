using Script.CoreUObject;

namespace Script.PBIK
{
	[PathName("/Script/PBIK.EPBIKRootBehavior")]
	public enum EPBIKRootBehavior : byte
	{
		PrePull = 0,
		PinToInput = 1,
		Free = 2,
	}
}
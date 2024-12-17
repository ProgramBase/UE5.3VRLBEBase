using Script.CoreUObject;

namespace Script.PBIK
{
	[PathName("/Script/PBIK.EPBIKLimitType")]
	public enum EPBIKLimitType : byte
	{
		Free = 0,
		Limited = 1,
		Locked = 2,
	}
}
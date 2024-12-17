using Script.CoreUObject;

namespace Script.FullBodyIK
{
	[PathName("/Script/FullBodyIK.EFBIKBoneLimitType")]
	public enum EFBIKBoneLimitType : byte
	{
		Free = 0,
		Limit = 1,
		Locked = 2,
	}
}
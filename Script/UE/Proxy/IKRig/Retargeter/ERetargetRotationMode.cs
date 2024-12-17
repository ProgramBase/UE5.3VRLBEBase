using Script.CoreUObject;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.ERetargetRotationMode")]
	public enum ERetargetRotationMode : byte
	{
		Interpolated = 0,
		OneToOne = 1,
		OneToOneReversed = 2,
		None = 3,
	}
}
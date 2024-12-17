using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigModifyBoneMode")]
	public enum EControlRigModifyBoneMode : byte
	{
		OverrideLocal = 0,
		OverrideGlobal = 1,
		AdditiveLocal = 2,
		AdditiveGlobal = 3,
		Max = 4,
	}
}
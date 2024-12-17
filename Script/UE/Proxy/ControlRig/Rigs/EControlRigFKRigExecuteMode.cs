using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigFKRigExecuteMode")]
	public enum EControlRigFKRigExecuteMode : byte
	{
		Replace = 0,
		Additive = 1,
		Direct = 2,
		Max = 3,
	}
}
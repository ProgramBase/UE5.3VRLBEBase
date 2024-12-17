using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EAimMode")]
	public enum EAimMode : byte
	{
		AimAtTarget = 0,
		OrientToTarget = 1,
	}
}
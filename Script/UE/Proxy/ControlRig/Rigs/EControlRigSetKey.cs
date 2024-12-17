using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigSetKey")]
	public enum EControlRigSetKey : long
	{
		DoNotCare = 0,
		Always = 1,
		Never = 2,
	}
}
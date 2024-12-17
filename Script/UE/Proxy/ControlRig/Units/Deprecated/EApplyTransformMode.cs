using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EApplyTransformMode")]
	public enum EApplyTransformMode : byte
	{
		Override = 0,
		Additive = 1,
		Max = 2,
	}
}
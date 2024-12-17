using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ETransformGetterType")]
	public enum ETransformGetterType : byte
	{
		Initial = 0,
		Current = 1,
		Max = 2,
	}
}
using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigControlValueType")]
	public enum ERigControlValueType : byte
	{
		Initial = 0,
		Current = 1,
		Minimum = 2,
		Maximum = 3,
	}
}
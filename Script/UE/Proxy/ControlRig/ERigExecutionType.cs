using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigExecutionType")]
	public enum ERigExecutionType : byte
	{
		Runtime = 0,
		Editing = 1,
		Max = 2,
	}
}
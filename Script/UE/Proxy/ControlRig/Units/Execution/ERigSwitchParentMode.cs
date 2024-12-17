using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigSwitchParentMode")]
	public enum ERigSwitchParentMode : byte
	{
		World = 0,
		DefaultParent = 1,
		ParentItem = 2,
	}
}
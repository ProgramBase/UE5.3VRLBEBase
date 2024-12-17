using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigSpaceType")]
	public enum ERigSpaceType : byte
	{
		Global = 0,
		Bone = 1,
		Control = 2,
		Space = 3,
	}
}
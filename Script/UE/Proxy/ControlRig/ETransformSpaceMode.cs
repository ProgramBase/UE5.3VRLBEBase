using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ETransformSpaceMode")]
	public enum ETransformSpaceMode : byte
	{
		LocalSpace = 0,
		GlobalSpace = 1,
		BaseSpace = 2,
		BaseJoint = 3,
		Max = 4,
	}
}
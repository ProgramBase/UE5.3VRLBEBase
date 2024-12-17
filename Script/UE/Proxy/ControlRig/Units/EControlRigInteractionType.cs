using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigInteractionType")]
	public enum EControlRigInteractionType : long
	{
		None = 0,
		Translate = 1,
		Rotate = 2,
		Scale = 4,
		All = 7,
	}
}
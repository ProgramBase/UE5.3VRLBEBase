using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigControlVisibility")]
	public enum ERigControlVisibility : byte
	{
		UserDefined = 0,
		BasedOnSelection = 1,
	}
}
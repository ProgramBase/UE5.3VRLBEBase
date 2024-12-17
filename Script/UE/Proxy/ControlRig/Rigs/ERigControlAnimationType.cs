using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigControlAnimationType")]
	public enum ERigControlAnimationType : byte
	{
		AnimationControl = 0,
		AnimationChannel = 1,
		ProxyControl = 2,
		VisualCue = 3,
	}
}
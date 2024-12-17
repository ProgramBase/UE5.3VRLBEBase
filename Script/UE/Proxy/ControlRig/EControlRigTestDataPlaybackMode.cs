using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EControlRigTestDataPlaybackMode")]
	public enum EControlRigTestDataPlaybackMode : byte
	{
		Live = 0,
		ReplayInputs = 1,
		GroundTruth = 2,
		Max = 3,
	}
}
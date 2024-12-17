using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleReplayState")]
	public enum ParticleReplayState : long
	{
		PRS_Disabled = 0,
		PRS_Capturing = 1,
		PRS_Replaying = 2,
	}
}
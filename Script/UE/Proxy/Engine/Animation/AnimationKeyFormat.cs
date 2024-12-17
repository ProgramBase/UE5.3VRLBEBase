using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationKeyFormat")]
	public enum AnimationKeyFormat : long
	{
		AKF_ConstantKeyLerp = 0,
		AKF_VariableKeyLerp = 1,
		AKF_PerTrackCompression = 2,
	}
}
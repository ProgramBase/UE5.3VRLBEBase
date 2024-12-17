using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimationMode")]
	public enum EAnimationMode : byte
	{
		AnimationBlueprint = 0,
		AnimationSingleNode = 1,
		AnimationCustomMode = 2,
	}
}
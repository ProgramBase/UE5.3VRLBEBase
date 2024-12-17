using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBoneTranslationRetargetingMode")]
	public enum EBoneTranslationRetargetingMode : byte
	{
		Animation = 0,
		Skeleton = 1,
		AnimationScaled = 2,
		AnimationRelative = 3,
		OrientAndScale = 4,
	}
}